using System.Collections;

namespace Zadacha
{
    internal class Program
    {
        
            static int[] nums = { 10, -15, 100, 0, -200 };
            static void Main(string[] args)
            {
                //da se syzdade zadcha koqto da wkrava chisla ot klaviaturata i da gi slaga na 3-to mqsto po 3 nachina s 3 metoda
                //I.s Array list
                //II.da go napyhava v LinkedList
                //III.s Stack

                Console.Write("which number do you wnat on third position:");

                int insert = int.Parse(Console.ReadLine());
                Console.WriteLine("===================================");
                ArrayList updatedList = AddInArraylist(insert);
                PrintArrList(updatedList);
                Console.WriteLine();
                Console.WriteLine("===================================");
                LinkedList<int> list = AddInLList(insert);
                PrintLLst(list);



            }
            static ArrayList AddInArraylist(int insert)
            {
                ArrayList list1 = new ArrayList();
                list1.AddRange(nums);
                list1.Insert(2, insert);
                return list1;
            }
            static LinkedList<int> AddInLList(int addNum)
            {
                LinkedList<int> list = new LinkedList<int>(nums);
                LinkedListNode<int> linkedListNode = list.First.Next;
                list.AddAfter(linkedListNode, addNum);
                return list;
            }




            static void PrintArrList(ArrayList updatedList)
            {
                foreach (int i in updatedList)
                {
                    Console.Write(i + " ");
                }
            }
            static void PrintLLst(LinkedList<int> list)
            {
                Console.WriteLine(string.Join(" ", list));
           }
        
    }
}
