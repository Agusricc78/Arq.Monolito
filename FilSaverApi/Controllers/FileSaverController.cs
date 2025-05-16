using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilSaverApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileSaverController : ControllerBase
    {
        private readonly string _filePath = "Cerve.txt";

        [HttpPost]
       
        public async Task<IActionResult> SaveCerveza (Cerveza cz)
        {

            try
            {
                await System.IO.File.AppendAllTextAsync(_filePath, $"Id: {cz.Id} Tamaño: {cz.Tamaño} Porcentaje de Alcohol: {cz.Porcentaje_Alcohol}\n");

                return Ok(new {message = "Accion realizada con exito" });

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
