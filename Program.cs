using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
// Referência para o namespace chamado System. Que é o namespace padrão do .NET

namespace PrimeiroProjeto {
    internal class Program {
        static void Main(string[] args) {
            /*
            SByte x = 100;
            sbyte y = sbyte.MinValue;
            sbyte z = sbyte.MaxValue;
            //sbyte x = 100; Direto do c#, não precisa do using System
            //  Console.WriteLine(x);

            byte n1 = 126;
            //Byte tem como limite o valor de 255. Logo, quando ocasiona um OVERFLOW,
            //O valor da váriavel muda para o limite oposto. Nesse caso, 0.
            //n1++;
            //Método para aumentar o valor de forma simples, de 1 em 1.
            
            int n2 = 1000;
            int n3 = 2147483647;
            int n8 = int.MinValue;
            int n9 = int.MaxValue;
            //Valor inteiro, sem vírgula.
            long n4 = 2147483648L;
            //Valor inteiro, porém mais longo que o INT. Colocar a letra L no final para poder identificar que é uma var LONg.

            bool n5 = true;
            //Verdadeiro ou falso somente

            char genero = 'F';
            char letra = '\u0041';
            //Caractere único, em aspas únicas, sem outros digitos. Pode também ser definido pelo código unicode dele. Encontrado na unicode table.

            float n6 = 4.5f;
            //Valor com vírgula, abaixo do double. nEcessário a letra f no final para poder ser identificado como float.

            double n7 = 6.6;
            //Valor com vírgula, maior que o float e sem a necessidade de ser utilizado um caractere para identificar.

            string nome = "Maria";
            //Valor de texto, precisa ser colocado em aspas duplas. Imutável.

            object obj1 = "Alex";
            object obj2 = 4.5f;
            //Variável genérica, podendo ser implementada com qualquer valor. Tendo em vista que deve seguir os padrões das outras variáveis.

            decimal n10 = 1000000000;
            decimal n11 = decimal.MinValue;
            decimal n12 = decimal.MaxValue;
            //Valor muito alto, normalmente não utilizado.

            // VALORES MINIMOS E MAXIMOS
             int.MinValue = valor minimo de int
             int.MaxValue = valor máximo de int
             sbyte.MinValue = valor minimo de sbyte
             sbyte.MaxValue = valor maximo de sbyte
             long.MinValue = valor minimo de long
             long.MaxValue = valor maximo de long
             decimal.MinValue = valor minimo de decimal
             decimal.MaxValue = valor maximo de decimal
             etc...

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);
            Console.WriteLine(n11);
            Console.WriteLine(n12);
			

            // char gender = 'F';
            int idade = 32;
            double saldo = 10.555555;
            string nome = "Maria";
            */
            /*
            Console.Write("Bom dia"); // Print sem pular linha
            Console.WriteLine("Bom dia"); // Print pulando linha
            Console.WriteLine("Boa noite");
            Console.WriteLine("----------------------");
            Console.WriteLine(gender);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            // F2 mostra apenas duas casas decimais, arredondando.
            // F + numero faz com que aparece somente o número de casas específicado.
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));
            // CultureInfo.InvariantCulture é utilizado para dar print com o ponto de separação de decimais.
            // Independente da formatação do Pais.
            // Esta linha foi "importada" do System.Globalization.
            

            // PLACEHOLDER
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);
            // Definido no próprio writeline
            // {2:F2} permite a formatação das casas decimais dentro do WriteLine.

            // INTERPOLAÇÃO
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais.");
            // Também definido no próprio writeline, porém no meio da linha de texto.
            // Também permite a formatação da mesma forma que o placeholder.

            // CONCATENAÇÃO
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            // Forma mais antiga.
            // Definido a quantidade casas decimais do valor de saldo através do ToString, diferente dos anteriores.
            // Só se consegue aplicar o CultureInfo.InvariantCulture se for utilizado o ToString.
            */

            // OPERADORES DE ATRIBUIÇÃO:
            /*
            int a = 10;
            int b = 1;
            Console.WriteLine(a);

            a -= 2; // Soma 2 com o valor a
            Console.WriteLine(a);

            a += 2; // Subtrai 2 com o valor de a
            Console.WriteLine(a);

            a *= 3; // Multiplica por 3 o valor de a
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);
            s += "DEF";
            Console.WriteLine(s);
            // += também funciona com strings, criando uma concatenação da soma dos dois valores.

            Console.WriteLine(b);
            b++;
            Console.WriteLine(b);
            b--;
            Console.WriteLine(b);

            int c = 10;
            int d = ++c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            
            Quando definimos o valor  de uma variável como outra variavel++. O valor da primeira variável vai ser
            sempre somente o valor original da primeira variável antes da alteração.
            Porém, caso definamos o valor como ++nome da variavel, colocando os sinais de + antes do nome da variável,
            o valor dela será o valor atualizado.
            */

            // CONVERSÃO IMPLÍCITA ENTRE TIPOS
            /*
            float x = 4.5F;
            double y = x;
            
            Esse caso é possível somente devido ao bits presentes.
            Como float possui 4 bits e double possui 8. A conversão de algo de 4 bits para 8 bits é
            totalmente possível e funcional.
            
            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a;
            
            Normalmente não é possível associar valores de bits maiores dentro de bits menores.
            Pois isso pode ocasionar em perda de dados.
            Para pode realizar isso, mesmo sabendo das consequências, é necessário adicionar explicitamente
            no que o valor será transformado. Nessa caso, (float). Isso é o Casting.
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            double c = 5.5;
            int d = (int)c;
            Console.WriteLine(c);
            Console.WriteLine(d);
            // Nessa caso, ocorre explicitamente uma perda de informação. Transformando o valor de 5.5 para 5.
            // Ocorre porque int não pode ter números quebrados.

            int e = 5;
            int f = 2;

            double res = e / f;
            Console.WriteLine(res);
            // Nesse caso, ele se transformou numa divisão inteira, descartando qualquer valor excendente em casas decimais.
            res = (double)e / f;
            Console.WriteLine(res);
            // Pode ser utilizado o Casting no valor que será dividido, permitindo que a equação seja concluída corretamente.
            */

            // OPERADORES ARITMETICOS
            /*
            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            int n4 = 10 / 8;
            Console.WriteLine(n4);
            double n5 = (double)10 / 8;
            Console.WriteLine(n5);
            double n6 = 10.0 / 8;
            Console.WriteLine(n6);

            double a = 1.0, b = -3.0, c = -4.0;
            // double delta = b * b - 4.0 * a * c;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            double bask = (-b + Math.Sqrt(Math.Pow(b, 2) - 4.0 * a * c)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(bask);
            */

            // ENTRADA DE DADOS EM C# Parte 1

            // Entrada de dados básicos.
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine("Você digitou " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            // Comando split
            string a = Console.ReadLine();
            // Split funciona com vetores para separar o valores específicados em uma variavel.
            string[] vet = a.Split(' ');

            // Pode dar WriteLine de duas formas, ambas aparecendo o mesmo resultado.
            // Forma 1
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
            // Forma 2
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);

            // É possível também aplicar o split diretamente na aplicação do vetor
            string[] v = Console.ReadLine().Split(' ');
            Console.WriteLine(v[0]);
            Console.WriteLine(v[1]);
            Console.WriteLine(v[2]);
            */

            // ENTRADA DE DADOS EM C# Parte 2
            /*
            // o .Parse serve para coverter tipos númericos para string e vice-versa
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(n1);
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine(ch);
            // Caso seu computador esteja em portugues, é necessario utilizar a virgula ao invés do ponto quando preencher o double
            // Exceto quando utilizamos o InvariantCulture. Nesse caso, será utilizado o ponto
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));


            // É possível utilizar o método Split em uma string e repartir em tipos diferentes de vetores utilizando o .Parse
            string[] v = Console.ReadLine().Split(' ');

            // Podemos da WriteLine dessas duas formas
            // Sem definir variaveis relacionadas as posições no vetor
            Console.WriteLine(v[0]);
            Console.WriteLine(char.Parse(v[1]));
            Console.WriteLine(int.Parse(v[2]));
            Console.WriteLine(double.Parse(v[3], CultureInfo.InvariantCulture));

            // Definindo as variaveis do vetor
            string nome = v[0];
            char sexo = char.Parse(v[1]);
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            // EXERCÍCIO DE FIXAÇÃO:
            /*
            Console.WriteLine("Entre com o seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] v = Console.ReadLine().Split(' ');

            string ultimo_nome = v[0];
            int idade = int.Parse(v[1]);
            double altura = double.Parse(v[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimo_nome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            */

            //EXERCÍCIO 1:
            /*
            Console.WriteLine("Digite dois valores inteiros para serem somados (mesma linha): ");
            string[] v = Console.ReadLine().Split(' ');
            int n1 = int.Parse(v[0]);
            int n2 = int.Parse(v[1]);
            int n3 = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + n3);
            */

            // EXERCÍCIO 2:
            /*
            double pi = 3.14159;
            Console.WriteLine("Digite o valor do raio de um círculo para descobrirmos sua área: ");
            double raio = double.Parse(Console.ReadLine());
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine("A área é: ");
            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
            */

            // EXERCÍCIO 3:
            /*
            Console.WriteLine("Digite quatro valores inteiros para calcularmos a diferença: ");
            string[] v = Console.ReadLine().Split(' ');
            int a = int.Parse(v[0]);
            int b = int.Parse(v[1]);
            int c = int.Parse(v[2]);
            int d = int.Parse(v[3]);

            int dif = a * b - c * d;
            Console.WriteLine("A diferença dos valores enviados é: ");
            Console.WriteLine("Diferença = " + dif);
            */

            // EXERCÍCIO 4:
            /*
            Console.WriteLine("Digite o seu número de funcionário, número de horas trabalhadas e o valor que recebe por hora: ");
            string[] v = Console.ReadLine().Split(' ');
            int numero_funcionario = int.Parse(v[0]);
            int horas_trabalhadas = int.Parse(v[1]);
            double din_por_hora = double.Parse(v[2], CultureInfo.InvariantCulture);
            double salario = horas_trabalhadas * din_por_hora;

            Console.WriteLine("Número do funcionário: " + numero_funcionario);
            Console.WriteLine("Salário: U$" + salario.ToString("F2", CultureInfo.InvariantCulture));
            */

            // EXERCÍCIO 5:
            /*
            Console.WriteLine("Digite o código da peça 1, o número de peças 1 e o valor unitário de peças 1: ");
            string[] v1 = Console.ReadLine().Split(' ');
            int cod_peca1 = int.Parse(v1[0]);
            int num_peca1 = int.Parse(v1[1]);
            double valor_peca1 = double.Parse(v1[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o código da peça 2, o número de peças 2 e o valor unitário de peças 2: ");
            string[] v2 = Console.ReadLine().Split(' ');
            int cod_peca2 = int.Parse(v2[0]);
            int num_peca2 = int.Parse(v2[1]);
            double valor_peca2 = double.Parse(v2[2], CultureInfo.InvariantCulture);

            double total = num_peca1 * valor_peca1 + num_peca2 * valor_peca2;
            Console.WriteLine("O valor total a pagar é: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            */

            // EXERCÍCIO 6:
            /*
            Console.WriteLine("Digite os valores de A, B e C. Com isso mostraremos os cálculos a seguir: ");
            string[] v = Console.ReadLine().Split(' ');
            float A = float.Parse(v[0], CultureInfo.InvariantCulture);
            float B = float.Parse(v[1], CultureInfo.InvariantCulture);
            float C = float.Parse(v[2], CultureInfo.InvariantCulture);

            float pi = 3.14159f;

            float triangulo_ret = (A * C) / 2;
            double circulo = pi * Math.Pow(C, 2);
            float trapezio = ((A + B) * C) / 2;
            double quadrado = Math.Pow(B, 2);
            float retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo_ret.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
            */


            // OPERADORES COMPARATIVOS:
            /*
            int a = 10;
            bool c1 = a < 10;
            Console.WriteLine(c1);

            bool c2 = a < 20;
            Console.WriteLine(c2);

            bool c3 = a > 10;
            Console.WriteLine(c3);

            bool c4 = a > 5;
            Console.WriteLine(c4);

            Console.WriteLine("--------------");

            bool c5 = a <= 10;
            Console.WriteLine(c5);

            bool c6 = a >= 10;
            Console.WriteLine(c6);

            bool c7 = a == 10;
            Console.WriteLine(c7);

            bool c8 = a != 10;
            Console.WriteLine(c8);
            */

            // OPERADORES LÓGICOS:
            /*
            bool c1 = 2 < 3 && 4 != 5;
            Console.WriteLine(c1); // True

            bool c2 = !(2 > 3) && 4 != 5;
            Console.WriteLine(c2); // True

            Console.WriteLine("--------------");
            bool c3 = 10 < 5;
            bool c4 = c1 || c2 && c3;
            // Precendencia de &&(e) é maior que a de || (ou), logo && vai rodar primeiro
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            */

            // ESTRUTURA CONDICIONAL:
            int x = 10;
            Console.WriteLine("Bom dia");
            
            if ( x > 5) {
                Console.WriteLine("Boa tarde");
            }

            Console.WriteLine("Boa noite");

            // DEMO 1:
            Console.WriteLine("Escreva um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0) {
                Console.WriteLine("Par");
            } else {
                Console.WriteLine("Impar");
            }

            // DEMO 2:
            Console.WriteLine("Qual a hora atual? ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("bom dia");
            }
            if (hora >= 12 && hora < 18) {
                Console.WriteLine("boa tarde");
            }
            if (hora >= 18) {
                Console.WriteLine("boa noite");
            }
            // Pode ser feito dessas duas formas, porém, a segunda é a mais correta
            if (hora < 12) {
                Console.WriteLine("Bom dia");
            } else if (hora < 18) {
                Console.WriteLine("Boa tarde");
            } else {
                Console.WriteLine("Boa noite");
            }
        }
    }
}
