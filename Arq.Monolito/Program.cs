// See https://aka.ms/new-console-template for more information



using Entities;
using Interfaces;
using Execute;
using ClienteFilSaver;

var beer = new Cerveza();
{
    beer.Id = 1;
    beer.Tamaño = "Grande";
    beer.Porcentaje_Alcohol = 5.0m;
}

var http = new HttpFileSaver();
var ejecutar = new EjecutarServicio(http);

ejecutar.Guardar(beer);

public class EjecutarServicio 
{
 
    private readonly IAction _action;


    public EjecutarServicio(IAction acc)
    {
        _action = acc;
    }


    public void Guardar(Cerveza cz)
    {
        _action.MostrarCeveza(cz);
    }









}

