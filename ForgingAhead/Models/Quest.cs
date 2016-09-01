using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForgingAhead.Models
{
    public class Quest
    {
        [Key]
        public int QuestId { get; set; }

        public string Name { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        // Many to many-relationship med Character
        public List<Character> Characters { get; set; }
    }
}