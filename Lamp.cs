using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Gloeilamp
{
    /// <summary>
    /// Representeert de lamp
    /// </summary>
    class Lamp
    {
        /// <summary>
        /// Type materiaal van de lamp (glas/kunstof)
        /// </summary>
        public string TypeMateriaal { get; set; }
        /// <summary>
        /// Gebruikte techniek zoals led of halogeen
        /// </summary>
        public string VerlichtingsTechniek { get; set; }
        /// <summary>
        /// De temperatuur van het licht in Kelvin
        /// </summary>
        public int LichtTemperatuur { get; set; }
        /// <summary>
        /// Het vermogen van de lamp in WattBLA
        /// </summary>
        public int Vermogen { get; set; }
        /// <summary>
        /// De soort fitting zoals E27 of GU10
        /// </summary>
        public string Fitting { get; set; }
        /// <summary>
        /// Het verwachtte aantal branduren van de lamp in uren
        /// </summary>
        public int Branduren { get; set; }
        /// <summary>
        /// De lichtopbrengst in Lumen
        /// </summary>
        public int LichtOpbrengst { get; set; }
        /// <summary>
        /// De status van de lamp (true is aan)
        /// </summary>
        public bool StaatAan { get; private set; }
        
        /// <summary>
        /// Schakel de lamp in
        /// </summary>
        public void Inschakelen()
        {

        }

        /// <summary>
        /// Schakel de lamp uit
        /// </summary>
        public void Uitschakelen()
        {

        }
    }
}
