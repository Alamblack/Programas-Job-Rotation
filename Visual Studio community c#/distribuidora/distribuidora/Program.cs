using distribuidora;
using System;
using System.Collections.Generic;

namespace distribuidorafaturamento
{
    internal class Program
    {
        static List<Estados> estados = new List<Estados>();
        static float totalFaturamento;
        static void Main(string[] args)
        {
            // adicionando valores na lista
            estados.Add(new Estados("SP",67836.43f));
            estados.Add(new Estados("RJ", 36678.66f));
            estados.Add(new Estados("MG", 29229.88f));
            estados.Add(new Estados("ES", 27165.48f));
            estados.Add(new Estados("OUTROS", 19849.53f));
            menu();
        }

        static void menu()
        {
            int opcaoSelecionada=0;
            bool opcaoValidada = false;
           
            do
            {
                Console.WriteLine("Faturamentos mensais \r\n" + "     Menu\r\n 1:Adicionar estado 2:Remover Estado\r\n" +
                "3:Selecionar estado 4:Selecionar tudo\r\n5:Sair");
                opcaoSelecionada = int.Parse(Console.ReadLine());

                switch (opcaoSelecionada)
                {
                    case 1:
                        addEstado();
                        break;
                    case 2:
                        remove();
                        break;
                        //verifica se estado digitado existe e caso exista sera mostrado e calcula porcentagem
                    case 3:
                        bool estadoValidado = false;
                        string porcentagem = "";
                        Console.WriteLine("Digite o estado a ser selecionado:");
                        string estado= Console.ReadLine().ToUpper();
                        foreach (Estados estadoObj in estados)
                        {
                            if (estadoObj.siglaGet.Equals(estado))
                            {
                                Console.WriteLine(estadoObj.ToString());
                                porcentagem = ((estadoObj.faturamentoMensalGet / totalFaturamento) * 100).ToString("f");
                                Console.WriteLine(porcentagem);
                                break;

                            }
                            estadoValidado = true;

                        }
                        if (estadoValidado)
                        {
                            Console.WriteLine("Estado Invalido");
                        }
                        break;
                        //Mosra as informações de todos os estados da lista e calcula a porcentagem de cada
                    case 4:
                        foreach(Estados estadoObj in estados)
                        {
                            Console.WriteLine("Faturamento total: " + totalFaturamento);
                            Console.WriteLine(estadoObj.ToString());
                            string porcentagem = ((estadoObj.faturamentoMensalGet/totalFaturamento)*100).ToString("f");
                            Console.WriteLine("A porcentagem do total é: "+porcentagem+"%");
                            Console.WriteLine("------------------------------------------");                      
                        }
                        break;
                        //fecha o programa
                    case 5:
                        opcaoValidada = true;
                        break;
                        // caso o usuario digite uma opção invalida
                    default:
                        Console.WriteLine("Valor invalido tente de novo!");
                        break;
                }
                //atualiza o faturamento total
                totalFaturamento = 0;
                foreach (Estados estadoObj in estados)
                {
                    totalFaturamento += estadoObj.faturamentoMensalGet;
                }

            } while (opcaoValidada==false);
        
        }
        // pega o faturamento do estado e calcula a porcentagem do estado de acordo com a faturamento total
        // adiciona um estado a lista de estados, criando um novo objeto do tipo estado
        static void addEstado()
        {
            string estado = "";
            float faturamentoMensal = 0;
            bool opcaoValidada = false;
            Console.WriteLine("digite a sigla ou nome estado:");
            estado = Console.ReadLine().ToUpper();
            foreach (Estados estadoObj in estados)
            {
                if (estadoObj.siglaGet.Equals(estado))
                {
                    Console.WriteLine("já contem o estado");
                    break;    
                }
                else
                {
                    opcaoValidada = true;   
                }

            }
            if (opcaoValidada)
            {
                try
                {
                    Console.WriteLine("digite o faturamento mensal R$:");
                    faturamentoMensal = float.Parse(Console.ReadLine());
                    estados.Add(new Estados(estado, faturamentoMensal));
                    Console.WriteLine("adicionado com sucesso");
                    opcaoValidada = true;
                }
                catch(System.FormatException e)
                {
                    Console.WriteLine("valor invalido!");
                }
                
            }
            
        }
        //remove os objetos estado da lista estados
        static void remove()
        {
            string estado = "";
            Console.WriteLine("digite a sigla ou nome estado:");
            estado = Console.ReadLine().ToUpper();
            bool estadoValidado = false;
                foreach(Estados estadoObj in estados)
                {
                    if (estadoObj.siglaGet.Equals(estado))
                    {
                        estados.Remove(estadoObj);
                        Console.WriteLine("Excluido com sucesso");
                        break;
                    }
                estadoValidado = true;
            }
            if (estadoValidado)
            {
                Console.WriteLine("não contem ssse estado!!");
            }
        }
    }
    
}
