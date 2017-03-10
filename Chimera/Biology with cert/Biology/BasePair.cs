using System;

namespace Chimera
{
    class BasePair
    {
        char topValue;
        char bottomValue;
        public BasePair(char value,bool top)
        {
            value = Char.ToUpper(value);
            if(top)
            {
                this.topValue = value;
                switch (value)
                {
                    case 'A':
                        bottomValue = 'T';
                        break;
                    case 'G':
                        bottomValue = 'C';
                        break;
                    case 'T':
                        bottomValue = 'A';
                        break;
                    case 'C':
                        bottomValue = 'G';
                        break;
                }
            }
            else
            {
                this.bottomValue = value;
                switch (value)
                {
                    case 'A':
                        topValue = 'T';
                        break;
                    case 'G':
                        topValue = 'C';
                        break;
                    case 'T':
                        topValue = 'A';
                        break;
                    case 'C':
                        topValue = 'G';
                        break;
                }
            }
            
        }

        public static BasePair[] createFromString(string dna)
        {
            BasePair[] returnValue = new BasePair[dna.Length];
            int i = 0;
            foreach (char value in dna)
            {
                returnValue[i] = new BasePair(value,true);
                i++;
            }
            return returnValue;
        }
        public static BasePair[] createFromStringBottom(string dna)
        {
            BasePair[] returnValue = new BasePair[dna.Length];
            int i = 0;
            foreach (char value in dna)
            {
                returnValue[i] = new BasePair(value,false);
                i++;
            }
            return returnValue;
        }

        public string getTop()
        {
            return topValue.ToString();
        }

        public string getBottom()
        {
            return bottomValue.ToString();
        }


    }
}
