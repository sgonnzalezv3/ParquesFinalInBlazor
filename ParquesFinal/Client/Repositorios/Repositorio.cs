using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ParquesFinal.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;
        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        public async Task<HttpResponseWraper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWraper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWraper<T>(default, true, responseHTTP);
            }
        }
        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }


        public async Task<HttpResponseWraper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWraper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public List<Parque> obtenerParque()
        {
            throw new NotImplementedException();
        }   
        public List<Car> obtenerCar()
        {
            throw new NotImplementedException();
        }

        public List<Personal> obtenerPersonal()
        {
            return new List<Personal>()
            {
                /* new Personal() { Nombre = "Lio Messi", Img ="https://storage.googleapis.com/diariodemocracia/cache/20/52/048fc4548b2a11e7a2d3021976ae6e73.jpg" },
                 new Personal() { Nombre = "Diegito Maradona", Img="https://storage.googleapis.com/diariodemocracia/cache/20/52/048fc4548b2a11e7a2d3021976ae6e73.jpg" },
                 new Personal() { Nombre = "Zlatan", Img="https://storage.googleapis.com/diariodemocracia/cache/20/52/048fc4548b2a11e7a2d3021976ae6e73.jpg" } */
            };
        }
        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
    }
}
