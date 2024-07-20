namespace ARRAYS_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ARRAY  | RANGE DESCRIBING
            int[] sayılar1=new int[] {15,5,35,25,75,48,8,9,78,98,6,4};
            
            var numbers =Array.CreateInstance(typeof(int),sayılar1.Length);// array statement is a class

            //value assigment
            numbers.SetValue(15, 0);
            numbers.SetValue(5, 0);
                
           

            //value assigment
            // alternative use
            numbers.SetValue(sayılar1[0], 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers.SetValue(sayılar1[i],i);
            }

            //finding value
            Array.IndexOf(sayılar1, 35);
            Console.WriteLine(Array.IndexOf(sayılar1, 35));
            /*If it cannot find the value in the array, it returns the result as -1.*/




            //clear 
            Array.Clear(numbers,8,2);


            //printing or roam

            for (int i = 0; i < sayılar1.Length; i++)
            {
                Console.Write("sayılar1[{0}] = {1} - numbers[{0}] = {2}   /*/-/*/",
                    i, sayılar1[i], numbers.GetValue(i));
                    
                // alternative use
                // string interpolation
                Console.WriteLine($"  sayılar1[{i}] = "+
                    $"{sayılar1[i],-5} - "+
                    $"numbers[{i}] =" +
                    $"{numbers.GetValue(i),-5}");
            }

          

            // arrangement
            Array.Sort(numbers);
            Array.Sort(sayılar1);

            


            // copy 
            for (int i = 0; i < sayılar1.Length; i++)
            {
                numbers.SetValue(sayılar1[i], i);
            }

            //alternative use 

            sayılar1.CopyTo(numbers, 0);

            //clear
            Array.Clear(sayılar1, 2, 3);


            Console.ReadKey();


        }
    }
}
