using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Web;
using System.Web.Mvc;

namespace flexGridTest
{
        public class DataContractJsonSerializedResult : System.Web.Mvc.ActionResult
        {
            private object data;

            public DataContractJsonSerializedResult(object data)
            {
                this.data = data;
            }

            public override void ExecuteResult(ControllerContext context)
            {
                var response = context.HttpContext.Response;
                response.ContentType = "text/json";
                var serializer = new DataContractJsonSerializer(data.GetType());
                serializer.WriteObject(response.OutputStream, data);
            }
        }
}