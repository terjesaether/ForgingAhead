using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForgingAhead.Models
{
    public class Equipment
    {
        [Key]
        public int EquipmentId { get; set; }
        public string Name { get; set; }
    }
}