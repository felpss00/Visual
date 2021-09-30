using System;

namespace TypePonto.Models
{
    public class Marcacao
    {
        public int Id { get; set; }
        public int FuncionarioId { get; set; }
        public Funcionario funcionario { get; set; }

        public DateTime DataMarcacao { get; set; }

        public DateTime HoraEntrada { get; set; }

        public DateTime HoraSaidaAlmoco { get; set; }

        public DateTime HoraVoltaAlmoco { get; set; }

        public DateTime Saida { get; set; }


    }
}