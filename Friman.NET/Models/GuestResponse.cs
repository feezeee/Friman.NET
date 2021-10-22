using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friman.NET.Models
{
    public class GuestResponse
    {
        public string Name;
        public string Email { get; set; }        
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }
    }
}
