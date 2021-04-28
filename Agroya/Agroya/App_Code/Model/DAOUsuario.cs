using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public EUsuario login(EUsuario user)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.UserName.Equals(user.UserName) && x.Clave.Equals(user.Clave) && x.EstadoId == 1).FirstOrDefault();
        }
    }

    public EUsuario validarCorreo(string correo)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Correo.ToLower().Equals(correo.ToLower())).FirstOrDefault();
        }
    }

    public EUsuario buscarToken(string token)
    {
        using (var db = new Mapeo())
        {
            return db.usuario.Where(x => x.Token.Equals(token)).FirstOrDefault();
        }
    }

    public void actualizarUsuario(EUsuario user)
    {
        using (var db = new Mapeo())
        {
            db.usuario.Attach(user);

            var entry = db.Entry(user);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}