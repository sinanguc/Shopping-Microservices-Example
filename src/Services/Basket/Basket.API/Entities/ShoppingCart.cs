﻿using System.Collections.Generic;

namespace Basket.API.Entities
{
    public class ShoppingCart
    {
        public string Username { get; set; }
        public List<ShoppingCartItem> Items { get; set; } = new List<ShoppingCartItem>();

        public ShoppingCart()
        {

        }

        public ShoppingCart(string userName)
        {
            Username = userName;
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalprice = 0;
                Items.ForEach(item => totalprice += item.Price * item.Quantity);
                return totalprice;
            }
        }
    }
}
