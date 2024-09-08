namespace Entidades;

public class Respuesta
{
    public int C�digoEstado { get; set; }
    public dynamic Contenido { get; set; }
   

    public Respuesta() { }
    public Respuesta(int c�digoEstado, dynamic contenido)
    {
        this.C�digoEstado = c�digoEstado;
        this.Contenido = contenido;
    }
}
