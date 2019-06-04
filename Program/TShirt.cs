using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class TShirt
    {
        public string Name = "";
        public string Size = "";

       
        public TShirt()
        {
            Name = "";
            Size = "";
        }

        public TShirt(string Names, string Sizes)
        {
            this.Name = Names;
            this.Size = Sizes;

        }
    }

}
