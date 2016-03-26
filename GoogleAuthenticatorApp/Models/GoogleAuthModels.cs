using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleAuthenticatorApp.Models
{
    public class GoogleAuthModels
    {
        //new authentication request
        public class AuthRequest
        {
            public string QRCodeImageUrl { get; set; }
            public string ManualEntrySetupCode { get; set; }
        }

        //user key validation
        public class AuthValidate
        {
            public string UserKey { get; set; }
        }
    }
}