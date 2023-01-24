using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModLoaderInterfaces;

namespace Workaholics
{
    public class AdjustSleepTimes : IAfterWorldLoad
    {
        public void AfterWorldLoad()
        {
            ServerManager.ServerSettings.Time.SleepTimeStart = 23.999f;
            ServerManager.ServerSettings.Time.SleepTimeEnd = 0;
            ServerManager.ServerSettings.Time.GuardShiftDayStart = ServerManager.ServerSettings.Time.SleepTimeEnd;
            ServerManager.ServerSettings.Time.GuardShiftDayEnd = ServerManager.ServerSettings.Time.SleepTimeStart;
            ServerManager.ServerSettings.Time.GuardShiftNightStart = ServerManager.ServerSettings.Time.SleepTimeEnd;
            ServerManager.ServerSettings.Time.GuardShiftNightEnd = ServerManager.ServerSettings.Time.SleepTimeStart;
        }
    }
}
