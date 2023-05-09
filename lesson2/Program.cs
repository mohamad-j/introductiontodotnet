// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using MyApp.Syrians;
namespace MyApp {
    class Project2 {
        public static void Main()
        {
            Console.WriteLine(" Project2 ");

            MyApp.Norwegians.Student s1 = new ("Moha", 123 );


            Console.WriteLine( s1.getName() );

            MyApp.Norwegians.Teacher t1 = new ("Moha", 223 );

            Console.WriteLine( s1.p_name );

            Console.WriteLine( s1.nationality );


        }
    }
}