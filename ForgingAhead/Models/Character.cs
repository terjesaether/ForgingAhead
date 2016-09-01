using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForgingAhead.Models
{
    public class Character
    {
        [Key]
        public int CharId { get; set; }
        public string Name { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strenght { get; set; }
        public int Dexterety { get; set; }
        public int Intelligence { get; set; }

        // Many to many relationship med Equipment. En char kan ha en haug med Equipment
        public List<Equipment> Equimpment { get; set; }
    }
}