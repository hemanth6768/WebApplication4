using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Interface
{
    public class math : IMath
    {
       
        public int add(int x, int y)
        {
            return x + y;   
        }

        public double divide(int x, int y)
        {
            return x/y;
        }

        public int multiply(int x, int y)
        {
            return x*y;
        }

        public int subtract(int x, int y)
        {
            return x-y;
        }
    }
}
