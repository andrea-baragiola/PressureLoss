using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PressureLossCalculations
{
    public class LocalLosses
    {
        private string _filePath = "C:\\Users\\Andrea\\source\\repos\\PressureLoss\\PressureLossCalculations\\LocalLosses.json";
        public List<List<double>> LocalLosses2DArray { get; set; }
        
        public LocalLosses()
        {
            LocalLosses2DArray = 
                JsonConvert.DeserializeObject<List<List<double>>>(File.ReadAllText(_filePath));
        }
    }
}
