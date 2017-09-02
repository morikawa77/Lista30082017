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
            //Exercicio04();
            Exercicio05();
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

            int i, j, qtd, total;

            for (i = 0; i < 50; i++)
            {
                Console.WriteLine("Informe o valor nº:{0} do Array VET: ", (i + 1));
                VET[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            total = 0;

            for (i = 0; i < 49; i++)
			{
                qtd = 0;
				for (j = i+1; j < 50; j++)
				{
                    if (VET[i] == VET[j]){
                        if (qtd == 0){
                            Console.Write("{0} encontrado nas posições {1}", VET[i], i);

                        } 

						Console.Write(", {0}", j);
						qtd++;

					}
				}

                total += qtd;
                if (qtd > 0){
                    Console.WriteLine(" do Array VET.");
                }
            }

            if (total == 0){
                Console.WriteLine("Não existem números repetidos no vetor");
            }
        }

        static void Exercicio04() {
            decimal[,] produtos = new decimal[15,2];
            int codCliente, qtditens = 0, codItem, qtd;
            decimal valorUN, total, totalGeral = 0;
            int[,] pedido = new int[200,2]; // limitei para o máximo de 200 pedidos
            bool continuapedido = false;
            string continuar;

            /* 
            for (int i = 0; i < 15; i++){
                Console.WriteLine("Digite o código do produto {0}", (i+1));
                produtos[i, 0] = Convert.ToDecimal(Console.ReadLine());
				Console.WriteLine("Digite o preço do produto {0}", (i + 1));
				produtos[i, 1] = Convert.ToDecimal(Console.ReadLine());
            }
            */

            // Adicionando códigos e preços automaticamente: 
            // códigos
            produtos[0, 0] = 1;
            produtos[1, 0] = 2;
            produtos[2, 0] = 3;
            produtos[3, 0] = 4;
            produtos[4, 0] = 5;
            produtos[5, 0] = 6;
            produtos[6, 0] = 7;
            produtos[7, 0] = 8;
            produtos[8, 0] = 9;
            produtos[9, 0] = 10;
            produtos[10, 0] = 11;
            produtos[11, 0] = 12;
            produtos[12, 0] = 13;
            produtos[13, 0] = 14;
            produtos[14, 0] = 15;

            // preços
			produtos[0, 1] = 15;
			produtos[1, 1] = 4;
			produtos[2, 1] = 8.5m;
			produtos[3, 1] = 9.99m;
			produtos[4, 1] = 2.5m;
			produtos[5, 1] = 7.89m;
			produtos[6, 1] = 13.2m;
			produtos[7, 1] = 5;
			produtos[8, 1] = 9.45m;
			produtos[9, 1] = 18.9m;
			produtos[10, 1] = 90;
			produtos[11, 1] = 45.7m;
			produtos[12, 1] = 19.95m;
			produtos[13, 1] = 23.4m;
			produtos[14, 1] = 19.9m;

                

            Console.WriteLine("Digite o código do cliente");
            codCliente = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Digite o código do produto");
			pedido[0, 0] = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Digite a quantidade");
			pedido[0, 1] = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Deseja continuar o pedido? Digite S para sim ou N para não");

            continuar = Console.ReadLine();
            continuar = continuar.ToUpper();

			if (continuar == "S")
			{
				continuapedido = true;
			}
			else if (continuar == "N")
			{
				continuapedido = false;
			}

            int j = 1;

            while (continuapedido == true && j < 200){
				Console.WriteLine("Digite o código do produto");
				pedido[j, 0] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Digite a quantidade");
				pedido[j, 1] = Convert.ToInt32(Console.ReadLine());
                j++;

				Console.WriteLine("Deseja continuar o pedido? Digite S para sim ou N para não");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();

				if (continuar == "S")
				{
					continuapedido = true;
				}
				else if (continuar == "N")
				{
					continuapedido = false;
				}
            }

            for (int k = 0; k < 200; k++){
                qtditens += pedido[k, 1];
            }

            Console.WriteLine("Quantidade total de itens pedidos: {0}", qtditens);


			for (int x = 0; x < 200; x++)
			{
                codItem = pedido[x, 0];
                qtd = pedido[x, 1];

                for (int y = 0; y < 15; y++){
                    if (codItem == produtos[y, 0]){
						valorUN = produtos[y, 1];
						total = qtd * valorUN;
						totalGeral += total;
						Console.WriteLine("Código do produto: {0} | Valor unitário: R$ {1:###,##0.00} | Valor total: R$ {2:###,##0.00}", codItem, valorUN, total);
                    }

                }

				
			}

            Console.WriteLine("Total do Pedido: R$ {0:###,##0.00}", totalGeral);



        }


        static void Exercicio05()
        {
            int[] v = new int[] { 5, 1, 4, 2, 7, 8, 3, 6 };

			/*
			for (int i = 8; i >= 5; i++)  
             {
                 var aux = v[i]; // v[8] vai pra fora do Array, buga
                 v[i] = v[7 - i + 1];
                 v[7 - i + 1] = aux;
             } 
             */

            // Se for pra inverter:

			for (int i = 7; i > 3; i--)
			{
				var aux = v[i];
				v[i] = v[6 - i + 1];
				v[6 - i + 1] = aux;
			} 

			Console.Write("Conteúdo do Array v[");

            for (int i = 0; i < 8; i++)
            {
                Console.Write("{0}, ", v[i]);
            }

            Console.WriteLine("\b\b]");
        }

        static void Exercicio06(){
            int[] Q = new int[20];
            int maior = 0, menor = 0, pmenor = 0, pmaior = 0;

            Console.WriteLine("Insira 20 números positivos: ");

            do
            {
                Console.WriteLine("Informe o valor nº:1 do Array Q: ");
                Q[0] = Convert.ToInt32(Console.ReadLine());
            } while (Q[0] < 0);


				

            maior = menor = Q[0];

			for (int i = 1; i < 20; i++)
			{
                do {
					Console.WriteLine("Informe o valor nº:{0} do Array Q: ", (i + 1));

                    Q[i] = Convert.ToInt32(Console.ReadLine());
                } while (Q[i] < 0);



                if (Q[i] < menor){
                    menor = Q[i];
                    pmenor = i;
                }

				if (Q[i] > maior)
				{
                    maior = Q[i];
					pmaior = i;
				}

			}

            Console.WriteLine("O maior número na Array Q é: {0}", maior);
            Console.WriteLine("A posição do maior número na Array Q é: {0}", pmaior);
            Console.WriteLine("O menor número na Array Q é: {0}", menor);
            Console.WriteLine("A posição do menor número na Array Q é: {0}", pmenor);
        }


        static void Exercicio07() {
            int[] numeros = new int[20];
            int[] numerosRev = new int[20];

            Console.WriteLine("Digite 20 números: ");

            for (int i = 0; i < 20; i++){
                Console.WriteLine("Digite o {0}º número: ", (i+1));
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // numerosRev = Array.Reverse(numeros); NAO ACEITA FAZER ISSO
            //Array.Reverse(numeros);

            numerosRev = numeros;
            Array.Reverse(numerosRev);

            Console.Write("Array reversa da digitada: [");
            for (int j = 0; j < 20; j++){
                // Console.Write("{0}, ", numeros[j]);
                Console.Write("{0}, ", numerosRev[j]);
            }
			Console.Write("\b\b]");

        }


        static void Exercicio08() {
            int[] numeros = new int[30];
            int numero, qtd = 0;

			Console.WriteLine("Digite 30 números: ");

			for (int i = 0; i < 30; i++)
			{
				Console.WriteLine("Digite o {0}º número: ", (i + 1));
				numeros[i] = Convert.ToInt32(Console.ReadLine());
			}

            Console.WriteLine("Digite 1 número para encontrá-lo na Array: ");
            numero = Convert.ToInt32(Console.ReadLine());

			for (int j = 0; j < 30; j++)
			{
                if (numero == numeros[j]){
                    qtd++; 
                }
				
			}

            Console.WriteLine("O número {0} foi encontrado na Array {1} vezes.", numero, qtd);
        }

        static void Exercicio09()
        {
            int[] mediasDiarias = new int[10]; //testar com 10 dias
            // int[] numeros = new int[365]; // variavel real para todos os dias do ano
            int menor, maior, mediaAnual = 0, qtd = 0;

            Console.WriteLine("Digite a temperatura média do dia: ");
            mediasDiarias[0] = Convert.ToInt32(Console.ReadLine());
            menor = maior = mediasDiarias[0];


            for (int i = 1; i < 10; i++) // trocar para i < 365 em exemplo real
            {
                Console.WriteLine("Digite a temperatura média do dia: ");
                mediasDiarias[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int j = 0; j < 10; j++)
            {
                if (mediasDiarias[j] < menor)
                    menor = mediasDiarias[j];

                if (mediasDiarias[j] > maior)
                    maior = mediasDiarias[j];

                mediaAnual += mediasDiarias[j];

            }

            mediaAnual = mediaAnual / 10;

            for (int k = 0; k < 10; k++)
            {
                if (mediasDiarias[k] < mediaAnual)
                    qtd++;
            }

            Console.WriteLine("Menor temperatura do ano: {0}", menor);
            Console.WriteLine("Maior temperatura do ano: {0}", maior);
            Console.WriteLine("Temperatura média do ano: {0}", mediaAnual);
            Console.WriteLine("Número de dias no ano em que a temperatura foi inferior à média anual: {0}", qtd);
        }

        static void Exercicio10(){
            decimal[] notas = new decimal[20];
            decimal media = 0;
            int qtd = 0;

			for (int i = 0; i < 20; i++) 
			{
				Console.WriteLine("Digite a a nota média do aluno: ");
                notas[i] = Convert.ToDecimal(Console.ReadLine());
			}

			for (int j = 0; j < 20; j++) 
			{
                media += notas[j];
			}

            media = media / 20;

			for (int k = 0; k < 20; k++)
			{
                if (notas[k] > media)
                    qtd++;

			}

            Console.WriteLine("A média da turma é: {0}", media);
            Console.WriteLine("Quantidade de alunos com notas acima da média da turma: {0}", qtd);


		}

    }
}