using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplicationXMLParser
{
    public partial class XMLREader : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
         

        }


        protected void TreeView1_TreeNodeDataBound(object sender, TreeNodeEventArgs e)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();
            Dictionary<string, string> textFields = new Dictionary<string, string>();
            TreeNode treenode = (TreeNode)e.Node;
            XmlNode xmlnode = (XmlNode)e.Node.DataItem;
            if (xmlnode.NodeType == XmlNodeType.Element)
            {
                
                if (xmlnode.Attributes != null)
                {
                    for (int i = 0; i < xmlnode.Attributes.Count; i++)
                    {
                        TreeNode childnode = new TreeNode(
                            xmlnode.Attributes[i].Name,
                            xmlnode.Attributes[i].Name);
                        TreeNode childnodevalue = new TreeNode(
                            xmlnode.Attributes[i].Value,
                            xmlnode.Attributes[i].Value);
                        childnode.ChildNodes.Add(childnodevalue);
                        treenode.ChildNodes.Add(childnode);
                    }
                }

                if (xmlnode.ChildNodes[0].NodeType == XmlNodeType.Text)
                {
                    TreeNode childnode = new TreeNode(
                        "Text",
                        "Text");
                    TreeNode childnodevalue = new TreeNode(
                        xmlnode.InnerText,
                        xmlnode.InnerText);
                    childnode.ChildNodes.Add(childnodevalue);
                    treenode.ChildNodes.Add(childnode);
                }
            }
        }


    }
}