using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTML_Dispatcher
{
    public static class HTML_Dispatcher
    {
        public static string CreateImage(string src, string alt, string title) {
            ElementBuilder image = new ElementBuilder("img");
            image.addAttribute("src", src);
            image.addAttribute("alt", alt);
            image.addAttribute("title", title);
            image.closingTags(true);
            return image.ToString();
        }

        public static string CreateURL(string url, string title, string text)
        {
            ElementBuilder a = new ElementBuilder("a");
            a.addAttribute("href", url);
            a.addAttribute("title", title);
            a.addAttribute("", text);
            return a.ToString();
        }

        public static string CreateInput(string type, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.addAttribute("type", type);
            input.addAttribute("name", name);
            input.addAttribute("value", value);
            return input.ToString();
        }
    }
}
