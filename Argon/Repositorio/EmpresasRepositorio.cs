﻿using Argon.Data;
using Argon.Models;

namespace Argon.Repositorio
{
    public class EmpresasRepositorio : IEmpresasRepositorio
    {
        private readonly DBContext _bancoContext;
        public EmpresasRepositorio(DBContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public EmpresasModel ListarPorID(int id)
        {
            return _bancoContext.Empresas.FirstOrDefault(x => x.Id == id);
        }
        public List<EmpresasModel> GetEmpresas()
        {
            // listagem de empresass
            return _bancoContext.Empresas.ToList();
        }
        public EmpresasModel Adicionar(EmpresasModel empresas)
        {
            UsuariosModel usuario = new UsuariosModel();
            // Inserção do banco de dados.
            empresas.dataCadastro = DateTime.Now;
            empresas.nomeCadastro = usuario.Nome;
            _bancoContext.Empresas.Add(empresas);
            _bancoContext.SaveChanges();
            return empresas;
        }

        public EmpresasModel Atualizar(EmpresasModel empresas)
        {
            EmpresasModel empresasDB = ListarPorID(empresas.Id);
            UsuariosModel usuario = new UsuariosModel();
            if (empresasDB == null) throw new System.Exception("Houve um erro na atualização do empresas.");
            empresasDB.Nome = empresas.Nome;
            empresasDB.Cidade = empresas.Cidade;
            empresasDB.CNPJ = empresas.CNPJ;
            empresasDB.NomeFantasia = empresas.NomeFantasia;
            empresasDB.Razao = empresas.Razao;
            empresasDB.Telefone = empresas.Telefone;
            empresasDB.Rua = empresas.Rua;
            empresasDB.Numero = empresas.Numero;
            empresasDB.Bairro = empresas.Bairro;
            empresasDB.Cep = empresas.Cep;
            empresasDB.Email = empresas.Email;
            empresasDB.nomeAlteracao = usuario.Nome;
            empresasDB.dataAlteracao = DateTime.Now;

            _bancoContext.Empresas.Update(empresasDB);
            _bancoContext.SaveChanges();

            return empresasDB;
        }

        public bool Apagar(int id)
        {
            EmpresasModel empresasDB = ListarPorID(id);

            if (empresasDB == null) throw new System.Exception("Houve um erro na deleção do empresas.");

            _bancoContext.Empresas.Remove(empresasDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
