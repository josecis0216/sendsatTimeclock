using System;
using System.Collections.Generic;

namespace sendsatTimeclock.Models
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Ext { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
        public string Status { get; set; }

    }
}