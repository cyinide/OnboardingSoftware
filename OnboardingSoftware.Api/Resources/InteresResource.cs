﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OnboardingSoftware.Api.Resources
{
    public class InteresResource
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public bool IsSelected { get; set; }
    }
}
