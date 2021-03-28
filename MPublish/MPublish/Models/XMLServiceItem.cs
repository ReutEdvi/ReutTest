//using WebProj.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Xml;
//using System.Xml.XPath;
//using System.Xml.Schema;
//using System.Xml.XmlConfiguration;
//using System.IO;
//using System.Text;

//namespace WebProj.Controllers
//{
//    public class XMLServiceItem
//    {
//        //Read all the lineup show- first go to this function
//        public List<Item> Check()
//        {
//            //List<Item> tList;
//            List<Item> tList = new List<Item>();
//            //List<Item> items = new List<Item>();
//            XmlDocument doc = new XmlDocument();      
//            var path = @"C:\Users\reute\Desktop\xmlfiles";
//            foreach (var file in System.IO.Directory.GetFiles(path))
//            {
//                doc.Load(file);
//                tList = ReadItemDetails(file);
                

//            }
//            return tList;
//            //return tList;
//        }



//        public List<Item> ReadItemDetails(string file)
//        {
//            string xpath;
//            //List<Item> tList = new List<Item>();
//            //List<Item> tList;
//            List<Item> tList = new List<Item>();
//            /*String xmlFile = HttpContext.Current.Server.MapPath("~/App_Data/Show.xml");*/ // better read the file name from the configuration file
//            XPathDocument doc = new XPathDocument(file);
//            // Create a navigator
//            XPathNavigator nav = doc.CreateNavigator();
//            xpath = "//show";
//            foreach (XPathNavigator node in nav.Select(xpath))
//            {
//                tList.Add(ReadShowNode(node));
//            }
            
//            return tList;
//            //return itemList;
//        }

//        public Item ReadShowNode(XPathNavigator node)
//        {
            
//            XPathNavigator n = node.SelectSingleNode("show.title");
//            string showTitle = n == null ? string.Empty : n.Value; // manage the case the name is empty

//            n = node.SelectSingleNode("show.showId");
//            int showId;
//            if (n != null)
//            {
//                try
//                {
//                    showId = Convert.ToInt32(n.Value);
//                }
//                catch (Exception ex)
//                {
//                    throw new Exception("Error in converting the id :" + n.Value + " , Error message is :" + ex.Message);
//                }
//            }
//            else
//            {
//                showId = Int32.MinValue;
//            }

//            n = node.SelectSingleNode("story.slugNo");
//            int slugNo;
//            if (n != null)
//            {
//                slugNo = Convert.ToInt32(n.Value);
//            }
//            else
//            {
                
//                slugNo = Int32.MinValue;
//            }

//            _ = node.SelectSingleNode("story.name");
//            string storyName = n == null ? string.Empty : n.Value; // manage the case the name is empty
//            _ = node.SelectSingleNode("story.format");
//            string storyFormat = n == null ? string.Empty : n.Value; // manage the case the name is empty
//            _ = node.SelectSingleNode("story.script");
//            string storyScript = n == null ? string.Empty : n.Value; // manage the case the name is empty

//            n = node.SelectSingleNode("story.storyId");
//            int stotyId;
//            if (n != null)
//            {
//                stotyId = Convert.ToInt32(n.Value);
//            }
//            else
//            {

//                stotyId = Int32.MinValue;
//            }


//            return new Item(showTitle, showId, slugNo, storyName, storyFormat, storyScript, stotyId);

//        }



//        //public List<string> ReadRss()
//        //{

//        //    //  Using a live RSS feed.
//        //    //string RSSFileName = "http://rss.cnn.com/rss/edition_meast.rss";
//        //    string RSSFileName = HttpContext.Current.Server.MapPath("~/App_Data/Show.xml");

//        //    // find all the titles in the items
//        //    //String xpath = "//story/story.script";
//        //    String xpath = "//story";

//        //    try
//        //    {
//        //        List<string> list = ReadXMLField(RSSFileName, xpath);
//        //        return list;
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        throw new Exception("faild to read the XML file, The error is " + ex.Message);
//        //    }

//        //}

//        // ***** returns a list of a specific field within a given XML file *******/
//        //public List<string> ReadXMLField (string xmlFile, string xpath)
//        //public List<string> ReadXMLField (string xmlFile, string xpath) {

//        //    List<string> list = new List<string>();

//        //    // This is the class you want to work with when using Xpath
//        //    XPathDocument doc = new XPathDocument(xmlFile);

//        //    // Create a navigator
//        //    XPathNavigator nav = doc.CreateNavigator();

//        //    foreach (XPathNavigator node in nav.Select(xpath))
//        //    {
//        //        Show sh = new Show();
//        //        sh.Script= XmlElement("story.storyId").Value;
//        //        //sh.Script = node.SelectSingleNode("story.script").Value;
//        //        list.Add(node.Value);
//        //        //list.Add(sh);

//        //    }

//        //    return list;
//        //}

//    }
//}



