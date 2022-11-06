using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
    public class ServiceRequestAssign
    {
        [Key]
        public int assignId { get; set; }
        public string assignname { get; set; }
        public int srcId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
