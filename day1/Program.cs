int measurementIncreases = 0, windowMeasurementIncreases = 0;
int prevElement = 0;
List<Int32> measurementList = new List<Int32>();
try
{
    using (StreamReader sr = new StreamReader("input.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
         measurementList.Add(Int32.Parse(line));
        // PART 1 //
        foreach (int number in measurementList)
        {
            if (prevElement == 0)
            {
                prevElement = number;
                continue;
            }
            if ( number > prevElement ) 
                measurementIncreases++;
            prevElement = number;    
        }
        prevElement = 0;
        // PART 2 //
        for (int i = 0; i < measurementList.Count(); i++)
            {
                if (i == measurementList.Count() - 2)
                    break;
                if (prevElement == 0)
                {
                    prevElement = measurementList[i] + measurementList[i+1] + measurementList[i+2];
                    continue;
                }
                if (( measurementList[i] + measurementList[i+1] + measurementList[i+2]) > prevElement)
                    windowMeasurementIncreases++;
                prevElement = measurementList[i] + measurementList[i+1] + measurementList[i+2];
            }
    }
    
    Console.WriteLine("PART1: the number of times a depth measurement increases: ");
    Console.WriteLine(measurementIncreases);
    
    Console.WriteLine("PART2: the number of times a depth measurement increases: ");
    Console.WriteLine(windowMeasurementIncreases);
}
catch (Exception e)
{
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}