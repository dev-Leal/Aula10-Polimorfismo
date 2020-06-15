using System;

namespace Aula_10__Polimorfismo
{
    public class RelatorioAnual : Relatorio 

    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine ("Mostrando o relatório Anual");
        }
    }
}