using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderLab1
{
     class BuilderClass
    {
        private List<object> parts = new List<object>();
        public string Body = "Array of Events";
        public string  Header = "";
        public string Foot = "";
        public void Add(string part)
        {
            this.parts.Add(part);
        }

        public override string ToString()
        {
            string str = string.Empty;
            foreach (string part in this.parts)
            {
                str += $"\t{part}\n ";
            }
            return $"{this.Header}{this.Body}{this.Foot}:\n {str}";
        }
    }

    interface IBuilder
    {
        IBuilder AddPhoto(object part);
        IBuilder SetDate();
        IBuilder SetBody(string body);
        IBuilder Header(string head);
        IBuilder Footer(string head);


        BuilderClass GetEvent();
        void Reset();
    }

    class Builder : IBuilder
    {
        protected BuilderClass product = new BuilderClass();

        public void Reset()
        {
            this.product = new BuilderClass();
        }
        public virtual IBuilder SetDate()
        {
            this.product.Add($"Date: {DateTime.Now.ToString()}");
            return this;
        }
        public IBuilder Header(string head)
        {
            this.product.Header = head;
            return this;
        }
        public IBuilder SetBody(string body)
        {
            this.product.Body = body;
            return this;
        }
        public IBuilder Footer(string footer)
        {
            this.product.Foot = footer;
            return this;
        }
        public IBuilder AddPhoto(object part)
        {
            this.product.Add(part as string);
            return this;
        }



        public BuilderClass GetEvent()
        {
            BuilderClass result = this.product;
            this.Reset();
            return result;
        }
    }

   
    class Director
    {
        public IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public BuilderClass Empty()
        {
            this.builder.Reset();
            return this.builder.GetEvent();
        }

        public BuilderClass BuildFromParts(string[] parts)
        {
            this.builder.Reset();
            foreach (string part in parts)
            {
                this.builder.AddPhoto(part);
            }
            return this.builder.GetEvent();
        }

        public BuilderClass Construct()
        {
            this.builder.Reset();
            return this.builder
                    .SetBody("Example")
                    .AddPhoto(" <!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n</head>")
                    .AddPhoto(" <body>\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n    <img src=\"https://d.newsweek.com/en/full/2045206/hunter-x-hunter.png\" alt=\"\">\r\n</body>")
                    .SetDate()
                    .GetEvent();
        }
    }
}

