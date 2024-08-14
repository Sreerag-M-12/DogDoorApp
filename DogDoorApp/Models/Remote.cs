using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace DogDoorApp.Models
{
    internal class Remote
    {
        public DogDoor Door {  get; set; }
        private System.Timers.Timer _timer;
        
        public Remote()
        {
            Door = new DogDoor();
        }
        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button");
            if (Door.IsOpen())
            {
                Door.CloseDoor();
                StopTimer();
            }
            else
            {
                Door.OpenDoor();
                StartTimer();
            }
        }

        private void StartTimer()
        {
            _timer = new System.Timers.Timer(5000); // Set timer for 10 seconds
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = false; // Timer should only fire once
            _timer.Start();
        }

        private void StopTimer()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
                _timer = null;
            }
        }


        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Timer elapsed. Closing the door automatically.");
            Door.CloseDoor();
            StopTimer(); 

        }
    }
}
