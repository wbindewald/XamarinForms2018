﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_CoonsultarCEP.Servico.Modelo;
using Newtonsoft.Json;


namespace App01_CoonsultarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "https://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            return end;            
        }

    }
}
