using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Service_TZ.DataAccess.Models
{
    public class Query
    {

        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime DateFrom { get; set;}

        public DateTime DateTo { get; set;}
        public Guid UserId { get; set; }

        // Сылка на User для EF
        public User User { get; set; }
    }
}
