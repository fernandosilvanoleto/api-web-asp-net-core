using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AppCliente.Util
{
    public class WebApi
    {
        public static string URL = "https://localhost:44374/api/webservice/";
        public static string RequestGET(string metodo, string parametro)
        {
            var request = (HttpWebRequest)WebRequest.Create(URL + metodo + "/" + parametro);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }
        public static string RequestPost(string metodo, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(URL + metodo);
            //var jsonData = "'variavel1':'valor'";
            var data = Encoding.ASCII.GetBytes(jsonData);
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var strem = request.GetRequestStream())
            {
                strem.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }

        public static string RequestPut(string metodo, string jsonData)
        {
            var request = (HttpWebRequest)WebRequest.Create(URL + metodo);
            //var jsonData = "'variavel1':'valor'";
            var data = Encoding.ASCII.GetBytes(jsonData);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var strem = request.GetRequestStream())
            {
                strem.Write(data, 0, data.Length);
            }
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;

        }
    }
}
