using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordForm
{
    public static class PasswordHelper
    {

        public static char GetMediumChar(this Password pw)
        {
            if (string.IsNullOrEmpty(pw.Pword))
            {
                throw new InvalidOperationException("Пароль пустой");
            }
            if (pw.Pword.Length % 2 == 0)
            {
                return pw.Pword[(pw.Pword.Length / 2) - 1];
            }
            else
            {
                return pw.Pword[pw.Pword.Length / 2];
            }
        }

        public static bool CorrectLength(this Password pw)
        {
            return pw.Pword.Length >= 6 && pw.Pword.Length <= 12;
        }
    }
}
