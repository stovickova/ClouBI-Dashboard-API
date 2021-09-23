using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SupportController : ControllerBase
    {
        [HttpGet]
        public string GetAll()
        {
            return "{"+
	"\"Employee\": ["+
		"{"+
			"\"Employee\": \"David Bradley\","+
		"\"ProductName\": \"ASP.NET Core\","+
		"\"ResolvedTime (Sum)\": 64,"+
		"\"IssueType\": \"Critical\"" +
		"},"+
		"{"+
			"\"Employee\": \"David Bradley\"," +
	"\"ProductName\": \"ASP.NET Core\"," +
	"\"ResolvedTime (Sum)\": 2166," +
	"\"IssueType\": \"Normal\"" +
	"	},"+
	"	{"+
				"\"Employee\": \"Vamsi Kuppa\"," +
		"\"ProductName\": \"Mobile\"," +
		"\"ResolvedTime (Sum)\": 270," +
		"\"IssueType\": \"Urgent\"" +
		"}" +
	"]"+
"}";
        }
    }
}
