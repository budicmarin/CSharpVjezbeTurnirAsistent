using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class UtakmicaModel
    {
        /// <summary>
        /// Natjecatelji koji sudjeluju u utakmici 
        /// </summary>
        public List<SudionikModel> Natjecatelji { get; set; } = new List<SudionikModel>();
        /// <summary>
        /// Pobjednik odigrane utakmice
        /// </summary>
        public EkipaModel Pobjednik { get; set; } = new EkipaModel();
        /// <summary>
        /// Broj runde u kojoj je igrana utakmica
        /// </summary>
        public int BrojRunde { get; set; }

    }
}
