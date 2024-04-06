using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using API.Data;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Authorize]
    public class UsersController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        // private object usersToReturn;

        public UsersController(IUserRepository userRepository, IMapper mapper) 
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        //api/user/3
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
           var users = await _userRepository.GetMembersAsync();
           
           return Ok(users) ;
        }
        
      
         [HttpGet("{username}")]
        public async Task<ActionResult<MemberDto>> GetUser(string username)
        {
           return await _userRepository.GetMemberAsync(username);

        }
         [HttpPut]
         public async Task<ActionResult> UpdateUser(MemberUpdateDto memberUpdateDto)
         {
            var username = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var user = await _unserRepository.GetUserByUsernameAsync(username);

            user.

            _mapper.Map(memberUpdateDto, user);
         }
    }
    
}