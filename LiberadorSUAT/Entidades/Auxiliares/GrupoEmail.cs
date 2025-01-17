﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiberadorSUAT.Models.Auxiliares
{
    public class GrupoEmail
    {
        [BsonElement("nome")]
        public string Nome { get; set; }

        [BsonElement("destinatarios")]
        public EnderecoEmail[] destinatarios { get; set; }

        public GrupoEmail(string nome, EnderecoEmail[] destinatarios)
        {
            Nome = nome;
            this.destinatarios = destinatarios;
        }
    }

    public class EnderecoEmail
    {
        [BsonElement("enderecoEmail")]
        public string enderecoEmail { get; set; }

        public EnderecoEmail(string enderecoEmail)
        {
            this.enderecoEmail = enderecoEmail;
        }
    }
}
