using System.Collections.ObjectModel;
using System.Reflection;

using Microsoft.Maui.Controls.Shapes;

namespace EconomicRatesDemo
{
    public class ViewModel
    {
        public ObservableCollection<Model> EconomicRate { get; set; }
        public List<Brush> CustomBrushes { get; set; }
        private DateTime year;

        public ViewModel()
        {
            EconomicRate = new ObservableCollection<Model>();
            ReadCSVFile();

            CustomBrushes = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#b1f48a")),
                new SolidColorBrush(Color.FromArgb("#f7a7a1")),
                new SolidColorBrush(Color.FromArgb("#ffe799")),
                new SolidColorBrush(Color.FromArgb("#e6e6ff")),
            };
        }

        private void ReadCSVFile()
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream("EconomicRatesDemo.Resources.dataset.csv");
            string line;
            ObservableCollection<string> lines = new ObservableCollection<string>();
            if (inputStream != null)
            {
                using StreamReader reader = new StreamReader(inputStream);
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);
                }
                lines.RemoveAt(0);

                foreach (var items in lines)
                {
                    string[] data = items.Split(',');
                    if (int.TryParse(data[0], out int yearValue))
                        year = new DateTime(yearValue, 1, 1);
                    double brazilGNI = Convert.ToDouble(data[1]);
                    double chinaGNI = Convert.ToDouble(data[2]);
                    double  ukGNI= Convert.ToDouble(data[3]);
                    double usGNI = Convert.ToDouble(data[4]);
                    EconomicRate.Add(new Model(year,brazilGNI,chinaGNI,ukGNI,usGNI));
                }

            }
        }
    }
}
