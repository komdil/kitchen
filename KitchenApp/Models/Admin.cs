﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenApp.Models
{
    public class model : User
    {
        public override string Role { get { return Helper.ADMIN_ROLE; } }
    }
}
