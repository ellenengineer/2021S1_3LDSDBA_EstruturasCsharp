using System;
using System.Collections.Generic;
using System.Text;

namespace TesteCondicoes
{
    public class clsDiasSemana
    {
        //propriedade enumerador
        public DiaUteisSemana DiaSemanaProperty { get; set; }

        public DiaUteisSemana Dia1 { get; set; }
        public DiaUteisSemana Dia2 { get; set; }

        public clsDiasSemana()
        { 
        }

        /*public clsDiasSemana(DiaUteisSemana dia1, DiaUteisSemana dia2)
        {
            Dia1 = dia1;
            Dia2 = dia2;
        }*/

         //ou
        public clsDiasSemana(DiaUteisSemana dia1, DiaUteisSemana dia2) => (Dia1, Dia2) = (dia1, dia2);

        public void Deconstruct(out DiaUteisSemana dia1, out DiaUteisSemana dia2) =>
            (dia1, dia2) = (Dia1, Dia2);
    }
}
