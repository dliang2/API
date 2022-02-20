using System;

namespace MyConsoleApplication
{
    public interface MyInterface
    {
        string MyString { get; set; }
        int MyInt { get; set; }
        bool MyBool { get; set; }
    }
    class MyClass : MyInterface
    {
        public string MyString { get; set; }
        public int MyInt { get; set; }
        public bool MyBool { get; set; }
    }

    class MyIndexer<T>
    {
    private T[]arr = new T[10];
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var MyInterface = new MyIndexer<MyClass>();
            MyClass p1 = new MyClass();
            p1.MyString = "String";
            p1.MyInt = 7;
            p1.MyBool = true;
            MyInterface[0] = p1;
            Console.WriteLine(MyInterface[0].MyString);
            Console.WriteLine(MyInterface[0].MyInt);
            Console.WriteLine(MyInterface[0].MyBool);
        }
    }
}
