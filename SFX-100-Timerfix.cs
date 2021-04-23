using SimFeedback.extension;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace SFX100Timerfix
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

        private TimerfixControl _extCtrl;

        public TimerFixExtension()
        {
            Name = "SFX-100 Timerfix";
            Info = "Fixes Windows 10 high performance timer issues";
            Version = Assembly.LoadFrom(Assembly.GetExecutingAssembly().Location).GetName().Version.ToString();
            Author = "ashupp / ashnet GmbH";
            NeedsOwnTab = false;
            HasControl = true;
        }

        public override void Init(SimFeedbackExtensionFacade facade, ExtensionConfig config)
        {
            base.Init(facade, config);
            Log(Name + ":Initialize Extension");
            _extCtrl = new TimerfixControl(this, facade);
        }

        public override void Start()
        {
            Log(Name + ": Extension loaded");
            _extCtrl.Start();
        }


        public override void Stop()
        {
            _extCtrl.Stop();
            Log(Name + ": Extension unloaded");
        }

        public override Control ExtensionControl => _extCtrl;

    }
}
