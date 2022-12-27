﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.Design.Patern.Liskov.Interface;

namespace Udemy.Design.Patern.Liskov
{
    public class Orange : Fruit
    {
        public override string GetColor()
        {
            return "Orage";
        }
    }
}
