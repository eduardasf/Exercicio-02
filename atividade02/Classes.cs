using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calcular
{

    //***Calcular a área do círculo-----------------------------------------------------------------------
    internal class Circulo
    {
        public double raio;

        public void TotalArea(double raio)
        {
            double resultado = 0;

            resultado = Math.PI * Math.Pow(raio, 2);
            Console.WriteLine($"\nA área do circulo é: {resultado:F2}");

        }

        public void PerimetroArea(double raio)
        {
            double resultado = 0;

            resultado = 2 * Math.PI * raio;
            Console.WriteLine($"\nO perimetro do circulo é: {resultado:F2}");
        }
    }


    //***Calcular a área do retângulo------------------------------------------------------------------
    internal class Retangulo
    {
        public int largura;
        public int altura;


        public void AreaRetangulo(int largura, int altura)
        {
            int resultado = 0;

            resultado = largura * altura;
            Console.Write("\nA área do retângulo é:" + resultado);

        }

        public void PerimetroRetangulo(int largura, int altura)
        {
            int resultado = 0;

            resultado = 2*(largura + altura);
            Console.Write("\nO perímetro do retângulo é:" + resultado);

        }
    }

    //***Calcular a média do aluno------------------------------------------------------------------
    internal class Aluno
    {

        public string nome;
        public int matricula;
        public double nota1;
        public double nota2;
        public double nota3;

        public void MediaAluno(double nota1, double nota2, double nota3, string nome, int matricula)
        {
            double media;

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("\n**INFORMAÇÕES DO ALUNO:**");

            if(media < 6)
            {
                Console.WriteLine("Aluno: " + nome + "\nMatrícula:" + matricula + $"\nMédia:{media:F1}\nEstá: Reprovado");
            }else
            {
                Console.WriteLine("Aluno: " + nome + "\nMatrícula:" + matricula + $"\nMédia:{media:F1}\nEstá: Aprovado");
            }

        }


    }

    //***Calcular o fatorial do número------------------------------------------------------------------

    internal class Fatorial
    {
        public int numero;

        public void CalcularFatoria(int numero)
        {
            int resultado = 1;

            for (int i = 1; i <= numero; i++)
            {
                resultado *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é {resultado}");
        }
    }

    //***Sorteio------------------------------------------------------------------
    class Sorteio
    {
        private int numeroSorteado;
        private int tentativas;

        public Sorteio()
        {
  
            Random random = new Random();
            numeroSorteado = random.Next(11);

            tentativas = 0;
        }

        public int NumeroSorteado
        {
            get { return numeroSorteado; }
        }

        public void RealizarSorteio(int numeroUsuario)
        {
            tentativas++;

            if (numeroUsuario == numeroSorteado)
            {
                Console.WriteLine($"Parabéns! Você acertou o número {numeroSorteado} em {tentativas} tentativa(s).");
            }
            else
            {
                Console.WriteLine($"Você errou. Tente novamente.");
            }
        }
    }
}
