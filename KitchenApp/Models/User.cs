﻿using System;
using System.Collections.Generic;

namespace KitchenApp.Models
{
    public class User
    {
        Guid id;
        public Guid Id
        {
            get
            {
                if (id == null || id == Guid.Empty)
                {
                    id = new Guid();
                }
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual bool IsAdmin { get { return this is model; } }
        public virtual List<Payment> Payments { get; set; }
        public virtual List<OrderDetail> Details { get; set; }

        public virtual string Role { get { return Helper.USER_ROLE; } }
    }
}
