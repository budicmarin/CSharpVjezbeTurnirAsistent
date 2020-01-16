using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class TurnirModel
    {
        /// <summary>
        /// Naziv turnira 
        /// </summary>
        public string NazivTurnira { get; set; }
        /// <summary>
        /// Novčana svota koja se uplaćuje kako bi
        /// ekipa mogla pristupiti turniru
        /// </summary>
        public decimal Kotizacija { get; set; }
        /// <summary>
        /// Lista u kojoj su spremljeni svi prijavljeni timovi
        /// koji igraju turnir
        /// </summary>
        public List<EkipaModel> PrijavljeniTimovi { get; set; } = new List<EkipaModel>();
        /// <summary>
        /// Lista nagrada na turniru
        /// </summary>
        public List<NagradaModel> Nagrade { get; set; } = new List<NagradaModel>();
        /// <summary>
        /// Naziv i broj runde 
        /// koje se igraju na turniru 
        /// prva lista se koristi za broj rundi u turniru,a druga
        /// za proj utakmica u rundi
        /// </summary>
        public List<List<UtakmicaModel>> Runde  { get; set; }= new List<List<UtakmicaModel>>();
    }
}
