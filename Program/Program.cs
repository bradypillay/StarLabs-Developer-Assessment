using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Program
    {


        static void Main(string[] args)
        {
            var basket = new Basket();
            var tshirt = new TShirt();
            var jean = new Jeans();
            var golfer = new Golfer();
            var formal = new FormalPants();

            tshirt.Name = "DC Comics";
            tshirt.Size = "S";

            jean.Name = "Levis";
            jean.Size = "S";

            golfer.Name = "Guess";
            golfer.Size = "S";

            formal.Name = "MR Price";
            formal.Size = "S";


            basket.jeans.Add(jean);
            basket.tshirts.Add(tshirt);
            basket.golfers.Add(golfer);
            basket.formalPants.Add(formal);

            Console.WriteLine($"Your total price is { basket.GetTotalPrice() } ");
            Console.Read();
        }
    }
}
