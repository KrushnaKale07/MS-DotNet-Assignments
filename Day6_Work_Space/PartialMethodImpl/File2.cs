using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialMethodImpl
{
    public partial class Person
    {
        public int Age { get; set; }

        public partial void PrintData();
    }
}
