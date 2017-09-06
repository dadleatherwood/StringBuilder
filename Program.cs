using System;
using System.Text;

namespace StringBuilder101
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var builder = new StringBuilder();

            //apend method
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            //Replace
            builder.Replace('-', '+');

            //Remove
            builder.Remove(0, 10);

            //Insert
            builder.Insert(0, new string('-', 10));

            //You can chain methods
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Hello")
                .AppendLine()
                .Append('-', 10);

            Console.WriteLine(builder);
        }
    }
}
