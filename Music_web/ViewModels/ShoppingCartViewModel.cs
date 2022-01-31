using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Music_web.Models;

namespace Music_web.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}