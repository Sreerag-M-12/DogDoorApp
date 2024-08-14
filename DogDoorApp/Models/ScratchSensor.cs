using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DogDoorApp.Models
{
    internal class ScratchSensor
    {
        public DogDoor Door { get; set; }
        private System.Timers.Timer _timer;

        public ScratchSensor()
        {
            Door = new DogDoor();
        }

        public void ScratchDoor()
        {
     
            if(!Door.IsOpen())
            { 
                Console.WriteLine("Dog Scratches the door");
                Door.OpenDoor();
                StartTimer();
            }
        }

        private void StartTimer()
        {
            _timer = new System.Timers.Timer(5000); 
            _timer.Elapsed += TimerElapsed;
            _timer.AutoReset = false; 
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
