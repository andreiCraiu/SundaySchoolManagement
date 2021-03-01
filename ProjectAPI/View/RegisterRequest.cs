using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SundaySchoolManagement.WebApi.View
{
    public class RegisterRequest
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password{ get; set; }
    }
}
