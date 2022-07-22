﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RailwaySystem.API.Model;
using RailwaySystem.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RailwaySystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserServices _userServices;
        public UserController(UserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpPost("SaveUser")]
        public IActionResult SaveUser(User user)
        {
            return Ok(_userServices.SaveUser(user));
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            return Ok(_userServices.UpdateUser(user));
        }
        [HttpGet("GetUser")]
        public IActionResult GetUser(int UserId)
        {
            return Ok(_userServices.GetUser(UserId));
        }
        [HttpGet("GetAllUser()")]
        public List<User> GetAllUser()
        {
            return _userServices.GetAllUser();
        }
    }
}
