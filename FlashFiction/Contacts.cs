﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashFiction
{
    internal class Contacts
    {

        public Contacts(string name, string number)
        {
            Name = name;
            Number = number;
        }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
