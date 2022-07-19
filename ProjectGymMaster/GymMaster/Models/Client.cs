using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GymMaster.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Име и презиме")]
        public string nameClient { get; set; }
        [Required]
        [Display(Name = "Висина")]
        public int heightClient { get; set; }
        [Required]
        [Display(Name = "Тежина")]
        public int weightClient { get; set; }
        [Required]
        [Display(Name = "Број на тренинзи на месечно ниво")]
        public int numberOfTraining { get; set; }
        [Required]
        [StringLength(9, MinimumLength = 9)]
        [Display(Name = "Телефон")]
        public string phoneClient { get; set; }
        [Required]
        [Display(Name = "Адреса на живеење")]
        public string addressClient { get; set; }
        [Required]
        [Display(Name = "Тип на тренинг")]
        public String tipTraining { get; set; }
        [Required]
        [Display(Name = "Членска карта")]
        public int clenskaKartaKlient { get; set; }

        [Display(Name = "Мислење и совети")]
        public String infotrener { get; set; }

        public virtual ICollection<Trainer> trainers { get; set; }

        public Client()
        {
            trainers = new List<Trainer>();
        }
    }
}