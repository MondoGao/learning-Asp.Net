using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebForm
{
    /// <summary>
    /// JsonHandler 的摘要说明
    /// </summary>
    public class JsonHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            string json = "{\"arr\": [1,2,3,4]}";

            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}