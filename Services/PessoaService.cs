using System.Collections.Generic;
using AppMvcControleFinanceiro.Entities;
using AppMvcControleFinanceiro.Repositories;
                        
namespace AppMvcControleFinanceiro.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        readonly IPessoaRepository _pessoaRepository;
        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            _pessoaRepository = repository;
        }
    }
}
