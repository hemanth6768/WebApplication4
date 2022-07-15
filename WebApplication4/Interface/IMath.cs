using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Interface
{
    public interface IMath
    {
        
        public int  add(int x, int y);  

        public int subtract(int x, int y);  

        public int multiply(int x, int y); 

        public double divide(int x, int y);
    }
}
