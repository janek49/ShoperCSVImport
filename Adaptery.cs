using NReco.Csv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoperCSVImport
{
    public class TeifocStanyAdapter : StanyAdapter
    {
        public TeifocStanyAdapter()
        {
            idxID = 0;
            idxTytul = 1;
            idxDostepny = 2;
            idxEAN = 3;
            filterTitle = "teifoc";
        }

       
    }

    public class EitechStanyAdapter : StanyAdapter
    {
        public EitechStanyAdapter()
        {
            idxID = 0;
            idxTytul = 3;
            idxDostepny = 1;
            idxEAN = 2;
            filterTitle = "eitech";
        }

 
    }

    public class EitechCenyAdapter : CenyStanyAdapter
    {
        public EitechCenyAdapter()
        {
            idxID = 0;
            idxTytul = 1;
            idxCena = 2;
            idxDostepny = 3;
            idxEAN = 4;
            filterTitle = "eitech";
        }
    }

    public class HamaStanyAdapter : StanyAdapter
    {
        public HamaStanyAdapter()
        {
            idxID = 0;
            idxTytul = 1;
            idxDostepny = 2;
            idxEAN = 3;
            filterTitle = "hama";
        }

    }
}
