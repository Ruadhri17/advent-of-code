string line;
int depthPos = 0, betterDepthPos = 0, horizontalPos = 0, aim = 0; 
try 
{
    using (StreamReader sr = new StreamReader("input.txt"))
    {

        while ((line = sr.ReadLine()) != null)
        {
            string[] lineSplitted = line.Split();
            if(lineSplitted[0] == "forward")
            {
                horizontalPos += int.Parse(lineSplitted[1]);
                betterDepthPos += aim * int.Parse(lineSplitted[1]);
            }
            else if(lineSplitted[0] == "down") 
            {
                depthPos += int.Parse(lineSplitted[1]);
                aim += int.Parse(lineSplitted[1]);
            }
            else if(lineSplitted[0] == "up")
            {
                depthPos -= int.Parse(lineSplitted[1]);
                aim -= int.Parse(lineSplitted[1]);
            }
            else
                continue;
        }
    }
    Console.WriteLine($"PART1: Final Position is: {depthPos*horizontalPos}");
    Console.WriteLine($"PART2: Final Position is: {betterDepthPos*horizontalPos}");
}
catch (Exception e)
{
    Console.WriteLine($"The file could not be read: {e.Message}");
}