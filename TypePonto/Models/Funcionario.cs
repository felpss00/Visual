using System;
using System.Collections.Generic;

namespace TypePonto.Models
{
    public class Funcionario
    {

        public Funcionario() => DataAdm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Pis { get; set; }
        public double ValorHora { get; set; }
        public DateTime DataAdm { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | PIS: {Pis} | Valor Hora: {ValorHora} | Data de Admição: {DataAdm.ToString(@"MM/DD/YYYY")}";

    }
}