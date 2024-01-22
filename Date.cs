using System;
namespace Hello_World
{
    public class Date
    {

        public int Day { get; set; }

        public int Month { get; set; }

        public int aYear { get; set; }





        public bool IsLeap(int ayear)
        {
            if ( ayear % 400 == 0)
                { return true; }
            if (ayear%4==0 && aYear%100!=0)
                { return true; }
            //if (ayear % 4 != 0)
                //{ return false; }
           
            else
                return false;
            
        }
    }
}
