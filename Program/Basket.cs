using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Basket
    {
        public double price;
        public string size;

        public List<TShirt> tshirts = new List<TShirt>();
        public List<Golfer> golfers = new List<Golfer>();
        public List<FormalPants> formalPants = new List<FormalPants>();
        public List<Jeans> jeans = new List<Jeans>();

        public double GetTShirtPrice()
        {

            double tprice = 0;
            
            if (tshirts.Any(TShirt => TShirt.Size == "S"))
            {
                tprice += 10; 
            }

            else if (tshirts.Any(TShirt => TShirt.Size == "M"))
            {
                tprice += 20;
            }
            else if (tshirts.Any(TShirt => TShirt.Size == "L"))
            {
                tprice += 30;
            }
            else
            {
                tprice += 0;
            }

            return tprice;
        }
        public double GetGolferPrice()
        {

            double Gprice = 0;

            if (golfers.Any(Golfer => Golfer.Size == "S"))
            {
                Gprice += 20;
            }

            else if (golfers.Any(Golfer => Golfer.Size == "M"))
            {
                Gprice += 40;
            }
            else if (golfers.Any(Golfer => Golfer.Size == "L"))
            {
                Gprice += 60;
            }
            else
            {
                Gprice += 0;
            }

            return Gprice;
        }


        public double GetJeansPrice()
        {
            double Jprice = 0;

            if (jeans.Any(Jeans => Jeans.Size == "S"))
            {
                Jprice += 10;
            }

            else if (jeans.Any(Jeans => Jeans.Size == "M"))
            {
                Jprice += 20;
            }
            else if (jeans.Any(Jeans => Jeans.Size == "L"))
            {
                Jprice += 30;
            }
            else
            {
                Jprice += 0;
            }

            return Jprice;
        }

        public double GetFormalPrice()
        {
            double Fprice = 0;

            if (formalPants.Any(FormalPants => FormalPants.Size == "S"))
            {
                Fprice += 40;
            }

            else if (formalPants.Any(FormalPants => FormalPants.Size == "M"))
            {
                Fprice += 50;
            }
            else if (formalPants.Any(FormalPants => FormalPants.Size == "L"))
            {
                Fprice += 60;
            }
            else
            {
                Fprice += 0;
            }

            return Fprice;
        }



        public double GetTotalPrice()
        {
            price = GetJeansPrice() + GetTShirtPrice() + GetFormalPrice() + GetGolferPrice();
            return price;
        }
    }
}
