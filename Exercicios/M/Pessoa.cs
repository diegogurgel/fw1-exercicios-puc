using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicios.M
{
    public abstract class Pessoa
    {
        private String nome;
        private String rua;
        private int numero;
        private int tipo;
        private String referencia;

        public String Referencia
        {
            get { return referencia; }
            set { referencia = value; }
        }
        

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public String Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        

    }
    
}