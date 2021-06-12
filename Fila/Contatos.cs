using System;

namespace Fila
{
    class Contato
    {
        private string nome;
        private string fone;

        public string Nome { get => nome; set => nome = value; }
        public string Fone { get => fone; set => fone = value; }

        public Contato(string nome, string fone){
            this.Nome=nome;
            this.Fone=fone;
            
        }
    }
}
 