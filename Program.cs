using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace primeiroSistema1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine("Hello, world >:3!"); //Writeline mostra o texto na tela
             Console.WriteLine("Olá, mundo >:3!"); //write mostra o texto na tela sem quebrar a linha
             //Console.WriteLine(1 + 3);


             string nomeAluno = "Rafael"; //declaração de variavél e atribuição de valor
             Console.WriteLine(nomeAluno);

             string idAluno = "1";
             Console.WriteLine(idAluno);

             string telAluno = "(14) 99657-4888";
             Console.WriteLine(telAluno);

             decimal salarioAluno = 1200;
             Console.WriteLine(salarioAluno);

             string cidadeAluno = "Botucatu, SP";
             Console.WriteLine(cidadeAluno);


             const int meuNum = 15;  //declaração de variavél
             Console.WriteLine(meuNum); //atribuição de valor para variavél / declaração de constante - o valor é imutavel

             string paisAluno = "Brasil"; //usando interpolação de string para separar o texto do valor da variavél 
             Console.WriteLine($"O aluno nasceu no: {paisAluno}. seja bem vindo! {nomeAluno}");

             /* string paisAluno = "Brasil";
             usando contenação com espaços explícitos (antigo). Ambas funcionam, mas a intercolação é mais moderna, melhorando a legibilidade para manutenção do código
             Console.WriteLine("O aluno nasceu no: " + paisAluno, ". seja bem vindo! " nomeAluno); */

            //Atividade - I C# Declarando variáveis

            /* int idCurso = 001;
             Console.WriteLine(idCurso);
             string nomeCurso = "Técnico em Desinvolvimento de Sistemas";
             Console.WriteLine(nomeCurso);
             string dtInicioCurso = "27/01/2025";
             Console.WriteLine(dtInicioCurso);
             string dtFimCurso = "15/03/2026";
             Console.WriteLine(dtFimCurso);
             const int idadeMinimaCurso = 17;
             Console.WriteLine(idadeMinimaCurso);
             int quantAlunosCurso = 25;
             Console.WriteLine(quantAlunosCurso);

             Console.WriteLine($"O {nomeCurso} de {idCurso} terá seu início no dia {dtInicioCurso} e irá acabar no dia {dtFimCurso}, com a idade mínima do curso sendo de {idadeMinimaCurso} com uma turma de no maximo {quantAlunosCurso} alunos na sala.");

             int x = 10;
             int y = 20;
             Console.WriteLine(x + y);

             //Atividade - II Tipos de dados

             int meuCodigo = 10;
             Console.WriteLine(meuCodigo);
             double meuSalario = 1000;
             Console.WriteLine(meuSalario);
             char minhaInicial = 'R';
             Console.WriteLine(minhaInicial);
             Boolean meuBooleano = false;
             Console.WriteLine(meuBooleano);
             string meuTexto = "Olá TI";
             Console.WriteLine(meuTexto);

             int meuInt = 10;
             double meuDouble = meuInt; //conversão de int para double
             Console.WriteLine(meuInt);
             Console.WriteLine(meuDouble); 

             double meuDouble = 10.50;
             int meuInt1 = (int) meuDouble; //conversão de double para int
             Console.WriteLine(meuDouble);
             Console.WriteLine(meuInt1); 

             int meuInt2 = 10;
             double meuDouble2 = 8.15;
             bool meuBool = true; 

             Console.WriteLine(Convert.ToString(meuInt2)); //converte int para string
             Console.WriteLine(Convert.ToDouble(meuInt2)); //converte int para double
             Console.WriteLine(Convert.ToInt32(meuDouble2)); //converte double para int
             Console.WriteLine(Convert.ToString(meuBool)); //converte booleano para string

             Console.WriteLine("Digite seu nome:");
             string nomeUser = Console.ReadLine(); //aguarda a entrada do usuário
             Console.WriteLine($"Olá, bem vindo (a) {nomeUser}! :)"); 

             //Custom

             Console.WriteLine("Para acessar a sala, é necessário que insirá a senha");
             string resposta = Console.ReadLine();
             Console.WriteLine("senha incorreta, insira a senha correta:");
             string resposta2 = Console.ReadLine();
             Console.WriteLine("senha incorreta, em caso de um 3° erro, o pc ira entra em modo de auto destuição");
             string resposta3 = Console.ReadLine();
             Console.WriteLine("Senha incorreta, adeus.");
             Console.WriteLine("3");
             Console.WriteLine("2");
             Console.WriteLine("1"); 

             Console.WriteLine("Digite a sua idade abaixo: ");
             int idade = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"Você tem {idade} anos"); 

             //atividade

             Console.WriteLine("Digite o primeiro número:");
             int numero1 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Digite o segundo número:");
             int numero2 = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine($"A soma de {numero1} + {numero2} é =");
             Console.WriteLine(numero1 + numero2); */

             int c = 4;
             int d = 6;
             Console.WriteLine(c + d);
             Console.WriteLine(c - d);
             Console.WriteLine(c * d);
             Console.WriteLine(c / d);
             Console.WriteLine(c % d);

            //operador de incremento
             int w = 10;
             w++;
             Console.WriteLine(w);

            //operador decremento
             int p = 5;
             p--;
             Console.WriteLine(p);

            //operador de atribuição
             int valorV = 300;
             valorV += 10;
             Console.WriteLine(valorV);

            /*operadores de atribuição

             =
             +=
             -=
             *=
             /=
             %=
            
            Operador de de comparação*/

             int u = 5;
             int v = 6;
             Console.WriteLine(v > u);

            /*
             * == igual a
             * != diferente
             * > maior que
             * < menor que
             * >= maior e igual
             * <= menor e igual
            */

            Console.Writeline("Hello, world")
             
        }
    }
}
