﻿using System;

namespace project_06_10_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variaveis
            //(nome; idade; rg; profissao; cidade; genero; estadoCivil; local; cpf; endereco;)
        
            Console.WriteLine("\n=======================================================");
            Console.WriteLine("Existem algumas pendências na sua conta. Faça login e");
            Console.WriteLine("resolva. Digite seu nome de usuário e senha abaixo:\n");

            int condicao = 1;
            while (condicao != 0){
                Console.Write("Usuario: ");
                string usuario = Console.ReadLine();
                Console.Write("Senha: ");
                string senha = Console.ReadLine();

                if(usuario == "teste" && senha == "teste"){
                    Console.WriteLine("\n=======================================================");
                    Console.WriteLine("Olá, precisamos de algumas informações para concluir");
                    Console.WriteLine("o seu cadastro. Por favor, digite seu(a):\n");
                    Console.Write("NOME:");
                    string nome = Console.ReadLine();
                    Console.Write("IDADE:");
                    string idade = Console.ReadLine();
                    Console.Write("RG:");
                    string rg = Console.ReadLine();
                    Console.Write("PROFISSÃO:");
                    string profissao = Console.ReadLine();
                    Console.Write("CIDADE:");
                    string cidade = Console.ReadLine();
                    Console.Write("GÊNERO:");
                    string genero = Console.ReadLine();
                    Console.Write("ESTADO CIVIL:");
                    string estadoCivil = Console.ReadLine();
                    Console.Write("LOCAL DE NASCIMENTO:");
                    string local = Console.ReadLine();
                    Console.Write("CPF:");
                    string cpf = Console.ReadLine();
                    Console.Write("ENDEREÇO:");
                    string endereco  = Console.ReadLine();
                    
                    Console.WriteLine("\n============================================="); 
                    Console.WriteLine("Resumo dos dados:\n");
                    Console.WriteLine("NOME: "+nome);
                    Console.WriteLine("IDADE: "+idade);
                    Console.WriteLine("RG: "+rg);
                    Console.WriteLine("PROFISSÃO: "+profissao);
                    Console.WriteLine("CIDADE: "+cidade);
                    Console.WriteLine("GÊNERO: "+genero);
                    Console.WriteLine("ESTADO CIVIL: "+estadoCivil);
                    Console.WriteLine("LOCAL DE NASCIMENTO: "+local);
                    Console.WriteLine("CPF: "+cpf);
                    Console.WriteLine("ENDEREÇO: "+endereco);
                    Console.WriteLine("=============================================\n");
                    break;
                    
                }
                else{
                    Console.WriteLine("Dados Inválidos");
                }
            }
        }
    }
}
