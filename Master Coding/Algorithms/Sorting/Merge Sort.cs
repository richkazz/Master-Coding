using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Algorithms.Sorting
{
    public class Merge_Sort
    {
        public class Node
        {
            public int[] Array;
            public Node Left;
            public Node Right;
            public Node(int[] array)
            {
                Array = array;
                Left = null;
                Right = null;
            }
        }
        Node MergedArray ;
        int countttt = 0;
        public int[] MergeSort(int[] array)
        {
            if (array.Length < 2)
                return array;
            MergedArray = new Node(array);
            Merge(MergedArray);

            
            return MergedArray.Array;
        }

        void Merge(Node mergedArray)
        {
            if (mergedArray.Array.Length>1)
            {
                CreateLeft(mergedArray.Array, mergedArray);
                CreateRight(mergedArray.Array, mergedArray);
                   
                ///use the second half to create the second array
                Merge(mergedArray.Left);
                
                Merge(mergedArray.Right);
                mergedArray.Array = combineArrays(mergedArray.Left.Array,mergedArray.Right.Array);
            }
           
        }
        void CreateLeft(int[] array, Node node)
        {
            ///ues the first half to create the left array
            int[] temp = new int[array.Length / 2];
            Array.Copy(array, temp, array.Length / 2);
            Node nodeL = new Node(temp);
            node.Left = nodeL;
        }
        void CreateRight(int[] array, Node node)
        {
            ///use the second half to create the second array
            int[] temp = new int[array.Length - (array.Length / 2)];
            Array.ConstrainedCopy(array, array.Length / 2, temp, 0, array.Length - (array.Length / 2));
            Node nodeL = new Node(temp);
            node.Right = nodeL;
        }

        void Merge1(Node mergedArray)
        {
            if (mergedArray.Array.Length>1)
            {
                var array = mergedArray.Array;
                int[] temp = new int[array.Length / 2];
                Array.Copy(array, temp, array.Length / 2);
                Node node = new Node(temp);
                mergedArray.Left = node;
                temp = new int[array.Length - (array.Length / 2)];
                Array.ConstrainedCopy(array, array.Length / 2, temp, 0, array.Length - (array.Length / 2));
                node = new Node(temp);
                mergedArray.Right = node;
                Merge(mergedArray.Left);
                mergedArray.Left.Array = new Insertion_Sort().InsertionSort(mergedArray.Left.Array);
                for (var i =0; i < mergedArray.Left.Array.Length; i++)
                {
                    mergedArray.Array[i] = mergedArray.Left.Array[i];
                }
                Merge(mergedArray.Right);
                mergedArray.Right.Array = new Insertion_Sort().InsertionSort(mergedArray.Right.Array);
                int j = 0;
                for (var i = mergedArray.Left.Array.Length; i < mergedArray.Array.Length; i++)
                {
                    mergedArray.Array[i] = mergedArray.Right.Array[j];
                    j++;
                }
            }
            else
            {
                
            }
         
        }

        public int[]  combineArrays(int[] nums1, int[] nums2)
        {
            if (!nums1.Any() && !nums2.Any())
                return nums1;
           
            List<int> merged = new List<int>();
            int count = -1;
            var lenght = nums2.Length + nums1.Length;
            int j = 0;
            int i = 0;
            int check = lenght / 2; ;
            bool second = false;

            while (true)
            {
                countttt++;
                if (i != nums1.Length && !second)
                {
                    if (j != nums2.Length)
                    {
                        if (nums1[i] < nums2[j])
                        {
                            merged.Add(nums1[i]);
                            count++;
                            i++;
                        }
                        else
                        {
                            merged.Add(nums2[j]);
                            count++;
                            j++;
                        }
                    }
                    else
                    {
                        merged.Add(nums1[i]);
                        count++;
                        i++;
                    }

                }
                else
                {
                    merged.Add(nums2[j]);
                    count++;
                    j++;
                }

                if (i  + j  == lenght)
                {
                    break;
                }

            }

            return merged.ToArray();
        }
    }
}
