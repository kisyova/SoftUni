using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_HTML_Dispatcher
{
    class ElementBuilder
    {
        private string tag;
        private string content;
        private bool closeTag;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();

        public ElementBuilder(string tag)
        {
            this.Tag = tag;
        }
        
        public string Tag
        {
            get { return this.tag; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("The tag cannot be null!", "Tag");
                this.tag = value;
            }
        }
       
        public void addAttribute(string keyAtt, string valueAtt)
        {
            this.attributes.Add(keyAtt, valueAtt);
        }
       
        public void addContent(string content)
        {
            this.Content = content;
        }
       
        public string Content {
            get { return this.content; }
            set { this.content = value; }
        }
      
        public void closingTags(bool closeTag)
        {
            this.CloseTag = closeTag;
        }
       
        public bool CloseTag { get; set; }
       
        public static string operator *(ElementBuilder element, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += element.ToString();
            }
            return result;
        }
        
        public override string ToString()
        {
            string attributeString = "";
            foreach (var attribute in this.attributes)
            {
                attributeString = " " + attribute.Key + "=\"" + attribute.Value + "\"";
            }
           
            string result;
            if (closeTag)
            {
                return result = string.Format("<{0}{1}/>", this.Tag, attributeString, this.Content);
            }
            else
            {
                return result = string.Format("<{0}{1}>{2}</{0}>", this.Tag, attributeString, this.Content);
            }
           
            return result.ToString();
        }
    }
}
