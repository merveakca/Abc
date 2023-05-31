using Abc.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abc.Northwind.MvcWebUI.Models
{
    public class ShippingDetailsViewModel
    {
        public ShippingDetails Shipping { get; set; }
        public ShippingDetails ShippingDetails { get; internal set; }
    }
}
