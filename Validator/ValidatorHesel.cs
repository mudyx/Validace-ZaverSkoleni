using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validator
{
    public class ValidatorHesel
    {
        public bool SpravneHeslo(string heslo)
        {
            if(string.IsNullOrWhiteSpace(heslo)) { return false; }
            if(heslo.Length < 5 || !heslo.Any(char.IsDigit)) { return false; }

            return true;
        }

    }
}
