using All_Social_media_apps_apis.DataBase;
using All_Social_media_apps_apis.DTO;
using All_Social_media_apps_apis.Models;
using AutoMapper;
using AutoMapper.Internal.Mappers;
using Google.Apis.Gmail.v1;
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
        private static readonly string[] Scopes = { GmailService.Scope.GmailSend };
        private readonly string ApplicationName = "Gmail API .NET Quickstart";
        public EmailsController(Applicationdbcontext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpPost("OutlookEmail")]
        public async Task<IActionResult> StoreEmail(EmailDTO emailDTO)
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
        
        [HttpPost("GoogleGmail")]
        public async Task<IActionResult> Gmails(GmailDTO gmail)
        {
            if (gmail == null) return BadRequest("data is required");
            var gmailbody = _mapper.Map<Gmail>(gmail);
            _context.Gmails.Add(gmailbody);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Email stored successfully.", gmailbody });
        }

        [HttpGet("GetAllGmail")]
        public async Task<IActionResult> GetAll()
        {
            var gmail = _context.Gmails.ToList();
            if (gmail == null || !gmail.Any())
            {
                return NotFound("No Gmail data exists.");
            }
            var gmailDTO = _mapper.Map<List<GmailDTO>>(gmail);
            return Ok(gmailDTO);
        }
    }
}
