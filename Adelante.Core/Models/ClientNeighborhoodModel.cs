using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adelante.Core.Models
{
    public class ClientNeighborhoodModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ActiveNeighborhoodModel ActiveNeighborhood { get; set; }
    }
}
