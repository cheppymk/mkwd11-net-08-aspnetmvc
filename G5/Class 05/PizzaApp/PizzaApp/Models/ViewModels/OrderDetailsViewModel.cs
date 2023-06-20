﻿using PizzaApp.Models.Enums;

namespace PizzaApp.Models.ViewModels
{
    public class OrderDetailsViewModel
    {
        public string PizzaName { get; set; }
        public string UserFullName { get; set; }
        public int Price { get; set; }
        public PaymentMethodEnum PaymentMethod { get; set; }

        public int Id { get; set; } //we need this for rdit and details
    }
}
