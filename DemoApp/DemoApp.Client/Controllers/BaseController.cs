using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoApp.Client.Controllers
{
    public class BaseController : Controller
    {
        private JsonSerializerSettings _camelCaseFormatter;

        public JsonSerializerSettings Formatter 
        { 
            get
            {
                _camelCaseFormatter = new JsonSerializerSettings();
                _camelCaseFormatter.ContractResolver = new CamelCasePropertyNamesContractResolver();
                return _camelCaseFormatter;
            }
        }
    }
}