using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class Square : Figure
    {       

        public Square(int size)
        {
            this.Size = size;
        }

        public int Size { get; set; }
        
    }
}
