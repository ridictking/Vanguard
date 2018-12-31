using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectTaa.Models
{
    public class Log
    {
        public int ID { get; set; }


        [Required]
        [Display(Name = "Full Name")]
        public string CallerName { get; set; }


        [EmailAddress]
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Log Date")]
        public DateTime LogDate { get; set; }

        [Phone]
        [Required]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        public States State { get; set; }

        [Required]
        [Display(Name = "Local Government")]
        public string LocalGovernment { get; set; }

        [Required]
        [Display(Name = "Street")]
        public string StreetName { get; set; }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = $"{StreetName}, {LocalGovernment}"; }
        }

        [MinLength(5)]
        [MaxLength(1024)]
        [Required]
        [Display(Name = "Job Description")]
        public string CallDescription { get; set; }

        [Display(Name = "Importance")]
        public Level ImportanceLevel { get; set; }
    }
    public enum Level
    {
        High, Medium, Low
    }
    public enum States
    {
        Oyo, Ogun, Osun, Ondo, Lagos, Abia
    }
}
