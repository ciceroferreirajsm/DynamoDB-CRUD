﻿using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;

namespace Compartilhado.Model
{
    public class Produto
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public bool Reservado { get; set; }
    }
}
