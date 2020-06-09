using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace sendsatTimeclock.Models
{

    public class Time
    {
        public int TimeId { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public float TotalTime { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
    }
}