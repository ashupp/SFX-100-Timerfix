using SimFeedback.extension;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Reflection;

namespace TimerFixExtension
{
    public static class WinApi
    {
        /// <summary>TimeBeginPeriod(). See the Windows API documentation for details.</summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)]

        public static extern uint TimeBeginPeriod(uint uMilliseconds);

        /// <summary>TimeEndPeriod(). See the Windows API documentation for details.</summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)]

        public static extern uint TimeEndPeriod(uint uMilliseconds);
    }

    public class TimerFixExtension : AbstractSimFeedbackExtension
    {
        public TimerFixExtension()
        {
            Name = "SFX-100 Timerfix";
            Info = "Fixes Windows 10 high performance timer issues";
            Version = Assembly.LoadFrom(Assembly.GetExecutingAssembly().Location).GetName().Version.ToString();
            Author = "ashupp / ashnet GmbH";
            HasControl = false;
        }

        public override void Start()
        {
            Log(Name + ": Extension loaded");
            if (TimerUpgradeNecessary())
            {
                try
                {
                    Log(Name + ": slow timer detected - loading fix");
                    WinApi.TimeBeginPeriod(1);
                    Log(Name + ": fix loaded");
                }
                catch(Exception ex)
                {
                    Log(Name + ": Error during setting timer: " + ex.Message);
                }
            }
            else
            {
                Log("SFX-100-Timerfix: not necessary");
            }
        }

        private bool TimerUpgradeNecessary()
        {
            const int millisToWait = 10;
            const int runCounts = 50;
            long[] timeValues = new long[runCounts];
            int i = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                if (i >= runCounts) break;
                sw.Restart();
                Thread.Sleep(millisToWait);
                long t0 = sw.Elapsed.Milliseconds;

                timeValues[i] = t0;
                i++;
            }

            var averageTimer = timeValues.Average();
            Log(Name + ": Average timer value: " + averageTimer.ToString());

            return averageTimer > 12;
        }

        public override void Stop()
        {
            Log(Name + ": Extension unloaded");
        }
        
    }
}
