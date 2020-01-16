using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnirAsistentModel
{
    public class OsobaModel
    {   /// <summary>
        ///Ime člana tima 
        /// </summary>
        public string Ime { get; set; }
        /// <summary>
        /// Prezime člana tima
        /// </summary>
        public string Prezime { get; set; }
        /// <summary>
        /// Email adresa člana tima
        /// potrebno za slanje obavjesti o turniru
        /// </summary>
        public string EmailAdresa{ get; set; }
        /// <summary>
        /// Broj mobitela člana tima 
        /// potrebno za slanje obavjesti o turniru
        /// </summary>
        public string BrojMobitela { get; set; }

    }
}
