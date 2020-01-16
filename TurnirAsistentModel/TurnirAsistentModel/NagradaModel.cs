using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class NagradaModel
    {
        /// <summary>
        /// Broj osvojenog mjesta
        /// </summary>
        public int OsvojenoMjesto { get; set; }
        /// <summary>
        /// naziv osvojenog mjesta
        /// </summary>
        public string NazivMjesta { get; set; }
        /// <summary>
        /// Kovčani iznos koji ide osvojenom mjestu
        /// </summary>
        public decimal IznosNagrade { get; set; }
        /// <summary>
        /// Koliko posto kotizacije ide za određeno mjesto
        /// </summary>
        public double PostotakNagrade { get; set; }
    }
}
