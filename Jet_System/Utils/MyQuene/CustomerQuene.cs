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


        public int CurrentCount {
            get { return SavedTables.ToList().Count(); }
        }
        ConcurrentQueue<ProductTables> SavedTables;
      
        private readonly int Count;
        public CustomerQuene(int count)
        {
            SavedTables = new ConcurrentQueue<ProductTables>();
          
            Count = count;
        }

        public ProductTables this[int index]
        {
            get
            {
                return SavedTables.ToList()[index];
            }

        }
        public IEnumerable<bool> GetResults()
        {
            var temp =  SavedTables.ToList();
            var re = from xx in temp select xx.Result;
            return re; 
        }

        public void Add(ProductTables _product)
        {
            SavedTables.Enqueue(_product);
            

            while (SavedTables.Count> Count)
            {
                ProductTables trush_product;
                while (!SavedTables.TryDequeue(out trush_product)) ;
                
                trush_product.Dispose();
                
            }
            Console.WriteLine(SavedTables.Count);
        }

        public void Clear()
        {
            SavedTables = new ConcurrentQueue<ProductTables>();
        }

    }
}
