using System;
using System.IO;
using System.Net;
using System.Text;

namespace ConsumindoApi
{
    class Program
    {
        static void Main(string[] args)
        {

            //var request = (HttpWebRequest)WebRequest.Create("https://localhost:44374/api/webservice/BuscarCliente/987");
            //var response = (HttpWebResponse)request.GetResponse();
            // var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            //Console.WriteLine("A resposta do método GET é: " + responseString);

            var request = (HttpWebRequest)WebRequest.Create("https://localhost:44374/api/webservice/cadastrarcliente");
            var posData = "'variavel1':'valor'";
            var data = Encoding.ASCII.GetBytes(posData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using(var strem = request.GetRequestStream())
            {
                strem.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse) request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            Console.WriteLine("A resposta do método POST é: " + responseString);

        }
    }
}
