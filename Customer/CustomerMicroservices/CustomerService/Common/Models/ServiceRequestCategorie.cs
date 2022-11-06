using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Common.Models
{
    public class ServiceRequestCategorie
    {
        [Key]
        public int srcId { get; set; }
        public string categoryname { get; set; }
    }
}
