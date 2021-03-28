using WebProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;
using System.Xml.XmlConfiguration;
using System.IO;
using System.Text;


namespace WebProj.Controllers
{
    public class ItemController : ApiController
    {
        //the original

        public List<Item> Get()
        {
            Item ite = new Item();
            return ite.ReadItem();
        }
        // GET api/<controller>
        //GET all the lineup show in the first time
        //public IEnumerable<Item> Get()
        //{
        //    Item ite = new Item();
        //    List<Item> tList = ite.ReadItem();
        //    return tList;
        //}

        //public IEnumerable<string> Get()
        //{
        //    Item ite = new Item();
        //    List <string> slist= ite.ReadItemShow();
        //    return slist;

        //}

    }
}