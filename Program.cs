namespace GerencimantoHospitais{
public class Paciente{
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
         public string Contato { get; set; }
         // Navegação para Consultas
        public ICollection<Consulta> Consultas { get; set; }
        // Navegação para Internações
        public ICollection<Internacao> Internacoes { get; set; }
}
public class Medico{
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public string Contato { get; set; }
        // Navegação para Consultas
        public ICollection<Consulta> Consultas { get; set; }
        // Navegação para Internações
        public ICollection<Internacao> Internacoes { get; set; }
}
public class Consulta{
        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public string Motivo { get; set; }
        // Navegação para Paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
        // Navegação para Médico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
public class Internacao{
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; } // Permite valores nulos para internações em andamento
        public string Diagnostico { get; set; }

        // Navegação para Paciente
        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }

        // Navegação para Médico
        public int MedicoId { get; set; }
        public Medico Medico { get; set; }
    }
public class Hospital{
        public int Id { get; set; } // Adicione um ID para facilitar a identificação do hospital
        public string Nome { get; set; }
        public string Endereco { get; set; }
        // Navegação para Médicos
        public ICollection<Medico> Medicos { get; set; }
        // Navegação para Pacientes
        public ICollection<Paciente> Pacientes { get; set; }
    }

}