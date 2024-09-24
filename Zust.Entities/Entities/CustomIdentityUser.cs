using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zust.Entities.Entities
{
    public class CustomIdentityUser : IdentityUser
    {
        public string? Image { get; set; }
        public bool IsOnline { get; set; }
        public DateTime DisConnectTime { get; set; } = DateTime.Now;
        public string? ConnectTime { get; set; } = "";
    }
}
