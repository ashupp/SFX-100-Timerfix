using SimFeedback.extension;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security;
using System;
using System.Reflection;
using SimFeedback.conf;

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

    [Serializable]
    public class TimerFixConfig : ICustomConfig
    {
        public bool ForceApply { get; set; }

        public double Threshold { get; set; }
    }

    public class TimerFixExtension : AbstractSimFeedbackExtension
    {

        private TimerfixControl _extCtrl;

        private TimerFixConfig _config;

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


            _config = (TimerFixConfig)config.CustomConfig;
            if (_config == null)
            {
                LogDebug("FanatecExtension: No Config found, creating new config");
                _config = new TimerFixConfig()
                {
                    ForceApply = false,
                    Threshold = 12
                };
                config.CustomConfig = _config;
            }


            _extCtrl = new TimerfixControl(this, facade, _config);

        }

        public override void Start()
        {
            Log(Name + ": Extension loaded");

            _extCtrl.Start(_config.ForceApply);
        }


        public override void Stop()
        {
            _extCtrl.Stop();
            Log(Name + ": Extension unloaded");
        }

        public override Control ExtensionControl => _extCtrl;

    }
}
