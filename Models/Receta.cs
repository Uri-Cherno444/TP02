public class Receta
{
    public string nombreCocinero{ get;set; }
    public datetime fechaNacimiento{ get;set; }
    public string tipoComida { get;set; }
    public float presupuesto{ get;set; }
    public int cantPersonas{ get;set; }
}


public datetime calcularEdad()
{
    int añoEdad;
    int mesEdad;
    int diaEdad;
    DateTime hoy = DateTime.Today;

    añoEdad = hoy.Year - fechaNacimiento.Year
    if(fechaNacimiento.Mes > hoy.Mes)
    {
        añoEdad - 1 = añoEdad;
    }
    if(fechaNacimiento.Mes == hoy.Mes&&hoy.Today<fechaNacimiento.Today)
    {
        añoEdad -1 = añoEdad;

    }
    
    

}