using Entities;
using Interfaces;

namespace Execute
{
    public class ExecuteClass : IAction
    {
        public void MostrarCeveza(Cerveza cz)
        {
            File.AppendAllText("Cerveza.txt", $"Id: {cz.Id} Tamaño: {cz.Tamaño} Porcentaje de Alcohol: {cz.Porcentaje_Alcohol}\n");
        }
    }
}
