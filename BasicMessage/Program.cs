using System;

namespace Hello_World
{
    public  class BasicMessageClass
    { public string message;
        public int number; 

        public static void ShowMessage(){
            Console.WriteLine("Hello World!");
        }
        public string Message() {
            message = "Hello World";
            return message;


        }

    }
}
