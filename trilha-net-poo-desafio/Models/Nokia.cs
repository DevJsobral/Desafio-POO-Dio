using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
    public Nokia(string numero, string modelo, int imei, int memoria) : base(numero, modelo, imei, memoria)
    {
        
    }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o Aplicativo: " + nomeApp);
        }
    }
}