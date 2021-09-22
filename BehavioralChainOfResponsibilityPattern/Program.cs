using System;

namespace BehavioralChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            */

            PlayerHandler mp4 = new ConcreteMp4Handler();
            PlayerHandler mp3 = new ConcreteMp3Handler();
            PlayerHandler avi = new ConcreteAviHandler();
           

           
            mp3.SonrakiHandler = mp4;
            mp4.SonrakiHandler = avi;
            
            
            mp3.Play("dasda.mp3");
       
        }
    }
}
