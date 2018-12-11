using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class UserErrorTypeString
    {
        private string errorTypeString;

        public UserErrorTypeString(userErrorType errorType)
        {
            if (errorType == userErrorType.Notexists)
                errorTypeString = "Notexists";
            if (errorType == userErrorType.Exists)
                errorTypeString = "Exists";
            if (errorType == userErrorType.Name)
                errorTypeString = "Name";
            if (errorType == userErrorType.Nickname)
                errorTypeString = "Nickname";
            if (errorType == userErrorType.Password)
                errorTypeString = "Password";
            if (errorType == userErrorType.IPAddress)
                errorTypeString = "IPAddress";
        }

        public string ErrorTypeString { get => errorTypeString; }
    }
}
