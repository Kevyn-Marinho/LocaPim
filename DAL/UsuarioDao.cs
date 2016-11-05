using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Model;

namespace Dao
{
    public class UsuarioDao : IDao<Usuario> 
    {
        private EntidadesContext contexto;

        public UsuarioDao ()
	    {
            contexto = new EntidadesContext();
	    }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public Usuario login(Usuario usuario)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Login == usuario.Login && u.Senha == usuario.Senha);
        }

        public void Adicionar(Usuario usuario)
        {
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
        }

        public void SaveChanges()
        {
            contexto.SaveChanges();
        }

        public void Excluir(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
        }

        public IList<Usuario> Listar() { throw new Exception(); }
    }
}
