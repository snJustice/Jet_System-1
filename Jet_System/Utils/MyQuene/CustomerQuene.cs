using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Jet_System.Utils.MyQuene
{
    public class CustomerQuene
    {
        ConcurrentQueue<ProductTables> SavedTables;
        public CustomerQuene()
        {
            SavedTables = new ConcurrentQueue<ProductTables>();
        }

        public ProductTables this[int index]
        {
            get
            {
                return SavedTables.ToList()[index];
            }

        }


        public void Add(ProductTables _product)
        {
            SavedTables.Enqueue(_product);

            while(SavedTables.Count>6)
            {
                ProductTables trush_product;
                while (!SavedTables.TryDequeue(out trush_product)) ;
                SavedTables.TryDequeue(out trush_product);
                trush_product.Dispose();
            }

        }

    }
}
