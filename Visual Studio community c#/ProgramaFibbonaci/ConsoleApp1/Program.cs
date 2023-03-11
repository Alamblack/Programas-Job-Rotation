using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            escreverNaTela();
            
        }
        //Esse metodo recebe os dados do usuario executa o metodo VerificarSeEFibonacci, caso tenha algum erro
        //ele trata usando try catch e pede para tentar novamente,pergunta depois de terminar a execução se quer continuar usando o programa.
        // sempre que houver uma respota invalida o loop de repetição ativa
        private static void escreverNaTela()
        {
            char sair='s';     
            while(sair == 's' || sair == 'S')
            {
                Console.Clear();
                Console.Write("Verificador de fibonacci \r\n Digite um numero:");
                try
                    {
                        uint numParaTeste = uint.Parse(Console.ReadLine());
                        bool resultVerificaFibonacci = VerificarSeEFibonacci(numParaTeste);

                        if (resultVerificaFibonacci)
                        {
                            Console.WriteLine(numParaTeste + " é fibonacci");
                        }
                        else
                        {
                            Console.WriteLine(numParaTeste+" não é fibonacci");
                        }

                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("NUMERO INVALIDO!");
                    }
                    catch(System.OverflowException ex)
                    {
                        Console.WriteLine("numeuro não suportado! tente novamente com um valor menor");
                    }
                    do
                    {
                        Console.WriteLine("Continuar...? s / n");
                        try
                        {
                            sair = char.Parse(Console.ReadLine());
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("VALOR INVALIDO! tente novamente");
                        }

                    }
                    while ((sair != 's' && sair != 'n') && (sair != 'S' && sair != 'N'));
                
            }

        }


        //VerificarSeEFibonacci recebe um parametro e verifica esse parametro é um numero fibonacci, é limitado a 999999999
        //e retorna true ou false.
        private static bool VerificarSeEFibonacci(uint _numParaTeste)
        {
            uint numParaTeste = _numParaTeste, numFibonacc1=2,numFibonacci2=3,somaDosFib = 0;
            if(numParaTeste > 3)
            {
                while (numParaTeste != somaDosFib)
                {
                    somaDosFib = numFibonacc1 + numFibonacci2;
                    numFibonacc1 = numFibonacci2;
                    numFibonacci2 = somaDosFib;
                    if(numParaTeste <somaDosFib )
                    {
                        return false;
                    }
                }
            }
            
            return true;

        }
    }
}
