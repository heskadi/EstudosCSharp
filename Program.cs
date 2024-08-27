using System;
using System.Globalization;
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

            // ENTRADA DE DADOS EM C#

        }
    }
}
