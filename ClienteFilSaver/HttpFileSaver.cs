using Entities;
using Interfaces;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ClienteFilSaver
{
    public class HttpFileSaver : IAction
    {
        private readonly HttpClient cl;

        private string url = "http://localhost:5101";

        public HttpFileSaver()
        {
            cl =  new HttpClient { BaseAddress = new Uri(url)};

        }

        public async Task MostrarCeveza(Cerveza cz)
        {
            var js = JsonSerializer.Serialize(cz);  

            var content = new StringContent(js, Encoding.UTF8, "application/json");

            await cl.PostAsync("/api/FileSaver",content);




        }
    }
}
