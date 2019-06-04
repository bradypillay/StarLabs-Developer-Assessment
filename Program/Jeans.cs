using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Jeans 
    {

        public string Name;
        public string Size;

        

        public Jeans()
        {
            Name = "";
            Size = "";
        }
        public Jeans(string Names, string Sizes)
        {
            this.Name = Names;
            this.Size = Sizes;
        }
    }
}
