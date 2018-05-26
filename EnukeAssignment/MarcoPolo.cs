using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnukeAssignment
{
    public class MarcoPolo
    {
        public int Limit { get; set; }
        public MarcoPolo()
        {
            Limit = 100;
        }
        public MarcoPolo(int Limit)
        {
            this.Limit = Limit;
        }
        private string MarcoPoloParser(int CountNumber)
        {
            if(CountNumber % 28 == 0)
            {
                return "marcopolo";
            }
            if(CountNumber % 7 == 0)
            {
                return "polo";
            }
            if(CountNumber % 4 == 0)
            {
                return "marco";
            }
            return "" + CountNumber;
        }
        public string Start()
        {
            string result = "";
            for(int i = 1; i <= Limit; i++)
            {
                if (i == Limit)
                {
                    result += MarcoPoloParser(i);
                }
                else
                {
                    result += MarcoPoloParser(i) + ",";
                }
            }

            return result;
        }
    }
}
