using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeprodottoconsole
{
    class Prodotto
    {
        private string nome;
        private double prezzo;

        public Prodotto()
        {
            nome = "prodotto sconosciuto";
            prezzo= 0.0;
        }
        public Prodotto(string nome, double prezzo)
        {
            this.nome = nome;   
            this.prezzo = prezzo;   
        }
        public string gNome() 
        {
                return nome;    
        }

        public double gPrezzo() 
        {
            return prezzo;  
        }



    }
}
