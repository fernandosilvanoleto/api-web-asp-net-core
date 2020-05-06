using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using api_web_asp_net_core.Model;
using api_web_asp_net_core.Util;
using Microsoft.AspNetCore.Mvc;

namespace api_web_asp_net_core.Controllers
{
    [Route("api/webservice")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/webservice
        [HttpGet]
        public List<ClienteModel> Get()
        {
            return new ClienteModel().Listagem();
        }

        [HttpGet]
        [Route("cliente/{id}")]
        public ClienteModel Cliente(int id)
        {
            return new ClienteModel().RetornarCliente(id);
        }

        // GET api/webservice/buscarcliente/5
        [HttpGet("{id}")]
        [Route("buscarcliente/{id}")]
        public ActionResult<string> BuscarCliente(int id)
        {
            DAL objDAL = new DAL();
            string sql = $"SELECT * FROM cliente where id = {id}";
            DataTable dados = objDAL.RetornarDataTable(sql);
            return dados.Rows[0]["Nome"].ToString();
        }

        // POST api/values
        [HttpPost]
        [Route("cadastrarcliente")]
        public ReturnServices CadastrarCliente([FromBody]ClienteModel dados)
        {
            ReturnServices retorno = new ReturnServices();

            try
            {
                dados.RegistrarCliente();
                retorno.Result = true;
                retorno.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                retorno.Result = true;
                retorno.ErrorMessage = "Error ao tentar registrar cliente" + e.Message;
            }
            return retorno;
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
