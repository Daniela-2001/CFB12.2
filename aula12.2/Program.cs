﻿namespace aula12._2
{
    internal class Program
    {
        static void Main(){
            int nota = 0;
            string resultado= "Reprovado";

            nota= int.Parse(Console.ReadLine());

            if(nota >= 60){
                resultado = "Aprovado";
            }

            Console.WriteLine("Resultado: {0}", resultado);
        }
    }
}