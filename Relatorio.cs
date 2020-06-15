using System;

namespace Aula_10__Polimorfismo
{
     public class Relatorio
    {   
        public DateTime data;
        public virtual void MostrarRelatorio(){
            System.Console.WriteLine("Mostrando o Relatório Geral");
        }
    }
}