using RestaurantPart5.Interfaces;
using RestaurantPart5.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPart5.Business_Logic
{
    public class TableRequest : IEnumerable
    {
        public Dictionary<string,List<IMenuItems>> menuItems = new Dictionary<string, List<IMenuItems>>();
        public void Add<T>(string customerName) where T : IMenuItems
        {
            var item = Activator.CreateInstance<T>();
            if(menuItems.ContainsKey(customerName))
            {
                menuItems[customerName].Add(item);
            }
            menuItems[customerName] = new List<IMenuItems> { item }; 
        }
        public List<T> Get<T>() where T : IMenuItems
        {
            var list = new List<T>();
            foreach (var orders in menuItems)
            {
                foreach (var order in orders.Value)
                {
                    if (order.GetType() is T)
                    {
                        list.Add((T)order);
                    }
                }
            }
            return list;
        }
        public void Add(string customerName, Drink drink)
        {
            if (menuItems.ContainsKey(customerName))
            {
                menuItems[customerName].Add(drink);
            }
            menuItems[customerName].Add(drink);
        }
        public IEnumerator<string> GetEnumerator()
        {
           return menuItems.Keys.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        public List<IMenuItems> this[string name] => menuItems.TryGetValue(name,out var list) ? list : new List<IMenuItems>();
    }
}
