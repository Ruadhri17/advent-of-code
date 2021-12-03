string gammaRate = "", epsilonRate = "";
List<string> findNumber = new List<string>();
string[] lines;
int oxygen = 0, carbon = 0;
lines = File.ReadAllLines("input.txt");
// part 1 //
findNumber = lines.ToList();
for (int i = 0; i < findNumber.First().Length; i++)
{
    if (findNumber.FindAll(s => s[i] == '0').Count >= findNumber.FindAll(s => s[i] == '1').Count)
    {
        gammaRate += '0';
        epsilonRate += '1';
    }
    else
    {
        gammaRate += '1';
        epsilonRate += '0';
    }
}
Console.WriteLine("Power Consumption: " + Convert.ToInt32(gammaRate, 2) * Convert.ToInt32(epsilonRate, 2));
// part 2 //

int j = 0;
// calc oxygen // 
while (findNumber.Count != 1)
{
    if (findNumber.FindAll(s => s[j] == '1').Count >= findNumber.FindAll(s => s[j] == '0').Count)
        findNumber.RemoveAll(s => s[j] == '0');
    else
         findNumber.RemoveAll(s => s[j] == '1');
    j++;
}
oxygen = Convert.ToInt32(findNumber.First(), 2);
findNumber = lines.ToList();
j = 0;
// calc carbon // 
while (findNumber.Count != 1)
{
    if (findNumber.FindAll(s => s[j] == '1').Count >= findNumber.FindAll(s => s[j] == '0').Count)
        findNumber.RemoveAll(s => s[j] == '1');
    else
        findNumber.RemoveAll(s => s[j] == '0');
    j++;
}
carbon = Convert.ToInt32(findNumber.First(), 2);    
Console.WriteLine("Life support rating: " + carbon * oxygen);