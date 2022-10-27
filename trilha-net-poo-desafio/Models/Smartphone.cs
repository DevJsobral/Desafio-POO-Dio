using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string numero, string modelo, int imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public string Numero { get; set; }
    
        private string Modelo;
        private int Imei;

        private int Memoria;
 

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}