using System;
using System.Collections;

namespace PlayingwithCSharp
{
    public class FullNametoSplitName
    {
        public static void FullNameto()
        {
            string str = "Logesh Palani";
            ArrayList arrayList = new ArrayList();
            string Temp = "";
            for (var i = 0; i < str.Length; i++)
            {

                if (str[i] != ' ')
                {
                    Temp = Temp + str[i];
                    if(i + 1 == str.Length)
                    {
                        arrayList.Add(Temp);
                        Temp = String.Empty;
                    }

                }
                else
                {
                    arrayList.Add(Temp);
                    Temp = String.Empty;
                }
                

            }
            //var inte = arrayList.Count;
            for (int i = 0; i < arrayList.Count; i++)
            {
                System.Console.WriteLine(arrayList[i]);
            }
            
            Console.ReadLine();
        }
    }
}

//Output 
//Logesh
//Palani