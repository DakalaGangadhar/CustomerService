﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.DataModels
{
    public class GetServiceRequestDataModel
    {
        public int srId { get; set; }
        public string description { get; set; }
        public string category { get; set; }
    }
}