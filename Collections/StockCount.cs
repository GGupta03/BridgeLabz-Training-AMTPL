using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzApp.Collections
{
    public class StockCount
    {
        private ConcurrentDictionary<string, int> stock = new ConcurrentDictionary<string, int>();
        public void AddProduct(string id, int qty)
        {
            stock[id] = qty;
        }
        public bool TryConsume(string id, int qty)
        {
            while (true)
            {
                if (!stock.ContainsKey(id))
                    return false;

                int current = stock[id];

                if (current < qty)
                    return false;

                int newValue = current - qty;
                int original = Interlocked.CompareExchange(ref stock[], newValue, current);

                if (original == current)
                    return true; 
            }
        }
}
}
