namespace ShellSort
{
    class ShellSortProgram
    {
        static void Main(String[] args)
        {
            ShellSort shellSort = new ShellSort();
            int[] unsorted = Array.ConvertAll(args[0].Split(','), int.Parse);
            int[] sortedInts = shellSort.Sort(unsorted);
            Array.ForEach(sortedInts, Console.WriteLine);
        }
    }
}