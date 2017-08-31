using System;

namespace Lista30082017
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Exercicio01();
            //Exercicio02();
            //Exercicio03();
            Exercicio04();
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
            int nrepetido, y = 0;
            int[] ponteiro = new int[50];

            int i = 0;

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Informe o valor nº:{0} do Array VET: ", (i + 1));
                VET[i] = Convert.ToInt32(Console.ReadLine());
            }
            ponteiro[0] = i;
            nrepetido = VET[0];

			for (int x = 0; x <= 50; x++)
			{
				for (int j = x + 1; j < 50; j++)
				{
					if (VET[j] == VET[x])
					{
                        nrepetido = VET[x];
                        ponteiro[0] = i;
                        if (VET[y] != VET[j]){
                            ponteiro[y] = j;
                            y++;
						}

					}
				}

                Console.Write("O número {0} é repetido nas posições ", nrepetido);
                for (int z = 0; z < ponteiro.Length; z++){
                    Console.Write("{0}, ", ponteiro[z]);
                }
                Console.WriteLine("\b\b");
			} //Loop problematico - NOT OK

        }

        static void Exercicio04()
        {
            int[] v = new int[8];
            v[0] = 5;
            v[1] = 1;
            v[2] = 4;
            v[3] = 2;
            v[4] = 7;
            v[5] = 8;
            v[6] = 3;
            v[7] = 6;


			/* for (int i = 8; i >= 5; i++)
			{
				var aux = v[i];
				v[i] = v[7 - i + 1];
				v[7 - i + 1] = aux;
			} */ //NAO FAZ SENTIDO
            

            Console.Write("Conteúdo do Array v[");

            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0}, ", v[i]);
            }

            Console.WriteLine("\b\b]");
        }
    }
}