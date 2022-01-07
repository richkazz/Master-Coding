using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.DataStructureArrays
{
    public class MyArray
    {
        int lenght;
        int index;
        dynamic[] data;
        public MyArray()
        {
            this.lenght = 0;
            this.index = 0;
            this.data = new dynamic[10];
        }
        public dynamic[] GetData(int index) => this.data[index];

        public void  Push(dynamic data)
        {
             this.data[this.index] = data;
             index++;
        }
        public int Lenght() => this.index;
      
        public dynamic  Pop()
        {
            if(index != 0)
            {
                var lastItem = this.data[this.index - 1];
                this.data[this.index - 1] = null;
                index--;
                return lastItem;
            }
            return "Error: No more Item";
        }
        public dynamic  Delete(int index)
        {
            if(index != 0)
            {
                //var item = this.data[index];
                ShiftItem(index);
            }
            return "Error: Array is empty";
        }
        public void ShiftItem(int index)
        {
            for(int i = index; i < this.index - 1; i++)
            {
                 this.data[i] = this.data[i+1];
                
            }
            this.data[this.index-1] = null;
            this.index --;
        }

    }
}
