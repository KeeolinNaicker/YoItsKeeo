using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public class Basket
    {
        double final = 0;
        public List<Shirt> shirts = new List<Shirt>();
        public List<Pants> pants = new List<Pants>();

        public double getTotal()
        {
            foreach(var ValueShirts in shirts)
            {
                final += ValueShirts.getdefaultprice();
            }
            foreach (var ValuePants in pants)
            {
                final += ValuePants.getdefaultprice();
            }
            return final;


        }


    }
}
