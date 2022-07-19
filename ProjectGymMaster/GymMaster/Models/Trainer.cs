using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymMaster.Models
{
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име и презиме")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Е-маил")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Телефонски број")]
        public int Phone { get; set; }
        [Display(Name = "Код на вработен")]
        public int kod { get; set; }
        public string Image { get; set; }
        public virtual ICollection<Client> clients { get; set; }
        public Trainer()
        {
            clients = new List<Client>();
        }
    }
}