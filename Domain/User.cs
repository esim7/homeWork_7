﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class User : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
