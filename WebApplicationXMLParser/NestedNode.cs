using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationXMLParser
{
    public class Node
    {
        public string NodeText { get; set; }
        public string NodeName { get; set; }
        public List<Node> ChildNodes { get; set; }

        public Node()
        {
            this.ChildNodes = new List<Node>();
        }
    }
}