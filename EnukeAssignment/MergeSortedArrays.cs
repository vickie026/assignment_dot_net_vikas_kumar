using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnukeAssignment
{
    public class MergeSortedArrays
    {
        int[] FirstArray;
        int[] SecondArray;
        public int[] MergedArray { get; set; }
        
        public MergeSortedArrays()
        {

        }
        public MergeSortedArrays(int[] FirstArray, int[] SecondArray)
        {
            this.FirstArray = FirstArray;
            this.SecondArray = SecondArray;
        }
        public void Merge()
        {
            MergedArray = new int[FirstArray.Length + SecondArray.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while(true)
            {
                if(i >= FirstArray.Length && j >= SecondArray.Length)
                {
                    break;
                }
                if(i >= FirstArray.Length) 
                {
                    MergedArray[k] = SecondArray[j];
                    j++;
                }
                else if( j >= SecondArray.Length)
                {
                    MergedArray[k] = FirstArray[i];
                    i++;
                }
                else if(FirstArray[i] <= SecondArray[j])
                {
                    MergedArray[k] = FirstArray[i];
                    i++;
                }
                else
                {
                    MergedArray[k] = SecondArray[j];
                    j++;
                }
                k++;
            }
        }

    }
}
