using System;
using System.ComponentModel.DataAnnotations;

namespace datingAppAPI.Models
{
    public class Login
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        [Timestamp]
        public DateTime LoginTime { get; set; }

    }
}
