using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LifeFunding.Web.Models
{
    public class CreateCauseFormModel
    {
        [Required]
        public string Website { get; set; }
        [Required]
        [DisplayName("Stellar Address")]
        public string StellarAddress { get; set; }
        [Required]
        [DisplayName("Fund Goal")]
        public double FundGoal { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime? Deadline { get; set; }

        [Required]
        [DisplayName("Photo URL")]
        public string UrlPhoto { get; set; }
    }
}