

using System.Globalization;

namespace EconomicRatesDemo
{
    public class Model
    {
        public DateTime Year { get; set; }

        public double BrazilGNI { get; set; }

        public double ChinaGNI { get; set; }

        public double UKGNI { get; set; }

        public double USGNI { get; set; }

        public Model(DateTime year, double brazilGNI, double chinaGNI, double ukGNI, double usGNI)
        {
            Year = year;
            BrazilGNI = brazilGNI;
            ChinaGNI = chinaGNI;
            UKGNI = ukGNI;
            USGNI = usGNI;
        }
    }
}
