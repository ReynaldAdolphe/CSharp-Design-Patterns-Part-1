﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Policy
    {
        private int Id { get; set; } = 123;
        private string Insured { get; set; } = "John Roy";

        public string GetInsuredName() => Insured;
    }
}
