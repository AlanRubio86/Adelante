using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adelante.Core.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public bool Active { get; set; }
        public List<ClientNeighborhoodModel> ClientNeighborhoods { get; set; }
    }
}
