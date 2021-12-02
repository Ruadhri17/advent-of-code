int measurementIncreases = 0, windowMeasurementIncreases = 0;
List<int> measurementList = new List<int>();
try
{
    using (StreamReader sr = new StreamReader("input.txt"))
    {
        // READ NUMBERS //
        string line;
        while ((line = sr.ReadLine()) != null)
            measurementList.Add(int.Parse(line));
        
        // PART 1 //
        for (int i = 1; i < measurementList.Count(); i++)
            if (measurementList[i] > measurementList[i-1])
                measurementIncreases++;
        
        // PART 2 //
        for (int i = 1; i < measurementList.Count() - 2; i++)
            {
                if ((measurementList[i] + measurementList[i+1] + measurementList[i+2]) > (measurementList[i-1] + measurementList[i] + measurementList[i+1]))
                    windowMeasurementIncreases++;
            }
    }
    
    Console.WriteLine($"PART1: the number of times a depth measurement increases: {measurementIncreases}");
    Console.WriteLine($"PART2: the number of times a depth measurement increases: {windowMeasurementIncreases}");
}
catch (Exception e)
{
    Console.WriteLine($"The file could not be read: {e.Message}");
}