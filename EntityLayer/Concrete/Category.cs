using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public int CategoryName { get; set; }
        public int CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
