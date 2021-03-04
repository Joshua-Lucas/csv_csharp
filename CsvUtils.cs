using System;
using System.Collections.Generic;
using System.IO;
class CsvUtils
{
    public List<string> readCsvFile(string filepath)
    {

        var reader = new StreamReader(File.OpenRead(filepath));
        List<string> csvData = new List<string>();

        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            csvData.Add(line);

        }




        return csvData;
    }
}