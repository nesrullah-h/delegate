using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate.Models
{
    internal abstract class Medicine
    {
        private int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }  
        public int Count { get; set; }
        public bool IsDeleted = false;

        public void Sell()
        {
            Count--;
        }
        
        public void ShowInfo()
        {

        }

        
        

    }
}


