namespace EmployeeWage
{
   internal class Program
    {
        public void Main(string[] args)
        {
         Employee empname = new Employee();
            empname.Attendance();
            int result=empname.Dailywage();
            Console.WriteLine(result);
        }
    }
}