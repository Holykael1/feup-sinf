﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstREST.Controllers
{
    public class LoginController : ApiController
    {
        public HttpResponseMessage Post(LoginData data)
        {
            string email = data.email;
            string password = data.password;

            if (email != null && password != null)
            {
                //checks if login is correct
                var response = Request.CreateResponse(
                   HttpStatusCode.OK, data);
                string uri = Url.Link("DefaultApi", new { CodCliente = data.email });
                response.Headers.Location = new Uri(uri);
                return response;
            }

            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            
        }
    }
}