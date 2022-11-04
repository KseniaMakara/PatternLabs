class Program
{
    static void Main(string[] args)
    {
        Client cl1 = new OutClient(new Example());
        cl1.Output();
        Console.Read();
    }
}

interface IClient
{
    void Que1();
    void Que2();
    void Que3();
    void WebGenerate();
}

class Example : IClient
{
    public void Que1()
    {
        Console.WriteLine("What is your profession?");
        string profession = Console.ReadLine();
    }

    public void Que2()
    {
        Console.WriteLine("How old are you");
        int age = Convert.ToInt32(Console.ReadLine());
    }
    public void Que3()
    {
        Console.WriteLine("Choose 1 if you are a freelancer, choose 2 if you are an office worker, choose 3 if you are unemployed");
        int choose = Convert.ToInt32(Console.ReadLine());
        if (choose == 1)
        {
            Console.WriteLine("Freelancer");
        }
        else if (choose == 2)
        {
            Console.WriteLine("Office worker");
        }
        else if (choose == 3)
        {
            Console.WriteLine("Unemployed");
        }
        else
        {
            Console.WriteLine("Choose 1,2 or 3");
        }
    }

    public void WebGenerate()
    {
        Console.WriteLine("Generate Web page:");
        StreamWriter streamwriter = new StreamWriter(@"E:\index.html");
        streamwriter.WriteLine("<html>");
        streamwriter.WriteLine("<head>");
        streamwriter.WriteLine("  <title>HTML-Document</title>");
        streamwriter.WriteLine("  <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
        streamwriter.WriteLine("</head>");
        streamwriter.WriteLine("<body>");
        streamwriter.WriteLine("What is your profession");
        streamwriter.WriteLine("<input type=\"text\" placeholder=\"answer\">");
        streamwriter.WriteLine("How old are you");
        streamwriter.WriteLine("<input type=\"number\" placeholder=\"answer\">");
        streamwriter.WriteLine("</body>");
        streamwriter.WriteLine("</html>");
        streamwriter.Close();
    }
}

abstract class Client
{
    protected IClient questCreator;
    public IClient QuestCreator
    {
        set { questCreator = value; }
    }
    public Client(IClient lang)
    {
        questCreator = lang;
    }
    public virtual void Output()
    {
        questCreator.Que1();
        questCreator.Que2();
        questCreator.Que3();
        questCreator.WebGenerate();
    }
}

class OutClient : Client
{
    public OutClient(IClient lang) : base(lang)
    {
    }
}
