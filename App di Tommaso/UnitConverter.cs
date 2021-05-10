using System;


namespace App_di_Tommaso.Converters // ho creato una parte di namespace che gestirà tutti i convertitori
{
    public class UnitConverter  //l'ho resa pubblica per riutilizzarla in giro per il mio codice
    {

        // constructor , membro(pezzetto che compone il tipo) di topo FUNZIONE
        public UnitConverter(int unitRatio)          //metodo = funzione
        {
            ratio = unitRatio;


        }


        // field , membro di tipo DATO ed i dati li creaimo instanziando dei tipi
        int ratio;



        //method , membro di tipo FUNZIONE
        public int Convert(int value)
            {

            return value * ratio;

            }

    }
}
