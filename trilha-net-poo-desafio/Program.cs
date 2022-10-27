using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioPOO.Models;


Console.WriteLine("Funções Nokia");
Nokia celular1 = new Nokia(numero: "81994504990", modelo: "Nokia C3", imei: 565421, memoria: 128);
Console.WriteLine(celular1.Numero);
celular1.Ligar();
celular1.InstalarAplicativo("Tinder");

Console.WriteLine("\n");

Console.WriteLine("Funções Iphone");
Nokia celular2 = new Nokia(numero: "81998677755", modelo: "Iphone 12 Pro Max", imei: 986675, memoria: 512);
Console.WriteLine(celular2.Numero);
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Dragon city");