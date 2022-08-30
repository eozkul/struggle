using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struggle.Data.Requests.Contracts
{
    public class UpdateCarDto
    {
        public Guid Id { get; set; }    
        public bool HeadLights { get; set; }
    }
}
