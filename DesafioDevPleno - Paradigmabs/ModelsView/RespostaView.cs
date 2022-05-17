using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDevPleno___Paradigmabs.ModelsView
{
    public class RespostaView<T> where T : class
    {
        public RespostaView(bool sucesso, string mensagem, T modelo = null)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            Modelo = modelo;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public T Modelo { get; set; }
    }
}
