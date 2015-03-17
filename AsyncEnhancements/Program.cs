using System;
using System.Threading.Tasks;

namespace AsyncEnhancements
{
    class MyProgram
    {

        static void Main()
        {
            DoStuff().Wait();
        }

        public static async Task DoStuff()
        {
            try
            {
                await MyProgram.Log("In Try");

                throw new Exception("Threw Exception");
            }
            catch (Exception ex)
            {
                await MyProgram.Log(ex.Message);
            }
            finally
            {
                await MyProgram.Log("In Finally.");
            }
        }

        public static async Task Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
