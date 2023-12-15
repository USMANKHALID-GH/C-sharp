

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] arg)
        {
            MyNamespace2.MyClass myClass = new MyNamespace2.MyClass("usman");
            myClass.anythin = "YES";
            myClass.about = "come home";
            myClass.internal_protected = "internel proteced";
            myClass.protected_internel = "protected internel";
            Console.WriteLine($"public {myClass.anythin}   internel {myClass.about}    p_int {myClass.internal_protected} int_o {myClass.protected_internel}");
        }
    }
}

namespace MyNamespace2
{
    class MyClass1:MyClass
    {
        private string name;
        private string sname;
        public MyClass1( string sname ,string name):base(name)
        {
            this.sname = sname;
        }

        public override string getName()
        {
            return this.name;
        }
    }

    class MyClass
    {
        public string anythin;
        private string name;

        protected string content;

        protected internal string protected_internel;
        internal protected string internal_protected;
        internal string about;


        public MyClass(string name)
        {
            this.name = name;
        }

     
        
      
        
        public  virtual string getName()
        {
            return this.name;
        }
}
    
}