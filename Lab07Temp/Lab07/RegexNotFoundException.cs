using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class RegexNotFoundException : Exception
    {
        public RegexNotFoundException()
        {

        }

        public RegexNotFoundException(Exception e) : base(e.ToString())
        {

        }

        public RegexNotFoundException(string message) : base(String.Format("Hata" + message))
        {

        }
        //Hiç argüman almayan, Sadece mesajı alan , Mesaj ve iç exception'i alan 3 farklı consturoctor tanımlanacak.
    }
}
