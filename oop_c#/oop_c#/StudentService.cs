namespace oop_c_
{
    public interface StudentService
    {
          string id { get; set; }
         int GetStudentId();
         string GetStudentNames();
    }

    public class StudentServiceImp : StudentService
    {
        public string id { get; set; }

        public int GetStudentId()
        {
            return -1;
        }

        public string GetStudentNames()
        {
            return "names";
        }
        
    }
}