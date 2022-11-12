using System.Text;

namespace PatternMod
{
    class Name
    {
        public string Sort { get; set; }
    }
    class Photo
    {
        public string Sort { get; set; }
    }
    class University
    {
        public string Sort { get; set; }
    }
    class Exp
    {
        public string Sort { get; set; }
    }

    class Applicant
    {
        public Name Name { get; set; }
        public Photo Photo { get; set; }
        public University University { get; set; }
        public Exp Exp { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Name != null)
                sb.Append(Name.Sort + "\n");
            if (Photo != null)
                sb.Append(Photo.Sort + "\n");
            if (University != null)
                sb.Append(University.Sort + " \n");
            if (Exp != null)
                sb.Append(Exp.Sort + " \n");
            return sb.ToString();
        }
    }
}