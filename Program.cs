using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace sistema_para_escola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;
            string[] aluno = new string[2];
            int[] idade = new int[2];
            string[] sexo = new string[2];

            while (menu != 3)
            {

                if (menu == 0)
                {
                    Console.WriteLine("1 - Adicionar alunos");
                    Console.WriteLine("2 - lista de alunos");
                    Console.WriteLine("3 - sair");
                    int.TryParse(Console.ReadLine(), out menu);
                }


                if (menu == 1)
                {

                    //Solicitar o nome dos alunos
                    for (int index = 0; index < aluno.Length; index++)
                    {
                        Console.WriteLine("Qual nome do aluno?");
                        string nome = Console.ReadLine();

                        //Solicitar a idade
                        Console.WriteLine("Qual a idade?");
                        string idades = Console.ReadLine();

                        //Solicitar o sexo
                        Console.WriteLine("Qual o sexo do aluno(a)?");
                        string sex = Console.ReadLine();

                        Console.Clear();
                        aluno[index] = nome;    
                    }
                    menu = 0;
                }
                else if (menu == 2)
                {

                    Console.WriteLine("Essa é a lista de alunos");
                    for(int index = 0; index < aluno.Length; index++)
                    {
                        Console.WriteLine($"{index + 1} - {aluno[index]}");
                        int.TryParse(Console.ReadLine()), out menu);
                    }
                }
                        
                    

                
            }
        }
    }
}
