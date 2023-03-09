using TrainingProject.LinkedList;
using TrainingProject.String;

namespace TrainingProject
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Training Project!!!");
            FindDuplicatesInAnArray findDuplicates = new FindDuplicatesInAnArray();
            var ArrayList = findDuplicates.Example();
            //Console.WriteLine(String.Join("\n", ArrayList));
            //Console.ReadLine();


            SortArray sort = new SortArray();
            var sortArray = sort.Example(ArrayList);
            //Console.WriteLine(String.Join("\n", sortArray));
            //Console.ReadLine();

            int[] missingNumbers = { 1, 2, 3, 4, 6, 8, 9, 10 };
            FindMissingNumber missingNumber = new FindMissingNumber();
            var missNum = missingNumber.Example(missingNumbers);
            //Console.WriteLine(String.Join("\n", missNum));
            //Console.ReadLine();

            //How do you find Largest and Smallest number in Array....
            int[] normalArray = { 1, 2, 3, 4, 5, 6, 8, 68, 88, 45, 99 };
            int maxArray = normalArray.Max();
            int minArray = normalArray.Min();
            //Console.WriteLine("Max Number in Array : " + maxArray);
            //Console.WriteLine("Min Number in Array : " + minArray);
            //Console.ReadLine();


            getPairsCount getPairs = new getPairsCount();
            int[] arrPairs = { 1, 5, 7, 1, 5 };
            int sum = 6;
            //getPairs.Example(arrPairs, sum);

            HowManyDuplicateInArray duplicateInArray = new HowManyDuplicateInArray();
            int[] exampleArray = { 10, 10, 4, 5, 5, 6, 7, 4, 3, 2, 2, 2, 10 };
            //duplicateInArray.Example(exampleArray);

            //How to remove duplicate values from an array in c#
            int[] nums = { 10, 10, 4, 5, 5, 6, 7, 4, 3, 2, 2, 2, 10 };
            int[] disct = nums.Distinct().ToArray();
            //for (int i = 0; i < disct.Length; i++)
            //{
            //    Console.WriteLine("Values : " + disct[i]);
            //}            
            //Console.ReadKey();

            //Quick Sort Array
            int[] sortArr = { 3, 4, 5, 6, 100, 45, 56, 78, 23, 32 };
            //int n = 10, i;
            //Console.WriteLine("Normal array :");
            //for (i = 0; i < n; i++) { Console.WriteLine(sortArr[i]+","); }

            //QuickSortArray quickSort = new QuickSortArray();
            //quickSort.quickSort(sortArr, 0, 9);
            //Console.WriteLine("\nSorted Array :");
            //for(i = 0; i < n; i++) { Console.WriteLine(sortArr[i]); }
            //Console.ReadKey();

            //Reverse Array
            int[] reverseArray = { 3, 4, 5, 6 };
            Array.Reverse(reverseArray);
            //Console.WriteLine(String.Join(",", reverseArray));
            //Console.ReadKey();

            int[] unsortedArray = new int[8] { 5, 3, 6, 2, 1, 3, 8, 5 };
            //RemoveDuplicateElementsFromArray removeDuplicate = new RemoveDuplicateElementsFromArray();
            //var distinctArray = removeDuplicate.RemoveArrayDuplicates(unsortedArray);
            //Array.Sort(distinctArray);
            //for (i = 0; i <= distinctArray.Length - 1; i++)
            //{                
            //    Console.WriteLine(distinctArray[i]);
            //}
            //Console.ReadKey();

            PrintTheMiddleofLinkedList theMiddleofLinkedList = new PrintTheMiddleofLinkedList();
            //for(int p = 6; p > 0; p--)
            //{
            //    theMiddleofLinkedList.push(p);
            //    theMiddleofLinkedList.printList();
            //    theMiddleofLinkedList.printMiddle();
            //}
            
            DetectLoopinALinkedList detect = new DetectLoopinALinkedList();
            //detect.push(15);
            //detect.push(5);
            //detect.push(10);
            //detect.push(7);

            //detect.head.next.next.next.next = detect.head;

            //if(detect.detectLoop(detect.head))
            //{
            //    Console.WriteLine("Loop Found");
            //}
            //else
            //{
            //    Console.WriteLine("Loop Not Found");
            //}

            ReverseLinkedList reverseLinked = new ReverseLinkedList();
            //reverseLinked.AddNode(new ReverseLinkedList.Node(85));
            //reverseLinked.AddNode(new ReverseLinkedList.Node(10));
            //reverseLinked.AddNode(new ReverseLinkedList.Node(5));
            //reverseLinked.AddNode(new ReverseLinkedList.Node(25));

            //Console.WriteLine("Linked List :");
            //reverseLinked.PrintList();

            //reverseLinked.ReverseList();

            //Console.WriteLine("Reverse Linked List");
            //reverseLinked.PrintList();


            PrintAllTheDuplicatesInString printDuplicates = new PrintAllTheDuplicatesInString();
            //printDuplicates.printDups("test test string");

            NonRepeatCharacter nonRepeat = new NonRepeatCharacter();
            //string str = "testctest";
            //int index = nonRepeat.firstNonRepeating(str);
            //Console.WriteLine(index == -1 ? "Empty" : "First non repeat " + str[index]);

            ReverseStringUsingRecursion recursion = new ReverseStringUsingRecursion();
            //recursion.reverse("TesttoTest");

            CheckStringisDigits digits = new CheckStringisDigits();
            //bool test = digits.isDigits("16");
            //Console.WriteLine(test);            

            FindDuplicateinString find = new FindDuplicateinString();
            //find.Run();

            PrintTheTotalNumberOfVowels vowels = new PrintTheTotalNumberOfVowels();
            //vowels.vowels("asftestsawer");

            CountOccurrencesOfCharacterWithinString countOccurrences = new CountOccurrencesOfCharacterWithinString();
            //countOccurrences.example("Teknoloji", 'o');

            PrintAllPermutations permu = new PrintAllPermutations();
            //string test = "ABCDE";
            //int nt = test.Length;
            //permu.permute(test, 0, nt - 1);

            ReverseWords reverseWords = new ReverseWords();
            //string words = "examine test build compare ";
            //char[] test = reverseWords.reverseWords(words.ToCharArray());
            //Console.WriteLine(test);
            //Console.ReadKey();

            Rotations rotations = new Rotations();
            //string str1 = "FGABCDE";
            //string str2 = "ABCDEFG";

            //if (rotations.areRotations(str1, str2))
            //    Console.Write("Strings are"
            //    + " rotation s of each other");
            //else
            //    Console.Write("Strings are "
            //   + "not rotations of each other");

            //Palindrome
            string _inputstr, _reversestr = string.Empty;
            //Console.Write("Enter a string : ");
            //_inputstr = Console.ReadLine();
            //if (_inputstr != null)
            //{
            //    for (int i = _inputstr.Length - 1; i >= 0; i--)
            //    {
            //        _reversestr += _inputstr[i].ToString();
            //    }
            //    if (_reversestr == _inputstr)
            //    {
            //        Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
            //    }
            //    else
            //    {
            //        Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
            //    }
            //}
            //Console.ReadLine();

        }
    }  
}      

