using Master_Coding.Algorithms;
using Master_Coding.Algorithms.Sorting;
using Master_Coding.DataStructureArrays;
using Master_Coding.DataStructureHashTable;
using Master_Coding.DataStructureLinkedList;
using Master_Coding.GoogleInterviewQuestion;
using Master_Coding.LeetCode;
using Master_Coding.Trees;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Master_Coding
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Contacts_application contacts_Application = new Contacts_application();
            List<List<string>> queries = new List<List<string>>();
            queries.Add("add ed".Split(" ").ToList());
            queries.Add("add eddie".Split(" ").ToList());
            queries.Add("add edward".Split(" ").ToList());
            queries.Add("find ed".Split(" ").ToList());
            queries.Add("add edwina".Split(" ").ToList());
            queries.Add("find edw".Split(" ").ToList());
            contacts_Application.contacts(queries);
            Find_Common_Characters find_Common_Characters = new Find_Common_Characters();
            find_Common_Characters.CommonChars(new string[] { "bella", "label", "roller" });
            //RotateRight rotateRight = new RotateRight();
            //ListNode listNode = new ListNode(1);
            //listNode.next = new ListNode(2);
            //listNode.next.next = new ListNode(3);
            //listNode.next.next.next = new ListNode(4);
            //listNode.next.next.next.next = new ListNode(5);
            //rotateRight.RotateRight1(listNode, 2);
            // Rotate_Array rotate_Array = new Rotate_Array();
            // rotate_Array.Rotate(new int[] { -1, -100, 3, 99 }, 3);
            // Words_Data_Structure wordDictionary = new Words_Data_Structure();
            // wordDictionary.AddWord("bad");
            // wordDictionary.AddWord("dad");
            // wordDictionary.AddWord("mad");
            // wordDictionary.Search("pad"); // return False
            // wordDictionary.Search("bad"); // return True
            // wordDictionary.Search(".ad"); // return True
            //var xgx =  wordDictionary.Search("b.."); // return True
            ////var xgxd =  wordDictionary.Search("b..."); // return True
            //var xgxdd =  wordDictionary.Search("b...."); // return True
            //Trie trie = new Trie();
            //trie.Insert("apple");
            //var i= trie.Search("apple");   // return True
            //var y = trie.Search("app");     // return False
            //var t= trie.StartsWith("app"); // return True
            //trie.Insert("app");
            //var d= trie.Search("app");     // return True
            var tt = 0;
        //    new Merge_Sorted_Array().Merge(new int[] {4,5,6,0,0,0 },3,new int[] {1,2,3 },1);
        //    new Insertion_Sort().InsertionSort(new int[] { 99,44,6,2,1,5,63,87,283,4,999,44,6,2,1,5,63,87,283,4,999,44,6,2,1,5,63,87,283,4,999,44,6,2,1,5,63,87,283,4,999,44,6,2,1,5,63,87,283,4,9});
        //    Console.WriteLine(new Median_of_Two_Sorted_Arrays().FindMedianSortedArrays(new int[] { 3,4,7,6}, new int[] { 1,2 }));
        //new First_Missing_Positive().FirstMissingPositive(new int[] { 0,2,2,1,1 });
        //new Next_Permutation().NextPermutation(new int[] { 2,3,1});
        //new ReverseString().ReverseStringFunction((new string[] { );
            Console.WriteLine(new FindFactorial().FibonacciIterativeRecursive(100));
            //BinarySearchTree tree = new BinarySearchTree();
            //tree.Insert(9);
            //tree.Insert(4);
            //tree.Insert(6);
            //tree.Insert(20);
            //tree.Insert(170);
            //tree.Insert(15);
            //tree.Insert(1);
            //var dd = tree.DFSPostOrder();
          
            //Console.WriteLine(tree.Lookup(1));
            //Word_Break word_Break = new Word_Break();
            //List<string> vs1 = new List<string>();
            //IList<string> vs = vs1;
            //vs.Add("apple");
            //vs.Add("pen");
            //var x = word_Break.WordBreak("applepenapple", vs);
            //Console.WriteLine(x);
            //Next_Closest_Time next_Closest_Time = new Next_Closest_Time();
            //var s = next_Closest_Time.NextClosestTime("10:11");
            //Merge_Intervals merge_Intervals = new Merge_Intervals();
            //List<int[]> holdMerge = new List<int[]>();
            //holdMerge.Add(new int[] { 1, 4 });
            //holdMerge.Add(new int[] { 4, 5 });
            //merge_Intervals.Merge(holdMerge.ToArray());
            //Implement_Queue_using_Stacks implement_Queue_Using_Stacks = new Implement_Queue_using_Stacks();
            //implement_Queue_Using_Stacks.Push(1);
            //implement_Queue_Using_Stacks.Push(2);
            //implement_Queue_Using_Stacks.Push(3);
            //implement_Queue_Using_Stacks.Push(4);
            //var x = implement_Queue_Using_Stacks.Peek();
            //Trapping_Rain_Water trapping_Rain_Water = new Trapping_Rain_Water();
            //var s = trapping_Rain_Water.Trap(new int[] { 4, 2, 0, 3, 2, 5 });
            //Valid_Parentheses valid_Parentheses = new Valid_Parentheses();
            // var x =  valid_Parentheses.IsValid("((");
            // var x = new MaxStack();
            // x.Push(5);
            // //x.Pop();
            // x.Push(4);
            // x.Push(3);
            //// x.Pop();
            // var c =  x.GetMax();
            // x.Push(2);
            // x.Push(5);
            // x.Push(1);
            // //x.Pop();
            // x.Push(0);
            // x.RemoveMaxVal();
            // x.RemoveMaxVal();
            //  c = x.GetMax();

            // x.RemoveMaxVal();
            // x.RemoveMaxVal();
            // x.RemoveMaxVal();
            // x.RemoveMaxVal();
            // x.RemoveMaxVal();
            // x.RemoveMaxVal();

            // c = x.GetMax();
            // var t = 0;
            //var myLinkedList = new MyLinkedList<int>(10);

            //myLinkedList.Append(5);
            //myLinkedList.Append(16);
            //myLinkedList.Prepend(1);
            //myLinkedList.Insert(2, 4);
            //myLinkedList.Reverse1();
            //myLinkedList.Reverse();
            //myLinkedList.PrintList().ForEach(x => Console.WriteLine(x));

            // Console.WriteLine(new Best_Time_to_Buy_and_Sell_Stock_III().MaxProfit(new int[] { 1,4,2,2,7,8,1,9,0,7,0,9 }));
            //Console.WriteLine(
            //    FirstRecurringCharacter.FirstRecurringCharacterFunction(
            //        new int[] { 2, 3, 4, 5 }));
            //var myHashTable = new HashTable(45);
            //myHashTable.Set("grapes", 40000);
            //myHashTable.Set("grapess", 70000);
            //Console.WriteLine( myHashTable.Get("grapes"));
            //myHashTable.Set("apples", "good");
            //Console.WriteLine( myHashTable.Get("apples"));

            //Console.WriteLine();
            //var root = new TreeNode();
            //root.val = 3;
            //root.left = new TreeNode(val: 2, left: null, right: new TreeNode(val: 3));
            //root.right = new TreeNode(val: 3, left: null, right: new TreeNode(val: 1));
            //Console.WriteLine(House_Robber_iii.Rob(root));
            //MergeSortedArray.MergeSortedArrayFunction(new int[] { 1, 2, 3, 0, 0, 0 },3,new int[] { 2, 5, 6 },3);
            //int[] array1 = { 1, 2, 3 };
            //int[] array2 = { 1,2,3,1 };
            //var myArray = new MyArray();
            //myArray.Push("hi");
            //myArray.Push("you");
            //myArray.Push("hi");
            //myArray.Push("you");
            //myArray.Delete(1);
            //Console.WriteLine(myArray.Lenght());
            //Console.WriteLine(House_Robber_II.Rob(array2));
            //Console.WriteLine( FindingMatchingPair.NaiveMethod(array1, array2));
            //Console.WriteLine( FindingMatchingPair.CorrectMethod(array1, array2));
        }
        void IncreaseArraySize()
        {
            
        }
    }
}
