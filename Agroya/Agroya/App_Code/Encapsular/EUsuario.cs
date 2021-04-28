using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("usuario", Schema = "usuario")]
public class EUsuario
{
    private int id;
    private string nombre;
    private string apellido;
    private string userName;
    private string clave;
    private int rolId;
    private string session;
    private Nullable<DateTime> lastModify;
    private int estadoId;
    private string token;
    private string correo;
    private Nullable<DateTime> vencimientoToken;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("apellido")]
    public string Apellido { get => apellido; set => apellido = value; }
    [Column("user_name")]
    public string UserName { get => userName; set => userName = value; }
    [Column("clave")]
    public string Clave { get => clave; set => clave = value; }
    [Column("rol_id")]
    public int RolId { get => rolId; set => rolId = value; }
    [Column("session")]
    public string Session { get => session; set => session = value; }
    [Column("last_modify")]
    public Nullable<DateTime> LastModify { get => lastModify; set => lastModify = value; }
    [Column("estado_id")]
    public int EstadoId { get => estadoId; set => estadoId = value; }
    [Column("token")]
    public string Token { get => token; set => token = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    [Column("vencimiento_token")]
    public Nullable<DateTime> VencimientoToken { get => vencimientoToken; set => vencimientoToken = value; }

}