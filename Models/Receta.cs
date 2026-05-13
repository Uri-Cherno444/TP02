public class Receta
{
    public string nombreCocinero{ get;set; }
    public datetime fecha{ get;set; }
    public string tipoComida { get;set; }
    public float presupuesto{ get;set; }
    public int cantPersonas{ get;set; }

    



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


public string DeterminarPlato(Receta R)
{
    string plato;
    if(R.presupuesto < 3000 && R.tipoComida = "caliente")
    {   
        plato = "Fideos con Manteca";
    } else if(R.presupuesto >= 3000 && R.presupuesto < 7000 && R.tipoComida="caliente")
    {
        plato ="Arroz con verduras salteadas";
    } else if(R.presupuesto >= 7000 && R.tipoComida = "caliente")
    {
        plato = "Pollo al horno con guarnición"
    }
    else if(R.presupuesto < 3000 && R.tipoComida = "frio")
    {   
        plato = "ensalada simple";
    } else if(R.presupuesto >= 3000 && R.presupuesto < 7000 && R.tipoComida="frio")
    {
        plato ="ensalada completa con proteina";
    } else 
    {
        plato = "tabla de fiambres y quesos"
    }



    return plato;
}
public string calcularTiempo(Receta R)
{
    int minutos;
    if(R.cantPersonas == 1 && R.tipoComida = "caliente")
    {   
        minutos = 20;
    } else if(R.cantPersonas >= 2 && R.cantPersonas <= 3 && R.tipoComida="caliente")
    {
       minutos = 20;
    } else if(R.cantPersonas >= 4 && R.cantPersonas <= 7 && R.tipoComida = "caliente")
    {
        minutos = 40;
    }
    else if(R.cantPersonas>=8 && R.tipoComida = "caliente")
    {   
        minutos=80;
    } else if(R.cantPersonas <=1 && R.tipoComida="frio")
    {
        minutos=10;
    } else if(R.cantPersonas >= 4&&R.cantPersonas<=7 && R.tipoComida = "frio")
    {
        minutos=20;
    }
       else
    {
        minutos=40;
    }
    return minutos;

    public string DeterminarDificultad()
    {
         string dificultad;
    if(R.cantPersonas <=3 && R.presupuesto<3000)
    {   
        dificultad = "principiante";
    } else if(R.cantPersonas >=4&&R.cantPersonas<=7 && R.presupuesto<3000)
    {
       dificultad = "intermedio";
    } else if(R.cantPersonas <=3&& R.presupuesto>=3000&&R.presupuesto<=7000)
    {
        dificultad = "intermedio";
    }
    else if(R.cantPersonas >=4 && R.presupuesto>=3000&&R.presupuesto<=7000)
    {   
        dificultad="intermedio";
    } else if(R.cantPersonas<=7 && R.presupuesto>=7000)
    {
        dificultad="intermedio";
    } else
    {
        dificultad="avanzado";
    }
    return dificultad;

    }
}
}