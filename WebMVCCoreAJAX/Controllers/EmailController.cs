using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebMVCCoreAJAX.Controllers
{
    [Route("api/[controller]")]
    public class EmailController : Controller
    {
        [HttpGet("EnvioEmail")]
        public String EnvioEmail()
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Luis", "prueba13711@gmail.com"));
            message.To.Add(new MailboxAddress("Luis", "yancel209@gmail.com"));
            message.Subject = "Ejemplo de asunto";


            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<b>This is some html text</b>";
            //bodyBuilder.TextBody = "This is some plain text";

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, false);
                client.Authenticate("prueba13711@gmail.com", "password");
                client.Send(message);
                client.Disconnect(true);
            }

                return "";
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
