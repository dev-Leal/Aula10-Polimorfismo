using System;

namespace Aula_10__Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Relatorio Relatorio = new Relatorio ();
            Relatorio Mensal = new RelatorioMensal ();
            Relatorio Anual = new RelatorioAnual ();
            Console.WriteLine ("Digite a data de acordo com o Relatório que deseja!");
            Console.WriteLine ("Use o seguinte modelo para ter acesso:");
            Console.WriteLine ("ANO/MES/DIA  THORA:MINUTOS:SEGUNDOS ");
            Relatorio.data = DateTime.Parse(Console.ReadLine()); 
            Console.WriteLine("Data:" + Relatorio.data);
            Relatorio.MostrarRelatorio();
            Mensal.MostrarRelatorio();
            Anual.MostrarRelatorio();
        }
    }
}
