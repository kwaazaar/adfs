using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace WebApp_WSFederation_DotNet.Models
{
    public class HomeIndexModel
    {
        public bool IsDomainUser { get; set; } = false;
        public bool IsRobUser { get; set; } = false;
        public List<Claim> Claims { get; set; } = new List<Claim>();
    }
}