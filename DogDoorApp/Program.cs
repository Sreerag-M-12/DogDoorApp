using DogDoorApp.Models;

namespace DogDoorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DogDoor dogDoorFrido = new DogDoor();
            Remote remoteFrido = new Remote();
            Console.WriteLine("Frido barks to go out");
            remoteFrido.PressButton();
            Console.WriteLine("Frido is outside");
           // remote.PressButton();
            Console.WriteLine("Frido wants to Enter home");
            //  remote.PressButton();
            //   remote.PressButton();

            //  remote.PressButton();

            try
            {
                Thread.Sleep(10000);
            }
            catch (ThreadInterruptedException e)
            {
                
            }
            Console.WriteLine("he is stuck outside");
            Console.WriteLine("fido barks");
            remoteFrido.PressButton();
            Console.WriteLine("Fido is inside");


            Thread.Sleep(10000);

            Console.WriteLine();

            DogDoor dogDoorTex = new DogDoor();
            Remote remoteTex = new Remote();

            remoteTex.PressButton();
            Console.WriteLine("Tex goes outside");
            try
            {
                Thread.Sleep(7000);
            }
            catch (ThreadInterruptedException e)
            {

            }
            Console.WriteLine("Tex comes back");
            remoteTex.PressButton();


            Console.WriteLine();

            DogDoor dogDoorBruce = new DogDoor();
            Remote remoteBruce = new Remote();
            ScratchSensor scratchSensor = new ScratchSensor();

            Console.WriteLine("Bruce scrateches");
            scratchSensor.ScratchDoor();
            Console.WriteLine("Bruce leaves home");
            
            Thread.Sleep(7000);
            Console.WriteLine();
            Console.WriteLine("Bruce scratches door again");
            scratchSensor.ScratchDoor();


            Thread.Sleep(6000);
            Console.WriteLine("Exiting the program...");

        }
    }
}
