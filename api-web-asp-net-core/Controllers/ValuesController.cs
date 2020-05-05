using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using api_web_asp_net_core.Util;
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
            DAL objDAL = new DAL();
            //string sql = "insert into cliente(nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, complemento, cidade, uf)" +
                        // "values('Fernando Silva Noleto', '2019/01/25', '05564652156', '1995/06/09', 'M', '949656232', 'fernandonoleto17@gmail.com', '77650000', 'Rua', '987', 'flamboyant', 'perto daqui', 'Miracema', 'TO');";
            //objDAL.ExecutarComandoSql(sql);

            return new string[] { "value1", "value2" };
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
