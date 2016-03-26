using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using GoogleAuthenticatorApp.Models;
using Google.Authenticator;

namespace GoogleAuthenticatorApp
{
    public class GoogleAuthService
    {
        //function to generate new QR Code
        public static GoogleAuthModels.AuthRequest GenerateQRCode()
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            var setupInfo = tfa.GenerateSetupCode("MyGoogleAuthApp", "nyendluri@iws.com", "nagarjunay", 300, 300);

            //return qr image and manual code
            return new GoogleAuthModels.AuthRequest
            {
                QRCodeImageUrl = setupInfo.QrCodeSetupImageUrl,
                ManualEntrySetupCode = setupInfo.ManualEntryKey
            };
        }

        //function to validate user key
        public static bool ValidateUserKey(string key)
        {
            TwoFactorAuthenticator tfa = new TwoFactorAuthenticator();
            //validate user key
            bool isCorrectPIN = tfa.ValidateTwoFactorPIN("nagarjunay", key);

            return isCorrectPIN;
        }
    }
}