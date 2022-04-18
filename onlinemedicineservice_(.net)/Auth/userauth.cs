using Businesslogic.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace onlinemedicineservice__.net_.Auth
{
    public class userauth : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var authHeader = actionContext.Request.Headers.Authorization;
            if (authHeader == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.NotFound, "No token supplied");

            }
            else
            {
                string token = authHeader.ToString();
                var rs = usersercice.CheckValidityToken(token);
                
                if (rs==null)
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "Unauthorized Access");
                }
                else if(rs!=null)
                {
                    var user = usersercice.profileshow(rs.user_id);

                    if (user.Usertype != "Customer")
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized, "only customer  Access");
                    }

                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}
