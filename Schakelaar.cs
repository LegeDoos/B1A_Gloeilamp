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

        // accesablitiy public/private
        // returnvalue void = geen
        // naam van de method
        public void Omschakelen()
        {

        }
    }
}
