using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BackendDellEmc.Models
{
    public class User
    {
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Long/Lat/address")]
        public string longlat { get; set; }
    }
}