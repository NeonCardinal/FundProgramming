using System;
using System.Collections.Generic;
using System.Text;

namespace CellPhone
{
    public class Battery
    {
        public enum BatteryModel
        {
            LiIon,
            NiMH,
            NiCd
        }

        private int idleTime;
        private BatteryModel batteryModel;
        private double hoursTalk;

        public int IdleTime { get => idleTime; set => idleTime = value; }
        public BatteryModel Model { get => batteryModel; set => batteryModel = value; }
        public double HoursTalk { get => hoursTalk; set => hoursTalk = value; }

        public Battery()
        {
            this.idleTime = 0;
            this.batteryModel = 0;
            this.hoursTalk = 0.00;
        }

        public Battery(int idleTime, BatteryModel batteryModel, double hoursTalk)
        {
            this.idleTime = idleTime;
            this.batteryModel = batteryModel;
            this.hoursTalk = hoursTalk;
        }
    }
}
