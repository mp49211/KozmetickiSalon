using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KozmetickiClassLibrary.ViewModels
{
    public class ArtikliVM
    {
        public ArtikliVM()
        {
            Arts = new List<artikl>();
            Dict = new Dictionary<int, int>();
            Kols = new List<int>();
        }
        public List<artikl> Arts { get; set; }
        public List<int> Kols { get; set; }
        public Dictionary<int, int> Dict { get; set; }
    }
}
