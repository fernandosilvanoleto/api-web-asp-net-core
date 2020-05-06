﻿using api_web_asp_net_core.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace api_web_asp_net_core.Model
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Data_Cadastro { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Data_Nascimento { get; set; }
        public string Tipo { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }

        public void RegistrarCliente()
        {
            DAL objDAL = new DAL();
            string sql = "insert into cliente(nome, data_cadastro, cpf_cnpj, data_nascimento, tipo, telefone, email, cep, logradouro, numero, bairro, complemento, cidade, uf)" +
            $"values('{Nome}','{DateTime.Parse(Data_Cadastro).ToString("yyyy/MM/dd")}', '{Cpf_Cnpj}', '{DateTime.Parse(Data_Nascimento).ToString("yyyy/MM/dd")}'," +
            $"'{Tipo}', '{Telefone}', '{Email}', '{Cep}', '{Logradouro}', '{Numero}', '{Bairro}', '{Complemento}', '{Cidade}', '{Uf}');";
            objDAL.ExecutarComandoSql(sql);
            /* POSTMAN
             * {
                    "nome": "Leide Silva",
                    "data_cadastro": "2018-06-14",
                    "Cpf_Cnpj": "5454854545",
                    "Data_Nascimento": "1965-05-15",
                    "Tipo": "F",
                    "Telefone": "5454545",
                    "Email": "leide@gmail.com",
                    "Cep": "74464522",
                    "Logra":"7212",
                    "Numero":"544",
                    "Bairro":"Teste",
                    "Complemento":"Complemento teste 1",
                    "Cidade": "Miracema do Tocantins",
                    "Uf": "TO"
                    }
             */
        }

        public List<ClienteModel> Listagem()
        {
            List<ClienteModel> lista = new List<ClienteModel>();
            ClienteModel item;

            string sql = "select * from cliente order by nome asc";

            DAL objDAL = new DAL();

            DataTable dados = objDAL.RetornarDataTable(sql);

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                item = new ClienteModel()
                {
                    Id = int.Parse(dados.Rows[i]["id"].ToString()),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    Data_Cadastro = DateTime.Parse(dados.Rows[i]["data_cadastro"].ToString()).ToString("dd/MM/yyyy"),
                    Cpf_Cnpj = dados.Rows[i]["cpf_cnpj"].ToString(),
                    Data_Nascimento = DateTime.Parse(dados.Rows[i]["data_nascimento"].ToString()).ToString("dd/MM/yyyy"),
                    Tipo = dados.Rows[i]["tipo"].ToString(),
                    Telefone = dados.Rows[i]["telefone"].ToString(),
                    Email = dados.Rows[i]["email"].ToString(),
                    Cep = dados.Rows[i]["cep"].ToString(),
                    Logradouro = dados.Rows[i]["logradouro"].ToString(),
                    Numero = dados.Rows[i]["numero"].ToString(),
                    Bairro = dados.Rows[i]["bairro"].ToString(),
                    Complemento = dados.Rows[i]["complemento"].ToString(),
                    Cidade = dados.Rows[i]["cidade"].ToString(),
                    Uf = dados.Rows[i]["uf"].ToString()
                };
                lista.Add(item);
            }
            return lista;

        }

        public ClienteModel RetornarCliente(int id)
        {
            ClienteModel item;

            string sql = $"select * from cliente where id = {id};";

            DAL objDAL = new DAL();

            DataTable dados = objDAL.RetornarDataTable(sql);

            item = new ClienteModel()
            {
                Id = int.Parse(dados.Rows[0]["id"].ToString()),
                Nome = dados.Rows[0]["nome"].ToString(),
                Data_Cadastro = DateTime.Parse(dados.Rows[0]["data_cadastro"].ToString()).ToString("dd/MM/yyyy"),
                Cpf_Cnpj = dados.Rows[0]["cpf_cnpj"].ToString(),
                Data_Nascimento = DateTime.Parse(dados.Rows[0]["data_nascimento"].ToString()).ToString("dd/MM/yyyy"),
                Tipo = dados.Rows[0]["tipo"].ToString(),
                Telefone = dados.Rows[0]["telefone"].ToString(),
                Email = dados.Rows[0]["email"].ToString(),
                Cep = dados.Rows[0]["cep"].ToString(),
                Logradouro = dados.Rows[0]["logradouro"].ToString(),
                Numero = dados.Rows[0]["numero"].ToString(),
                Bairro = dados.Rows[0]["bairro"].ToString(),
                Complemento = dados.Rows[0]["complemento"].ToString(),
                Cidade = dados.Rows[0]["cidade"].ToString(),
                Uf = dados.Rows[0]["uf"].ToString()
            };                
            return item;
        }
    }
}
