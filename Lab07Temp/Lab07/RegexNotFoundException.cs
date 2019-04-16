using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class RegexNotFoundException : Exception
    {
        private Exception e;
        public RegexNotFoundException(Exception e)
        {
            this.e = e;
        }
        //Hiç argüman almayan, Sadece mesajı alan , Mesaj ve iç exception'i alan 3 farklı consturoctor tanımlanacak.
    }
}
