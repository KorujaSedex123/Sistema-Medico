using System.Collections.Generic;

namespace GerenciamentoHospitais.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public ICollection<Consulta> Consultas { get; set; }
        public ICollection<Internacao> Internacoes { get; set; }
    }
}