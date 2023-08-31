using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIP_Service_TZ.DataAccess.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        // Сылка на Query для EF
        public List<Query> Queries { get; set; }
    }
}
