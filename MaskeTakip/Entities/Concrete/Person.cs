﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int DateOfBrirthYear { get; set; }
    }
}
