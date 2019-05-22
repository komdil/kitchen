﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenApp.Models.Exceptions
{
    public class MenuAleadyIsExsistException:Exception
    {
        public MenuAleadyIsExsistException(string name) : base($"Menu with name {name} is aleady exsist")
        {

        }

    }
}
