using System;
using System.Collections.Generic;
using System.Text;

namespace Project4
{
    class ApplicationLicense
    {
        private string _keypro;
        private string _keytrial;
        public ApplicationLicense(string keypro, string keytrail)
        {
            this._keypro = keypro;
            this._keytrial = keytrail;
        }
        public string AllowTrial(string keytrial) 
        {
            if (keytrial == "KXQQE2")
            {

                string n = "У вас пробна версія";
                return n;
            }
            else
            {
                return null;
            }
        }
        public string AllowCommon(string keypro, string keytrail)
        {
            if (keypro == "" && keytrail == "")
            {
                return "У вас бесплатна версія";
            }
            else
            {
                return null;
            }
        }
        public string AllowPro(string keypro)
        {
            if (keypro == "RTUIEP")
            {
                return "У вас платна версія";
            }
            else
            {
                return null;
            }
        }
        public void Out()
        {
            Console.WriteLine($"{AllowTrial(_keytrial)}");
            Console.WriteLine($"{AllowCommon(_keypro,_keytrial)}");
            Console.WriteLine($"{AllowPro(_keypro)}");
        }
    }
}
