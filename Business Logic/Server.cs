using RestaurantPart5.Interfaces;
using RestaurantPart5.Models;
using RestaurantPart5.Models.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantPart5.Business_Logic
{
    public class Server
    {
        TableRequest tableRequest = new TableRequest();
        private SemaphoreSlim semaphore;
        private object locker = new object();
        private Cook cook = new Cook();
        private Cook cook2 = new Cook();

        public Server()
        {
            semaphore = new SemaphoreSlim(2);
            cook.countCook = 1;
            cook2.countCook = 2;
        }

        public void TakeOrder(string customerName, int amountEgg, int amountChicken, string drink)
        {
            for (int i = 0; i < amountEgg; i++)
                tableRequest.Add<Egg>(customerName);
            for (int i = 0; i < amountChicken; i++)
                tableRequest.Add<Chicken>(customerName);

            Drink _drink = drink switch
            {
                "Tea" => new Tea("Tea"),
                "Fanta" => new Fanta("Fanta"),
                "Pepsi" => new Pepsi("Pepsi"),
                _ => new NoDrink("No Drink")
            };
            tableRequest.Add(customerName, _drink);
        }
        public async Task<List<string>> SendToCook()
        {
            List<string> currentResults = new List<string>();
            TableRequest orderToProcess;
            lock (locker)
            {
                orderToProcess = tableRequest;
                tableRequest = new TableRequest();
            }

            await semaphore.WaitAsync();
            await Task.Run(async () =>
            {
                Cook selectedCook = null;
                try
                {
                    lock (locker)
                    {
                        selectedCook = !cook.IsBusy ? cook : cook2;
                        selectedCook.IsBusy = true;
                    }

                    await selectedCook.PrepareOrderAsync(orderToProcess);
                    foreach (var customerName in orderToProcess.menuItems.Keys.OrderBy(n => n))
                    {
                        var items = orderToProcess[customerName];
                        int eggs = items.Count(i => i is Egg);
                        int chicken = items.Count(i => i is Chicken);
                        string drinkName = items.OfType<Drink>().FirstOrDefault()?.GetDrinkName ?? "No Drink";

                        await Task.Delay(2000);

                        currentResults.Add($"Cook {selectedCook.countCook} Prepared Customer {customerName} served {eggs} Egg, {chicken} Chicken, {drinkName}");
                    }
                }
                finally
                {
                    lock (locker)
                    {
                        if (selectedCook != null) selectedCook.IsBusy = false;
                    }
                    semaphore.Release();
                }
            });

            return currentResults;
        }
    }
}