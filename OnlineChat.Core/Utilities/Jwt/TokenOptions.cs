﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineChat.Core.Utilities.Jwt
{
    public class TokenOptions
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int AccessTokenExpiration { get; set; }
        public string SecurityKey { get; set; }
    }
}
