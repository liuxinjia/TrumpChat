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
            else if (errorType == userErrorType.Exists)
                errorTypeString = "Exists";
            else if (errorType == userErrorType.Name)
                errorTypeString = "Name";
            else if (errorType == userErrorType.Nickname)
                errorTypeString = "Nickname";
            else if (errorType == userErrorType.Password)
                errorTypeString = "Password";
            else if (errorType == userErrorType.IPAddress)
                errorTypeString = "IPAddress";
        }

        public string ErrorTypeString { get => errorTypeString; }
    }
}
