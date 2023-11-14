List<Student> students = new List<Student>();

StreamReader reader = new StreamReader(@"C:\Users\Nasiri-PC\source\repos\Tamrin\Tamrin\a.txt.txt");

while (!reader.EndOfStream);
{
    string line = reader.ReadLine();

    Student student = new Student();

    student.FName = line.Split(',')[0];

    student.LName = line.Split(',')[1];

    student.MathMark = Convert.ToDouble(line.Split(',')[2]);

    student.Pishrafte1Mark = Convert.ToDouble(line.Split(',')[3]);

    student.TafsirMark = Convert.ToDouble(line.Split(',')[4]);

    student.KargahMark = Convert.ToDouble(line.Split(',')[5]);

    student.EnglishMark = Convert.ToDouble(line.Split(',')[6]);

    student.Pishrafte2Mark = Convert.ToDouble(line.Split(',')[7]);

    student.SheygarayeeMark = Convert.ToDouble(line.Split(',')[8]);

    student.TarbiatbadaniMark = Convert.ToDouble(line.Split(',')[9]);

    student.OSMark = Convert.ToDouble(line.Split(',')[10]);

    student.AlgoritmMark = Convert.ToDouble(line.Split(',')[11]);

    students.Add(student);

    double x = (double)student.KargahMark;
    switch (x)
    {
        case double n when (n <= 20 || n >= 17):
            Console.WriteLine("A");
            break;
        case double n when (n < 17 || n >= 15):
            Console.WriteLine("B");
            break;
        case double n when (n < 15 || n >= 13):
            Console.WriteLine("C");
            break;
        case double n when (n < 13 || n >= 10):
            Console.WriteLine("D");
            break;
        case double n when (n < 10 || n >= 7):
            Console.WriteLine("E");
            break;
        case double n when (n < 7 || n >= 3):
            Console.WriteLine("F");
            break;
        default:
            Console.WriteLine("G");
            break;
    }
}
foreach (var student in students)
{
    Console.WriteLine(student.TotalAverage());
}
class Student
{
    public string FName { get; set; }
    public string LName { get; set; }
    public double MathMark { get; set; }
    public double Pishrafte1Mark { get; set; }
    public double TafsirMark { get; set; }
    public double KargahMark { get; set; }
    public double EnglishMark { get; set; }
    public double Pishrafte2Mark { get; set; }
    public double SheygarayeeMark { get; set; }
    public double TarbiatbadaniMark { get; set; }
    public double OSMark { get; set; }
    public double AlgoritmMark { get; set; }

    public double TotalAverage()
    {
        return ((MathMark * 2) + (Pishrafte1Mark * 2) + (TafsirMark * 1) + (KargahMark * 1) + (EnglishMark * 2)
            + (Pishrafte2Mark * 3) + (SheygarayeeMark * 3) + (TarbiatbadaniMark * 1) + (OSMark * 3) + (AlgoritmMark * 3)) / 18;
    }
}

