using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogDoorApp.Models
{
    internal class DogDoor
    {
        public bool Open {  get; set; }
        public DogDoor() 
        {
            Open = false;
        }
        public void OpenDoor()
        {
            Console.WriteLine("The dog door opens");
            Open = true;
        }
        public void CloseDoor()
        {
            Console.WriteLine("The dog door closes");
            Open = false;
        }
        public bool IsOpen() { 
            return Open; 
        }
    }
}
