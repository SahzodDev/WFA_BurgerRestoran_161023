using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerRestoran_161023
{
    public class Menu : SiparisParcasi
    {
        public Menu() 
        {
            Ad = "Yok";
            Fiyat = 0;
        }   

        public override string ToString()
        {
            return Ad;
        }
    }
}
