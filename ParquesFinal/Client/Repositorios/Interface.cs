using ParquesFinal.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParquesFinal.Client.Repositorios
{
    public interface IRepositorio
    {
        Task<HttpResponseWraper<T>> Get<T>(string url);

        // List<Parque> obtenerParque();
        List<Personal> obtenerPersonal();
        Task<HttpResponseWraper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
    }
}
