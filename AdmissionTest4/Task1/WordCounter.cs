using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class WordCounter
    {

        public int Count(string text)
        {
            int state = 0;
            int count = 0;
            text = text.Trim();
            char [] arr = new char[] {' ','\n','\t','$','{','}',']','[','@','#','%','^','&','*','\'','(',')','!'
            ,'1','2','3','4','5','6','7','8','9','0',',','.','?','/','~','`',':',';','>','<',',','|','\\','=','+','-','_'};
            for (int i = 0; i < text.Length; i++)
            {
                if(arr.Contains(text[i]))
                {
                    state = 0;
                }
                else if (state == 0)
                {
                    state = 1;
                    ++count;
                }
            }
            return count;
        }
    }
}
