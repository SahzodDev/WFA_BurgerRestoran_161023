using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BurgerRestoran_161023
{
    public class Siparis
    {
        public Siparis() 
        {
            Menu = new Menu();
            EkstraMalzemeler = new List<EkstraMalzeme>();
            
            
        }
        public Menu Menu { get; set; }
        public decimal MenuAdedi {  get; set; }
        public string Boy {  get; set; }
        public List<EkstraMalzeme> EkstraMalzemeler { get; set; }
        public decimal ToplamFiyat { get; set; }

        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (EkstraMalzeme ekstraMalzeme in EkstraMalzemeler)
            {
                sb.Append(ekstraMalzeme.Ad);
                if (ekstraMalzeme != EkstraMalzemeler[EkstraMalzemeler.Count - 1]) 
                {
                    sb.Append(", ");
                }
            }

            return $"{MenuAdedi} adet {Menu.Ad}, {Boy} Boy, {sb} => Toplam Fiyat : {ToplamFiyat}";
        }

    }
}
