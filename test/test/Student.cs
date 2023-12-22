using  packageName;

namespace Jeeed
{
    public class Student
    {
        private int id;

        public virtual void DoSomething()
        {
            Myclass myclass = new Myclass();
            Myclass.printSomething1();
        }
    }

    class  Student1:Student
    {
        
        public override void DoSomething()
        {
         Console.WriteLine("skfdskafklsdlflkslk");
        }
        
        public void DoSomething2()
        {
       
        }

        public int U(int x, int y)
        {
            return x + y;
        }
        
    }
    
    
    
    
    
    
    
}