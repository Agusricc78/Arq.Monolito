// See https://aka.ms/new-console-template for more information



using Entities;
using Interfaces;
using Execute;

var beer = new Cerveza();
{
    beer.Id = 1;
    beer.Tamaño = "Grande";
    beer.Porcentaje_Alcohol = 5.0m;
}

var action = new ExecuteClass();
var ejecutar = new EjecutarServicio(action);

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

