using PatternMod;
class Program
{
    static void Main(string[] args)
    {
        Maker maker = new Maker();

        AppBuilder builder = new Junior();
        Applicant jun = maker.Make(builder);
        Console.WriteLine(jun.ToString());

        builder = new Senior();
        Applicant sen = maker.Make(builder);
        Console.WriteLine(sen.ToString());

        Console.Read();
    }
}
abstract class AppBuilder
{
    public Applicant Applicant { get; private set; }
    public void CreateApp()
    {
        Applicant = new Applicant();
    }
    public abstract void SetName();
    public abstract void SetPhoto();
    public abstract void SetUniversity();
    public abstract void SetExp();
}
class Maker
{
    public Applicant Make(AppBuilder appBuilder)
    {
        appBuilder.CreateApp();
        appBuilder.SetName();
        appBuilder.SetPhoto();
        appBuilder.SetUniversity();
        appBuilder.SetExp();
        return appBuilder.Applicant;
    }
}
class Junior : AppBuilder
{
    public override void SetName()
    {
        this.Applicant.Name = new Name { Sort = "Killua Zoldyck" };
    }

    public override void SetPhoto()
    {
        this.Applicant.Photo = new Photo { Sort = "Photo 1" };
    }

    public override void SetUniversity()
    {
        this.Applicant.University = new University { Sort = "University of Pittsburgh, System Analisys, 2022" };
    }
    public override void SetExp()
    {
        this.Applicant.Exp = new Exp { Sort = "No previous experience" };
    }

}
class Senior : AppBuilder
{
    public override void SetName()
    {
        this.Applicant.Name = new Name { Sort = "Hisoka Morow" };
    }

    public override void SetPhoto()
    {
    }

    public override void SetUniversity()
    {
        this.Applicant.University = new University { Sort = "University of Pennsylvania, System Analisys, 1999;\nUniversity of Michigan, Informational Technologies, 2009" };
    }
    public override void SetExp()
    {
        this.Applicant.Exp = new Exp { Sort = "15 years of experience in CD Projekt Red, Bioware" };
    }

}