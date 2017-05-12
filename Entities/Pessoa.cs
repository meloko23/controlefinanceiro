using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppMvcControleFinanceiro.Entities
{
    public class Pessoa : IPessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
		public string Cpf { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        [DisplayName("Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public int GetIdade()
        {
            var idade = DateTime.Now.Year - DataNascimento.Year;
            if (DataNascimento > DateTime.Now.AddYears(-idade)) idade--;
            return idade;
        }

        public bool IsMaiorDeIdade()
        {
            return GetIdade() >= 18;
        }
    }
}