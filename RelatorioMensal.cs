using System;

namespace Aula_10__Polimorfismo
{
    public class RelatorioMensal : Relatorio
    {
        public override void MostrarRelatorio(){
            base.MostrarRelatorio();
            Console.WriteLine ("Mostrando o ralatório mensal");
        }
    }
}