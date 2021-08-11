using APICatalogoJogos.InputModel;
using APICatalogoJogos.Repositories;
using APICatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogoJogos.Services
{
    public class JogoService : IJogoService
    {
        private readonly IJogoRepository _jogoRepository;

        public JogoService(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }


        public Task<List<JogoViewModel>> Obter(int pagina, int quantidade)
        {
            throw new NotImplementedException();
        }



        public Task Atualizar(Guid id, JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Guid id, double preco)
        {
            throw new NotImplementedException();
        }

        public Task<JogoViewModel> Inserir(JogoInputModel jogo)
        {
            throw new NotImplementedException();
        }

     

        public Task<JogoViewModel> Obter(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
