﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenApp.Models
{
    public class Admin : User
    {
        public void AddNewUser(User user)
        {
            throw new NotImplementedException();
        }

        public void Delete(User user)
        {
            throw new NotImplementedException();
        }
        public void SelectMenuForToday(Menu menu)
        {
            Order order = new Order() {Id= new Guid(), Date = DateTime.Now};
            order.Menu = menu;                
            menu.Orders.Add(order);
        }
        public override string Role { get { return Helper.ADMIN_ROLE; } }

        public void SetPrice(decimal price)
        {
            throw new NotImplementedException();
        }

        public void GetPayment(User user, decimal payment)
        {
            throw new NotImplementedException();
        }
    }
}
