using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_Sem_Orientacao_Objeto {
    internal class Program {
        static void Main(string[] args) {
            double xA,xB,xC,yA,yB,yC;// 3 LADOS DO TRIANGULO CRIADO-LADO REPRESENTADO PELO (X), E AS VARIAVEIS

            //abaixo um exemplo de programação sem orientação objeto(metodo complexo)
            Console.WriteLine("Entre com as medidas do triangulo X");
            //abaixo ira fazer a leitura dos 3 lados do triangulo (X)
            xA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //VEJA COMO E TRABALHOSO
            Console.WriteLine("Entre com as medidas do tringulo Y");//Entrara com as medidas do triangulo (Y)
            yA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            yB = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            //calculo da area do triangulo (X)
            double areaX = Math.Sqrt(p * (p - xA) * ( p - xB) * (p - xC) );

            //calculando area do (Y)/
            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p -yA)*(p-yB)*(p-yC)); //calculando area do triangulo Y
            Console.WriteLine("ÁREA DE X = " + areaX.ToString("f4",CultureInfo.InvariantCulture));
            Console.WriteLine("ÁREA DE Y = "+areaY.ToString("F4", CultureInfo.InvariantCulture));

            //ABAIXO IRA MOSTRAR QUAL AREA DO TRIANGULO É MAIOR.
            //ESTRUTURA SIMPLES. (IF E ELSE)
                if(areaX > areaY) {

                Console.WriteLine("A maior ÁREA E X " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            }
            else { Console.WriteLine("A maior ÁREA E Y: " + areaY.ToString("F4",CultureInfo.InvariantCulture)); }
            
            Console.ReadKey();

        }
    }
}
