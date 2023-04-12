StreamReader sr = new StreamReader("../../../corrupted_data.txt");

string GetField(string? l, int n)
{
    string s = l.Split(';')[n].ToString();
    if (s == "?") return "unknown";
    return s;
}
bool OutputLine()
{
    string l = sr.ReadLine();
    if (l == null) return false;
    Console.WriteLine($"{GetField(l, 2)} ({GetField(l, 0)}):\n\t {GetField(l, 8)} ({GetField(l, 4)})\n\t Vklad: {GetField(l, 7)} EUR");
    return true;
}

while (OutputLine())
{

}

Console.ReadKey();