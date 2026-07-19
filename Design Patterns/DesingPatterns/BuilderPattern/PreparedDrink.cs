using System;
using System.Collections.Generic;
using System.Text;

namespace DesingPatterns.BuilderPattern
{
    public class PreparedDrink
    {
        public List<string> Ingredients  =  new List<string>();
        public int Milk;
        public int Water;
        public decimal Alcohol;

        public string Result;
       
    }
}
