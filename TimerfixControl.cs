using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using SimFeedback.extension;

namespace SFX100Timerfix
{
    public partial class TimerfixControl : UserControl
    {
        TimerFixExtension tfExt;
        SimFeedbackExtensionFacade sfbFacade;

        public TimerfixControl(TimerFixExtension timerFixExtension, SimFeedback.extension.SimFeedbackExtensionFacade facade)
        {
            tfExt = timerFixExtension;
            sfbFacade = facade;
            InitializeComponent();
        }


        private bool TimerUpgradeNecessary()
        {
            const int millisToWait = 10, runCounts = 50;
            var timeValues = new long[runCounts];
            var i = 0;
            var sw = new Stopwatch();
            sw.Start();

            while (true)
            {
                if (i >= runCounts) break;
                sw.Restart();
                Thread.Sleep(millisToWait);
                timeValues[i] = sw.Elapsed.Milliseconds;
                i++;
            }

            var averageTimer = timeValues.Average();
            Log(Name + ": Average timer value: " + averageTimer.ToString());

            return averageTimer > 12;
        }

        internal void Log(string message)
        {
            if (logBox.Items.Count >= 500)
            {
                logBox.Items.RemoveAt(0);
            }

            logBox.Items.Add(DateTime.Now + ": " + message);
            logBox.SelectedIndex = logBox.Items.Count - 1;

            int visibleItems = logBox.ClientSize.Height / logBox.ItemHeight;
            logBox.TopIndex = Math.Max(logBox.Items.Count - visibleItems + 1, 0);

            sfbFacade.Log(message);
        }

        internal void DrawError()
        {
            pictureBoxCurrentStatus.BackColor = Color.Red;
        }

        internal void DrawSuccess()
        {
            pictureBoxCurrentStatus.BackColor = Color.Green;
        }


        internal void Start()
        {
            if (TimerUpgradeNecessary())
            {
                try
                {
                    Log(Name + ": slow timer detected - loading fix");
                    WinApi.TimeBeginPeriod(1);
                    Log(Name + ": fix loaded");

                    if (TimerUpgradeNecessary())
                    {
                        DrawError();
                        Log(Name + ": timer still slow - fix could not lower timer interval");
                    }
                    else
                    {
                        DrawSuccess();
                        Log(Name + ": fix is working - enjoy :) ");

                    }
                }
                catch (Exception ex)
                {
                    DrawError();
                    Log(Name + ": Error during setting timer: " + ex.Message);
                }
            }
            else
            {
                DrawSuccess();
                Log(Name + ": not necessary");
            }
        }

        internal void Stop()
        {
        }


        private void btnCheckTimer_Click(object sender, EventArgs e)
        {
            TimerUpgradeNecessary();
        }

        private void btnApplyFix_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(lblLink.Text);
            Process.Start(sInfo);
        }

        private void lblDesc_Click(object sender, EventArgs e)
        {

        }

        private void logBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
