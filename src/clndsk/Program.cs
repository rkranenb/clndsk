using System;

namespace clndsk {

    public class Program {

        public static void Main(string[] args) {

            try {
                IoC.CreateContainer()
                    .GetInstance<ICleaner>()
                    .Clean();
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}
