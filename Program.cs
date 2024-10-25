namespace GenericsArrays
{

    /*Single-dimensional arrays that have a lower bound 
     * of zero automatically implement IList<T>. 
     * This enables you to create
     * generic methods that can use the same code to 
     * iterate through arrays and other collection types. 
     * This technique is primarily useful for reading data in 
     * collections. The IList<T> interface cannot be used to add 
     * or remove elements from an array. An exception will be 
     * thrown if you try to call an IList<T> method such as 
     * RemoveAt on an array in this context.

        The following code example demonstrates how a
        single generic method that takes an IList<T>
        input parameter can iterate through both a list and
        an array, in this case an array of integers.
     * 
     * 
     * 
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [0, 1, 2, 3, 4];
            List<int> list = new List<int>();

            for (int x = 5; x < 10; x++)
            {
                list.Add(x);
            }

            ProcessItems<int>(arr);
            ProcessItems<int>(list);
        }
        static void ProcessItems<T>(IList<T> coll)
        {
            // IsReadOnly returns True for the array and False for the List.
            System.Console.WriteLine
                ("IsReadOnly returns {0} for this collection.",
                coll.IsReadOnly);

            // The following statement causes a run-time exception for the
            // array, but not for the List.
            //coll.RemoveAt(4);

            foreach (T item in coll)
            {
                System.Console.Write(item?.ToString() + " ");
            }
            System.Console.WriteLine();
        }
    }
}

