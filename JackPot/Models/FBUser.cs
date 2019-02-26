using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace userlogin.Models
{
    public class FBUser
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pictureurl { get; set; }
        public string Email { get; set; }

    }
}