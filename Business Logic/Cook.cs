using RestaurantPart5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPart5.Business_Logic
{
    public class Cook
    {
        public bool IsBusy { get;  set; }
        public int countCook { get; set; }
        public async Task PrepareOrderAsync(TableRequest tableRequest)
        {
            foreach (var item in tableRequest.Get<Chicken>().ToList())
            {
                item.Obtain();
                item.Cutup();
                item.Serve();
                await Task.Delay(2000);
            }
            foreach (var item in tableRequest.Get<Egg>().ToList())
            {
                using (item)
                {
                    item.Obtain();
                    item.DiscardShell();
                    item.Crack();
                    item.Cook();
                    item.Serve();
                    await Task.Delay(2000);
                }
            }
        }
    }
}
