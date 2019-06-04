using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Golfer 
    {
        public string Name;
        public string Size;

        
        public Golfer()
        {
            Name = "";
            Size = "";
        }
        public Golfer(string Names, string Sizes)
        {
            this.Name = Names;
            this.Size = Sizes;
        }

    }
}
