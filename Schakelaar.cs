using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Gloeilamp
{
    /// <summary>
    /// Dit is de implementatie van de schakelaar
    /// </summary>
    public class Schakelaar
    {
        /*bool ingeschakeld;
        public bool Ingeschakeld
        {
            get
            {
                return ingeschakeld;
            }
            private set
            {
                ingeschakeld = value;
            }
        }*/

        /// <summary>
        /// Geeft aan of de schakelaar ingeschakeld (true) of uitgeschakeld (false) is
        /// </summary>
        public bool Ingeschakeld { get; private set; }

        public List<Lamp> Lampen { get; set; }

        public Schakelaar()
        {
            Lampen = new List<Lamp>();
        }

        // patroon voor het maken van een method:
        // 1. accesablitiy public/private/internal
        // 2. returnvalue void = geen (kan ook elk ander type zijn)
        // 3. naam van de method in PascalCasing
        // 4. Tussen haakjes de parameterlijst (nu geen parameters)
        public void Omschakelen()
        {

        }
    }
}
