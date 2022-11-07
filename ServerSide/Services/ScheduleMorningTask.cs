using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MamitoWebAPI.Services
{
    public class ScheduleMorningTask
    {
        private Timer _timer;
        int _interval = 3600000;

        public void SetTimer(int mInterval)
        {
            // this is System.Threading.Timer, of course
            _timer = new Timer(Tick, null, _interval, Timeout.Infinite);
        }

        private void Tick(object state)
        {
            try
            {
                if (DateTime.Now.TimeOfDay > new TimeSpan(00, 00, 01) && DateTime.Now.TimeOfDay < new TimeSpan(08, 00, 00))
                { 

                }
                // Put your code in here
            }
            finally
            {
                _timer?.Change(_interval, Timeout.Infinite);
            }
        }

        private void ExecuteMorningTask() { 
        
        }
    }
}