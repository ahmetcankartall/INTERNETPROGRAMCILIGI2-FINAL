﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sorucevapblog.API.Models;

namespace sorucevapblog.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult IsAuthenticated(AdminUser adminUser)
        {
            bool status = false;

            if(adminUser.Email=="ahmet@mail.com"&& adminUser.Password=="1234")
            {
                status = true;

            }

            var result = new
            {
                status = status
            };
            return Ok(result);


        }






    }
}