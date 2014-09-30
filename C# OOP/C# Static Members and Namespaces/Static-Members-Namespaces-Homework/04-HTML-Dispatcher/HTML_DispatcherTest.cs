using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTML_Dispatcher
{
    class HTML_DispatcherTest
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.addAttribute("id", "page");
            div.addAttribute("class", "big");
            div.addContent("<p>Hello!</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine(HTML_Dispatcher.CreateImage("image.png", "picture", "picture title"));
            Console.WriteLine(HTML_Dispatcher.CreateURL("../../url.url", "url title", "Click here!"));
            Console.WriteLine(HTML_Dispatcher.CreateInput("input", "input_text", "null"));

        }
    }
}
