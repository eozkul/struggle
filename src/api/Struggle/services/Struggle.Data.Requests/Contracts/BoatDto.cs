using Struggle.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struggle.Data.Requests.Contracts
{
    public class BoatDto
    {
        public Guid Id { get; set; }
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}
