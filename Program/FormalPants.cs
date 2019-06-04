using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class FormalPants 
    {
        public string Name;
        public string Size;

        
        public FormalPants()
        {
            Name = "";
            Size = "";
        }
        public FormalPants(string Names, string Sizes)
        {
            this.Name = Names;
            this.Size = Sizes;
        }
    }
}
