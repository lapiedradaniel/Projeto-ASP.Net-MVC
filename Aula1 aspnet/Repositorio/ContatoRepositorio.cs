﻿using Aula1_aspnet.Data;
using Aula1_aspnet.Models;

namespace Aula1_aspnet.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList(); 
        }



        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no banco de Dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if (contatoDB == null) throw new System.Exception("Erro");

            contatoDB.Nome = contato.Nome;   
            contatoDB.Email = contato.Email; 
            contatoDB.Celular = contato.Celular; 
            
            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();


            return contatoDB;   
        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if (contatoDB == null) throw new System.Exception("Erro pra apagar ");

            _bancoContext.Contatos.Remove(contatoDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }  
       
}
