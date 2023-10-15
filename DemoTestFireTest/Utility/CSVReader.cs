using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTestFireTest.Utility
{
    public static class CSVReader
    {
        public static List<UserDetails> LoadUserDetailsFromCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return csv.GetRecords<UserDetails>().ToList();
            }
        }
    }
}
