namespace DataStructureAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programs\n=================================");
            bool end = true;
            Console.WriteLine("1. Permutation of a word\n2. Binary Search\n3. End of program");
            while (end)
            {
                Console.Write("Choose an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        PermutationsOfString permutation = new PermutationsOfString();
                        permutation.permutations();
                        break;
                    case 2:
                        const string FILE_PATH = @"C:\Users\Sartaj khan\source\repos\DataStructureAlgorithm\DataStructureAlgorithm\BinarySearch.txt";
                        BInarySearchProb search = new BInarySearchProb();
                        string input_String = File.ReadAllText(FILE_PATH);
                        string[] array = input_String.Split(',');
                        int length = array.Length;
                        Console.Write("Enter the word to Search : ");
                        string key = Console.ReadLine();
                        int result = search.BinarySearchElement(array, 0, length - 1, key);
                        if (result == -1)
                        {
                            Console.WriteLine(key + " word is present in the file");
                        }
                        else
                            {
                                Console.WriteLine(key + " Word is  not present ");
                            }
                            break;
                    case 3:
                        String[] array1 = { "Baghel", "Cat", "English", "Vishwas", "Name", "Apple" };
                        InsertionSort sorting = new InsertionSort();
                        sorting.Sorting(array1);
                        sorting.DisplayArray(array1);
                        break;
                    case 4:
                        int[] array2 = { 56, 36, 98, 45, 12, 78, 49, 99 };
                        BubbleSort.BubbleSorting(array2);
                        Console.WriteLine("Sorted array");
                        BubbleSort.DisplayArray(array2);
                        break;
                    case 5:
                        MergeSort mergesorting = new MergeSort();
                        mergesorting.MergeSorting();
                        break;
                    case 6:
                        AnagramDetection detecting = new AnagramDetection();
                        detecting.DetectingAnagrams();
                        break;
                    case 7:
                        PrimeNumbers prime = new PrimeNumbers();
                        prime.PrimeNum();
                        break;
                    case 8:
                        AnagramAndPalindrome anagramAndPalindrome = new AnagramAndPalindrome();
                        anagramAndPalindrome.AnagramAndPalindromes();
                        break;
                    case 9:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("You choose an invalid option ");
                        break;
                }
            }
        }
    }
}