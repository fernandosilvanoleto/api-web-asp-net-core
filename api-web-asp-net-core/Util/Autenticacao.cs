using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_web_asp_net_core.Util
{
    public class Autenticacao
    {
        public static string Token = "1sdsd2154212sdggfjhs";
        public static string Falha_Autenticao = "Falha na Autenticação! O token informado é inválido";
        IHttpContextAccessor contextAccessor;

        public Autenticacao(IHttpContextAccessor _contextAccessor)
        {
            contextAccessor = _contextAccessor;
        }

        public void Autenticar()
        {
            try
            {
                string TokenRecebido = contextAccessor.HttpContext.Request.Headers["Token"].ToString();
                if (string.Equals(Token, TokenRecebido) == false)
                {
                    throw new Exception(Falha_Autenticao);
                }
            }
            catch (Exception e)
            {
                throw new Exception(Falha_Autenticao);
            }
        }

    }
}
