namespace SubroutinesAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(n);
            cantChange(n);
            Console.WriteLine(n);
            string[] names = generatenames();
            for(int i=0;i<names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        static string[] generatenames()
        {
            string[] names = {"Bob","Betty", "Sue" };
            return names;
        }
        static int findName(string[] names,string name)
        {
            for(int i = 0;i<names.Length;i++)
            {
                if (names[i] == name)
                {
                    return i;
                }
            }
            return -1;

        }
        static void cantChange(int x) 
        {
          //  Console.WriteLine(x);
            x = 99;
            //Console.WriteLine(x);
        }
    }
}
