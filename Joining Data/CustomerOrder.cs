using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joining_Data
{
    internal class CustomerOrder
    {
        public string   CustomerName    { get; set; }
        public string   Item            { get; set; }
        public decimal  Price           { get; set; }
        public int      Quantity        { get; set; }

    }
}
