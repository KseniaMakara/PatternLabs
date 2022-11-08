namespace Module
{
    class Program
    {
        // Prototype Pattern
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 42;
            p1.BirthDate = Convert.ToDateTime("1980-01-01");
            p1.Name = "Hisoka Morow";
            p1.IdInfo = new IdInfo(666);
            p1.Education = "University of Pennsylvania, 2000";
            p1.Exp = "Hunter Association, senior";
            p1.Photo = "data:image/jpeg;base64,/9j/4AAQSkZJn9k=";

            Person p2 = p1.ShallowCopy();

            Console.WriteLine("Ideal version of applicant (original)");
            DisplayValues(p1);
            
            Console.WriteLine("Applicant №1 ");
            p1.Age = 20;
            p1.BirthDate = Convert.ToDateTime("2000-01-01");
            p1.Name = "Gon Freeks";
            p1.Education = "Uzhhorod National University, System ananlisys, 2022";
            p1.Exp = "No experience";
            p1.Photo = "data:image/jpeg;base64,/9j/4AAQSkZJn9k=";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\n");
            DisplayValues(p1);

            Console.WriteLine("Applicant №2 ");
            p2.Age = 41;
            p2.BirthDate = Convert.ToDateTime("1981-01-01");
            p1.Exp = "15 years, CD Projekt Red, Bioware";
            p2.Name = "Killua Zoldyck";
            p1.Education = "First Degree: University of Toronto, Information Technologies, 2002; Second Degree: University of Pittsburgh, Economics, 2010";
            p2.IdInfo.IdNumber = 7878;
            DisplayValues(p2);
        }
        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}, Education: {3:p}, Exp:{4:i}, Photo: {5:p} ",
                p.Name, p.Age, p.BirthDate, p.Education, p.Exp, p.Photo);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}
