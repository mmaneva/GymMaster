using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMaster.Models
{
    public class TrainerClients
    {
        public int TrainerId { get; set; }
        public int ClientId { get; set; }
        public Trainer trainer { get; set; }
        public List<Client> clients { get; set; }
    }
}