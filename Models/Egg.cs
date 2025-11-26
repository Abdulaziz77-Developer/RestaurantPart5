using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantPart5.Models
{
    public class Egg : CookedFood , IDisposable
    {
        private static int quality = 0;
        public Egg()
        {
             quality = new Random().Next(1, 100);
        }
        public static int GetQuality()
        {
            return quality;
        }
        public void Crack()
        {
        }
        public void DiscardShell()
        {
        }

        public void Dispose()
        {
            if (quality < 25)
            {
                throw new Exception("Egg quality is small is 25%");
            }
        }
    }
}
