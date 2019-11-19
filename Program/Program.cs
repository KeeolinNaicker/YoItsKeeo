using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;



namespace Program
{
    class Program
    {
         
        static void Main(string[] args)
        {
            var Basket = new Basket();

            var Tshirt = new TShirt();
            Tshirt.name = " DC Comics";
            Tshirt.size = "L";
            Basket.shirts.Add(Tshirt);

            var golfer = new Golfer();
            golfer.name = " Marvel";
            golfer.size = "S";
            Basket.shirts.Add(golfer);

            var Formal = new FormalPants();
            Formal.name = "Dark Horse";
            Formal.size = "M";
            Basket.pants.Add(Formal);


            var jeans = new Jeans();
            jeans.name = "Image Comics";
            Formal.size = "L";
            Basket.pants.Add(Formal);


            Console.WriteLine($"The total is R{Basket.getTotal()}");
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
