using All_Social_media_apps_apis.DataBase;
using All_Social_media_apps_apis.DTO;
using All_Social_media_apps_apis.Models;
using AutoMapper;
using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Serialization;

namespace All_Social_media_apps_apis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailsController : ControllerBase
    {
        private readonly Applicationdbcontext _context;
        private readonly IMapper _mapper;
        public EmailsController(Applicationdbcontext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("Store-Email")]
        public async Task<IActionResult> StoreEmail([FromBody] EmailDTO emailDTO)
        {
            if (emailDTO == null) return BadRequest("Email data is required.");
            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var email = _mapper.Map<Emails>(emailDTO);
                _context.Emails.Add(email);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Email stored successfully.", emailDTO });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
