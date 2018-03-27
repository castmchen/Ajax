using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace AjaxDemo
{
    /// <summary>
    /// Summary description for TestWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ScriptService]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TestWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public void GetStr(string name)
        {
            this.Context.Response.Write("<span>qiang.c.chen" + "<br />" + "qiang.c.chen@accenture.com</span>");
            //return  "<span>qiang.c.chen" + "<br />" + "qiang.c.chen@accenture.com</span>";
        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public UserInfo GetInfo(string name)
        {
            return new UserInfo
            {
                Name = "qiang.c.chen",
                Email = "qiang.c.chen@accenture.com"
            };
        }

        [WebMethod]
        public string Post(string name, UserInfo userInfo)
        {
            Console.WriteLine(name.ToString());
            Console.WriteLine("------------");
            Console.WriteLine(userInfo.Name.ToString() + userInfo.Email.ToString());
            return "success";
        }
    }
}
