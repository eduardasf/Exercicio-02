// See https://aka.ms/new-console-template for more information

using CalcularArea;
using System.ComponentModel;

class atividade02
{
    static void Main()
    {

        /**Questão 01---------------------------------------------------------------------------------------------
        Circulo circulo = new Circulo();
        Console.Write("Digite o valor do raio:");
        circulo.raio = double.Parse(Console.ReadLine());

        circulo.TotalArea(circulo.raio);
        circulo.PerimetroArea(circulo.raio);**/

        /**Questão 02----------------------------------------------------------------------------------------------

        Retangulo r1 = new Retangulo();
        Console.Write("Digite o valor da largura:");
        r1.largura = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor da altura:");
        r1.altura = int.Parse(Console.ReadLine());

        r1.AreaRetangulo(r1.largura, r1.altura);
        r1.PerimetroRetangulo(r1.largura, r1.altura);**/

        /**Questão 03---------------------------------------------------------------------------------------------

        Aluno a1 = new Aluno();

        Console.Write("Digite o nome do aluno:");
        a1.nome = Console.ReadLine();

        Console.Write("Digite a matrícula do aluno:");
        a1.matricula = int.Parse(Console.ReadLine());

        Console.Write("Digite a primeira nota:");
        a1.nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a segunda nota:");
        a1.nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a terceira nota:");
        a1.nota3 = double.Parse(Console.ReadLine());

        a1.MediaAluno(a1.nota1, a1.nota2, a1.nota3, a1.nome, a1.matricula);**/


        /**Questão 04---------------------------------------------------------------------------------------------

        Fatorial f1 = new Fatorial();
        Console.Write("Digite um número para saber seu fatorial:");
        f1.numero = int.Parse(Console.ReadLine());

        f1.CalcularFatoria(f1.numero);**/

        //Questão 05-----------------------------------------------------------------------------------------------

     
            Sorteio sorteio = new Sorteio();
            int numeroUsuario;

            do
            {
                Console.Write("Digite um número de 0 a 10: ");
                string inputNumero = Console.ReadLine();

                if (int.TryParse(inputNumero, out numeroUsuario) && numeroUsuario >= 0 && numeroUsuario <= 10)
                {
                    sorteio.RealizarSorteio(numeroUsuario);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Certifique-se de digitar um número válido entre 0 e 10.");
                }

            } while (numeroUsuario != sorteio.NumeroSorteado);
        }

}
