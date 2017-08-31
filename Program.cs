using System;

namespace Lista30082017
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            Exercicio03();
            //Exercicio04();
            //Exercicio05();
            //Exercicio06();
            //Exercicio07();
            //Exercicio08();
            //Exercicio09();
            //Exercicio10();
        }

        static void Exercicio01()
        {
            int[] A = new int[10];
            int X;
            int[] M = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o valor nº:{0}: ", (i + 1));
                A[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Digite o valor multiplicador: ");
            X = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < 10; j++)
            {
                M[j] = A[j] * X;
            }

            Console.Write("Array M: [");

            for (int k = 0; k < 10; k++)
            {
                Console.Write("{0}, ", M[k]);
            }

            Console.Write("\b\b]");
        }

        static void Exercicio02()
        {
            int[] V1 = new int[15];
            int[] V2 = new int[15];
            int qtd = 0;

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o valor nº:{0} do Array V1: ", (i + 1));
                V1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Informe o valor nº:{0} do Array V2: ", (i + 1));
                V2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (V1[i] == V2[j])
                        qtd++;
                }

            }

            switch (qtd)
            {
                case 0:
                    Console.WriteLine("Os Arrays V1 e V2 não possuem nenhum número igual");
                    break;
                case 1:
                    Console.WriteLine("Os Arrays V1 e V2 os mesmos números 1 vez");
                    break;
                default:
                    Console.WriteLine("Os Arrays V1 e V2 possuem os mesmos números {0} vezes", qtd);
                    break;
            }

        }


        static void Exercicio03()
        {
            int[] VET = new int[50];
            int ponteiro, nrepetido;

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Informe o valor nº:{0} do Array VET: ", (i + 1));
                VET[i] = Convert.ToInt32(Console.ReadLine());
            }
            ponteiro = VET[0];

            for (int i = 1; i < 50; i++) {
                if (VET[i] == ponteiro){
                    nrepetido = ponteiro;
                    Console.WriteLine("O número {0} foi repetido nas posições: ", nrepetido);
                    Console.WriteLine(i);
                } else {
                    ponteiro = VET[i+1]
                }
            }

        }
    }
}