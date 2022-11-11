namespace Memory
{

    struct MyType1
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    class MyType2
    {

    }

    class Person
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    internal class Program
    {

  

        static void Main(string[] args)
        {
            int i = 1;
            MyType1 type1 = new MyType1();
            MyType2 type2 = new MyType2();
            bool f = true;
            string s = "Hello!";
            DoProcess(i, f);

            #region ABC

            #endregion

            Person person = new Person();
            int generation = GC.GetGeneration(person);
            Console.WriteLine($"Generation >>> {generation}");
            GC.Collect();

            generation = GC.GetGeneration(person);
            Console.WriteLine($"Generation >>> {generation}");
            GC.Collect();

            generation = GC.GetGeneration(person);
            Console.WriteLine($"Generation >>> {generation}");

            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();
            GC.Collect();

            generation = GC.GetGeneration(person);
            Console.WriteLine($"Generation >>> {generation}");
        }

        static void DoProcess(int a, bool flag)
        {
            a = 100;
            flag = false;
        }


    }
}