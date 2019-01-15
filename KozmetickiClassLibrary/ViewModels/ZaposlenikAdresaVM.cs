using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmetickiClassLibrary.ViewModels
{
    public class ZaposlenikAdresaVM
    {
        public ZaposlenikAdresaVM() {
        }
        public zaposlenik zaposlenik { get; set; }
        public adresa adresa { get; set; }
        public List<UslugaVM> usluge { get; set; }
    }
}
