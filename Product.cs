using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    public abstract class Product
    {
        public string name;
        public string size;

        public string Name { get => name; set => name = value; }

    
        public string Size { get => size; set => size = value; }
        

        public Product()
        {
            Name = "";
            Size = "";
        }

        public Product(string S, string N)
        {
            Name = N;
            Size = S;
        }
        public abstract double getdefaultprice();

    
}


    public class Shirt : Product
    {

        public Shirt()
        {

        }
        public Shirt(string name, string size) : base(name, size)
        {

        }
        public override double getdefaultprice()
        {
            double price = 0.0;
            if(size == "S")
            {
                price = 10;
            }
            else if (size == "M")
            {
                price = 20;
            }
            else
            {
                price = 30;
            }
            return price;
        }
    }
    public class TShirt : Shirt
    {
        public TShirt() : base()
        {

        }
        public TShirt( string name, string size): base(name,size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice();
        }
    }
    public class Golfer : Shirt
    {
        public Golfer():base()
        {

        }
        public Golfer (string name,string size): base(name,size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice() * 2;
        }
    }
    public class Pants : Product
    {
        public Pants()
        {
            
        }
        public Pants(string name,string size): base(name,size)
        {

        }
        public override double getdefaultprice()
        {
            double price = 0.0;
            if (size == "S")
            {
                price = 10;
            }
            else if (size == "M")
            {
                price = 20;
            }
            else
            {
                price = 30;
            }
            return price;
        }
    }
    public class Jeans : Pants
    {
        public Jeans(): base()
        {

        }
        public Jeans(string name, string size): base(name,size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice();
        }
    }
        public class FormalPants : Pants
    {
        public FormalPants():base()
        {

        }
        public FormalPants(string name,string size) : base(name,size)
        {

        }
        public override double getdefaultprice()
        {
            return base.getdefaultprice() + 30;
        }
    }

}
