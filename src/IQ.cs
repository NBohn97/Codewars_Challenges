using System;
using System.Collections.Generic;
using System.Linq;

public class IQ
    {
        public static int Test(string numbers)
        { 
            string[] numbersarr =  numbers.Split(' ');
            List<int> evenlist = new List<int>();
            List<int> oddlist = new List<int> ();
            int i = 0;
            int differs = 0;

            foreach(string num in numbersarr){

                Int32.TryParse(num,out int numint);
                if(numint % 2 == 0){
                    evenlist.Add(i + 1);
                }
                else 
                {
                    oddlist.Add(i + 1);
                }

                if (evenlist.Count >= 2 && oddlist.Count > 0)
                {
                    differs = oddlist[0];
                }
                else if ( oddlist.Count >= 2 && evenlist.Count > 0)
                {
                    differs = evenlist[0];
                }

                i++;
            }

            return differs; 

        }
        
    }


