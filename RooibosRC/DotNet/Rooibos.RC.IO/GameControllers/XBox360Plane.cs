using Rooibos.Library;
using Rooibos.Library.GameControllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rooibos.RC.IO.GameControllers
{
    public class XBox360Plane
    {
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr window, int message, int wparam, int lparam);

        public enum ChangeEnumType
        {
            Ailerons,
            Elevators,
            Rudder,
            Power
        }

        public delegate void OnInputChangedEventHandler(object sender, int angleAilerons, int angleElevators, int angleRudder, int power, ChangeEnumType[] changes);

        public event OnInputChangedEventHandler OnInputChangedEvent;

        public int AileronsDegreesMax { get; set; }
        public int AileronsDegreesMin { get; set; }
        public int AileronsDegreeLevel { get; set; }

        public int ElevatorsDegreesMax { get; set; }
        public int ElevatorsDegreesMin { get; set; }
        public int ElevatorsDegreesLevel { get; set; }

        public int RudderDegreesMax { get; set; }
        public int RudderDegreesMin { get; set; }
        public int RudderDegreesLevel { get; set; }

        public int PowerMax { get; set; }
        public int PowerMin { get; set; }

        private Angles m_controllerLock;

        public XBox360Plane(int aileronsDegreesMax, int aileronsDegreesMin, int aileronsDegreeLevel,
            int elevatorsDegreesMax, int elevatorsDegreesMin, int elevatorsDegreesLevel,
            int rudderDegreesMax, int rudderDegreesMin, int rudderDegreesLevel, int powerMin, int powerMax)
        {
            this.AileronsDegreeLevel = aileronsDegreeLevel;
            this.AileronsDegreesMax = aileronsDegreesMax;
            this.AileronsDegreesMin = aileronsDegreesMin;

            this.ElevatorsDegreesLevel = elevatorsDegreesLevel;
            this.ElevatorsDegreesMax = elevatorsDegreesMax;
            this.ElevatorsDegreesMin = elevatorsDegreesMin;

            this.RudderDegreesLevel = rudderDegreesLevel;
            this.RudderDegreesMax = rudderDegreesMax;
            this.RudderDegreesMin = rudderDegreesMin;

            PowerMax = powerMax;
            PowerMin = powerMin;

            m_controllerLock = new Angles(this.AileronsDegreeLevel, this.ElevatorsDegreesLevel, this.RudderDegreesLevel, this.PowerMin);
        }

        public void ControllerStart()
        {
            while (true)
            {
                if (this.OnInputChangedEvent == null)
                {
                    return;
                }

                var state = GamePad.GetState(PlayerIndex.One);

                try
                {
                    int degreesX = AileronsDegreeLevel;
                    int degreesY = ElevatorsDegreesLevel;
                    int degreesRudder = RudderDegreesLevel;
                    int power = PowerMin;

                    lock (m_controllerLock)
                    {
                        degreesX = Degrees.Scale(state.ThumbSticks.Right.X, AileronsDegreesMin, AileronsDegreesMax, AileronsDegreeLevel);
                        degreesY = Degrees.Scale(state.ThumbSticks.Right.Y, ElevatorsDegreesMin, ElevatorsDegreesMax, ElevatorsDegreesLevel);
                        power = Degrees.Scale(Convert.ToInt32(Math.Round(state.Triggers.Right)), PowerMin, PowerMax);

                        List<ChangeEnumType> changes = new List<ChangeEnumType>();

                        if (power != m_controllerLock.Power)
                        {
                            m_controllerLock.Power = power;
                            changes.Add(ChangeEnumType.Power);
                        }

                        if (degreesX != m_controllerLock.Ailerons)
                        {
                            m_controllerLock.Ailerons = degreesX;
                            changes.Add(ChangeEnumType.Ailerons);
                        }

                        if (degreesY != m_controllerLock.Elevators)
                        {
                            m_controllerLock.Elevators = degreesY;
                            changes.Add(ChangeEnumType.Elevators);
                        }
                        
                        degreesRudder = Degrees.Scale(state.ThumbSticks.Left.X, RudderDegreesMin, RudderDegreesMax, RudderDegreesLevel);

                        if (degreesRudder != m_controllerLock.Rudder)
                        {
                            m_controllerLock.Rudder = degreesRudder;
                            changes.Add(ChangeEnumType.Rudder);
                        }

                        if (changes.Count > 0 && (this.OnInputChangedEvent != null))
                        {
                            this.OnInputChangedEvent(this, m_controllerLock.Ailerons, m_controllerLock.Elevators, m_controllerLock.Rudder, m_controllerLock.Power, changes.ToArray());
                        }

                        Thread.Sleep(50); // Very important! Must do this so servo's do not get throttled / freaked out and cause the arduino to seize up!
                    }
                }
                catch { };
            }
        }
    }
}
