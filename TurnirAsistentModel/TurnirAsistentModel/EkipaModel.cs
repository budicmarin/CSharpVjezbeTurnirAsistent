using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class EkipaModel
    {
        /// <summary>
        /// U ovoj listi se nalaze članovi ekipe
        /// </summary>
        public List<OsobaModel> ClanoviModel { get; set; } = new List<OsobaModel>();
        /// <summary>
        /// Ime ekipe na turniru
        /// </summary>
        public string ImeEkipe { get; set; }
    }
}
