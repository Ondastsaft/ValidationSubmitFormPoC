﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormPageLibrary
{
    public abstract class ParameterValue
    {
        public int Id { get; set; }
        public abstract object Value { get; set; }
    }
}
