using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Bom dia! Coloque um número e eu direi algumas informações sobre ele e como obter.");
            while (1 == 1)
            {
                string grandenumero = Console.ReadLine();
                float numero;
                bool enumero = float.TryParse(grandenumero, out numero);
                if (enumero == true)
                {
                    float resultadoraiz = (float)Math.Sqrt(numero);
                    int resultadoraizint = (int)Math.Sqrt(numero);
                    if (resultadoraiz == resultadoraizint)
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.Write(">>>Informações sobre o número: ");
                        Console.Write(grandenumero);
                        Console.WriteLine("\n------------------------------");
                        Console.Write("Raíz quadrada: ");
                        Console.Write(resultadoraizint);
                        Console.Write(" x ");
                        Console.Write(resultadoraizint);
                        Console.Write("\n");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("------------------------------");
                        Console.Write(">>>Informações sobre o número: ");
                        Console.Write(grandenumero);
                        Console.WriteLine("\n------------------------------");
                    }
                    if (numero > 0)
                    {
                        Console.Write("Número positivo\n");
                    }
                    else if (numero < 0)
                    {
                        Console.Write("Número negativo\n");
                    }
                    double numeropar;
                    numeropar = double.Parse(grandenumero);
                    if (numeropar % 2 == 0)
                    {
                        Console.WriteLine("Número par");
                    }
                    else
                    {
                        Console.WriteLine("Número ímpar");
                    }
                    float dezporcento;
                    dezporcento = (numero / 100 * 10);
                    float vinteporcento;
                    vinteporcento = (numero / 100 * 20);
                    float trintaporcento;
                    trintaporcento = (numero / 100 * 30);
                    float quarentaporcento;
                    quarentaporcento = (numero / 100 * 40);
                    float cinquentaporcento;
                    cinquentaporcento = (numero / 100 * 50);
                    float sessentaporcento;
                    sessentaporcento = (numero / 100 * 60);
                    float setentaporcento;
                    setentaporcento = (numero / 100 * 70);
                    float oitentaporcento;
                    oitentaporcento = (numero / 100 * 80);
                    float noventaporcento;
                    noventaporcento = (numero / 100 * 90);
                    float dobro;
                    dobro = (numero + numero);
                    if (numero != 0)
                    {

                        Console.WriteLine("-----------------------------");
                        Console.Write("Porcentagem:\n");
                        Console.Write("10% - ");
                        Console.Write(dezporcento);
                        Console.Write("\n");
                        Console.Write("20% - ");
                        Console.Write(vinteporcento);
                        Console.Write("\n");
                        Console.Write("30% - ");
                        Console.Write(trintaporcento);
                        Console.Write("\n");
                        Console.Write("40% - ");
                        Console.Write(quarentaporcento);
                        Console.Write("\n");
                        Console.Write("50% - ");
                        Console.Write(cinquentaporcento);
                        Console.Write("\n");
                        Console.Write("60% - ");
                        Console.Write(sessentaporcento);
                        Console.Write("\n");
                        Console.Write("70% - ");
                        Console.Write(setentaporcento);
                        Console.Write("\n");
                        Console.Write("80% - ");
                        Console.Write(oitentaporcento);
                        Console.Write("\n");
                        Console.Write("90% - ");
                        Console.Write(noventaporcento);
                        Console.Write("\n");
                        Console.Write("100% - ");
                        Console.Write(numero);
                        Console.Write("\n");
                        Console.Write("Dobro: ");
                        Console.Write(dobro);
                        Console.Write("\n");
                        Console.WriteLine("-----------------------------");
                    }
                    else
                    {
                        Console.Write("Número nulo\n");
                        Console.WriteLine("-----------------------------");
                    }
                    if (numero != 0)
                    {
                        if (numeropar % 2 == 0)
                        {
                            Console.Write("Adição:\n");
                            float metadepar = numero / 2;
                            Console.Write(metadepar);
                            Console.Write(" + ");
                            Console.Write(metadepar);
                            Console.Write(" = ");
                            Console.Write(grandenumero);
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                        else
                        {
                            Console.Write("Adição:\n");
                            float metadeimpar = (numero - 1) / 2;
                            float metadeimpar2 = (numero + 1) / 2;
                            Console.Write(metadeimpar);
                            Console.Write(" + ");
                            Console.Write(metadeimpar2);
                            Console.Write(" = ");
                            Console.Write(numero);
                            Console.Write("\n");
                            Console.Write("\n");
                        }
                    }
                    if (numero != 0)
                    {
                        Console.Write("Divisão:\n");
                        float numerodivisaogrande = (numero * numero);
                        float numerodivisao2 = (numero * 2);
                        Console.Write(numerodivisaogrande);
                        Console.Write(" ÷ ");
                        Console.Write(numero);
                        Console.Write(" = ");
                        Console.Write(numero);
                        Console.Write("\n");
                        Console.Write(numerodivisao2);
                        Console.Write(" ÷ ");
                        Console.Write("2");
                        Console.Write(" = ");
                        Console.Write(numero);
                        Console.Write("\n");
                        Console.Write("\n");
                        Console.Write("Subtração: \n");
                        float numerosubtração = numero + numero;
                        Console.Write(numerosubtração);
                        Console.Write(" - ");
                        Console.Write(numero);
                        Console.Write(" = ");
                        Console.Write(numero);
                        float por150cento = (numero * 3) / 2;
                        float metadenumero = numero / 2;
                        Console.Write("\n");
                        Console.Write(por150cento);
                        Console.Write(" - ");
                        Console.Write(metadenumero);
                        Console.Write(" = ");
                        Console.Write(numero);
                        Console.Write("\n");
                        Console.WriteLine("-----------------------------");
                    }
                    Console.WriteLine("Coloque outro número para recomeçar");
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }
            }
        }
    }
}

// Criado por DanicitiGames :3