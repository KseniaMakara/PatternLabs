using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLab1
{
     class CtreationClass
    {
        public static void TestBuilder()
        {
            IBuilder builder = new Builder();
            BuilderClass product1 = builder
                                .Header("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n  " +
                                "  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width," +
                                " initial-scale=1.0\">\r\n    <title> EVENT 1</title>\r\n</head>")
                                .SetDate()
                                .SetBody(" \n<body>\n  <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n" +
                                "The Chess Olympiad is a biennial chess tournament in which teams " +
                                "representing nations of the world compete. FIDE organises the tournament and selects the host nation. " +
                                "Amidst the COVID-19 pandemic, FIDE held an Online Chess Olympiad in 2020 and 2021, with a rapid time control " +
                                "that affected players' online ratings.\r\n\r\nThe use of the name \"Chess Olympiad\" for FIDE's team championship is" +
                                " of historical origin and implies no connection with the Olympic Games." +
                                "\n </body>\r\n")
                                .AddPhoto("<img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n")
                                .Footer("\n <footer>\r\n  CONTACTS:\r\n" +
                                "\n Hirohiko Araki xxxxxxxxxxxx" +
                                "\n HIROMU ARAKAWA xxxxxxxxxxxx" +
                                "\n RIYOKO IKEDA xxxxxxxxxxxx" +
                                "\n</footer>")
                                .GetEvent();
            Console.WriteLine(product1.ToString());
            BuilderClass product2 = builder
                               .Header("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n  " +
                               "  <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width," +
                               " initial-scale=1.0\">\r\n    <title> EVENT 2</title>\r\n</head>")
                               .SetDate()
                               .SetBody(" It goes without saying that Hunter x Hunter has been busy these days. The story is still on hiatus, but its creator Yoshihiro Togashi is keeping the franchise alive behind the scene. It wasn't that long ago the artist resumed work on the manga, and he's already done some impressive work with his team. And over on Twitter, Togashi surprised fans when he announced he's got even more work left to do!\r\n\r\nThe update comes from Togashi himself as the artist posted a note to fans on Twitter. It was there the creator shared another blank draft page, and he told fans work has begun on another ten chapters.")
                               .GetEvent();
            Console.WriteLine(product2.ToString());
            Director director = new Director(builder);
            Console.WriteLine(director.Construct().ToString());
          
        }
    }
}
