using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 4");

            double salario;
            salario = 1200.0;

            //O int é um tipo de váriavel que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            

            //O long é uma váriavel de 64 bits
            long idade = 13000000000000000;
            Console.WriteLine(idade);
            

          


            //O short é  um tipo e váriavel que suporta 16 bits
            short quantidadedeProdutos = 150;
            Console.WriteLine(quantidadedeProdutos);
         

            float altura = 1.83f;
            Console.WriteLine(altura);




            Console.ReadLine();
        }
    }
}
