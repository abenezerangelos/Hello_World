using System;


namespace Hello_World
{ public class AngleClass
{
    private double angleRadians; // angle in radians
    public double AngleDegrees; // PROPERTY – angle in degrees
        public double value;
    
        public double get (){ return angleRadians; }
        public void set (double value) { angleRadians = value / 180.0 * Math.PI; }
    }
}

namespace Hello_World
{
    public struct AngleStruct
    {

        private double angleRadians; // angle in radians
        public double AngleDegrees; // PROPERTY – angle in degrees
        public double value;
        
           public double get() { return angleRadians; }
        public void set(double value) { angleRadians = value / 180.0 * Math.PI; }
    } }



   
namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AngleClass angle = new AngleClass();
            

            //More important part of the code down below:
            angle.AngleDegrees = 40;
            angle.value = 5;
            
            angle.AngleDegrees = angle.value;
            angle.set(angle.AngleDegrees);
            Console.WriteLine(angle.get());
            Console.WriteLine(angle.value);// Here you can see that the value of angle .value

            



            









































        }
    }
}