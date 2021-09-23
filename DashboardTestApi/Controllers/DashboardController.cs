using DashboardTestApi.Data;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace DashboardTestApi.Controllers
{
 //   [ApiController]
 //   [Route("[controller]")]
    public class DashboardController 
    {
     //   ReadOnlyRepositoryBase repository = new ReadOnlyRepositoryBase();

   /*     [HttpGet("dashboards")]
        public string GetSupport()
        {
            var output = repository.GetOutputXmls(4325, 1, null).FirstOrDefault();

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(output.XmlData.Replace("@", ""));

            return JsonConvert.SerializeXmlNode(doc.FirstChild.NextSibling);
        }*/
    }
}
