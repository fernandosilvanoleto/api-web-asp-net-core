using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace api_web_asp_net_core.Controllers
{
    [Route("api/webservice")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/webservice/buscarcliente/5
        [HttpGet("{id}")]
        [Route("buscarcliente/{id}")]
        public ActionResult<string> BuscarCliente(int id)
        {
            return id.ToString();
        }

        // POST api/values
        [HttpPost]
        [Route("cadastrarcliente")]
        public string CadastrarCliente([FromBody] string value)
        {
            return "oi, fernando";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [Route("putcliente/{id}")]
        public void PutCliente(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
