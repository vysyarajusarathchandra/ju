using AutoMapper;
using ju.Dto;
using ju.entity;
using ju.services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ju.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IuserService userService;
        private readonly IMapper _mapper;
        private readonly IConfiguration configuration;
        public UserController(IuserService userService, IMapper mapper, IConfiguration configuration )
        {
            this.userService = userService;
            _mapper = mapper;
            this.configuration = configuration;
           
        }
        [HttpPost, Route("Register")]
        [AllowAnonymous]
        //access the endpoint any user with out login
        public IActionResult AddUser([FromBody] UserDTO usersDTO)
        {
            try
            {
                User user = _mapper.Map<User>(usersDTO);
                userService.AddUser(user);
                return StatusCode(200, user);
            }
            catch (Exception ex)
            {
               
                return StatusCode(500, ex.InnerException.Message);
            }
        }
    }
}
