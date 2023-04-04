﻿using WebLuto.Models.Enums.UserEnum;

namespace WebLuto.Models
{
    public class User : BaseEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public long Salt { get; set; }

        public UserType Type { get; set; }
    }
}