using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ramdomizar
{
    class Procesador
    {

        private char[] letras = new[]{
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L'
            , 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        }; 
        enum MyEnum
        {
          

        }


        public string Ramdimozar(string entrada)
        {
            int num = 0;
            string randoms = "";
            Random r = new Random();
            for (int i = 0; i < (16-entrada.Count()); i++)
          
            {
              
                num=r.Next(0, 26);
                randoms += letras[num];
            }
              num=r.Next(0, 26);
            return Randomizar2Nivel(String.Concat(entrada,randoms).Replace(' ',letras[num]));
        }

        public string Randomizar2Nivel(string x)
        {

            object[] pos = new object[x.Count()];

            for (int i = 0; i < x.Length; i++)
            {
                pos[i] = i;
            }
            List<object> newpos = new List<object>();

            while (pos.Count()!=0)
            {
                if (pos.Count() == 1)
                {
                    newpos.Add(pos[0]);
                    pos = new object[0];
                }
                else
                {
                    Random r = new Random();
                    int num = r.Next(0, pos.Count());
                    newpos.Add(pos[num]);
                   pos= delete(pos, num);
                }
            }

            string fin = "";
            for (int i = 0; i < newpos.Count; i++)
            {
                fin += x[int.Parse(newpos[i].ToString())];
            }
            
            return fin;
        }

        public void R(object[] pos, List<object> newpos)
        {
            
          
        }

        private object[] delete(object[] arr, int val)
        {
            arr[val] = null;
            List<object> newo = new List<object>();

            for (int i = 0; i < arr.Count(); i++)
            {
                if(arr[i]!=null)
                    newo.Add(arr[i]);
            }
            
            arr=new object[newo.Count];
            for (int i = 0; i < newo.Count; i++)
            {
               
                arr[i] = newo[i];
            }
            return arr;
        }

        public bool Search(int  x,object[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].ToString() == x.ToString())
                {
                    return true;
                }
            }
            return false;
        }
  
    
    
}
}
