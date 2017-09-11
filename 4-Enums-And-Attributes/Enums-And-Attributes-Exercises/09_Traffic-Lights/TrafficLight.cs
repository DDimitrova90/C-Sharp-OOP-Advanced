namespace _09_Traffic_Lights
{
    using System;

    public class TrafficLight
    {
        public TrafficLight(string signal)
        {
            this.Signal = (LightSignal)Enum.Parse(typeof(LightSignal), signal);
        }

        public LightSignal Signal { get; private set; }

        public void Update()
        {
            if (this.Signal == LightSignal.Red)
            {
                this.Signal = LightSignal.Green;
            }
            else if (this.Signal == LightSignal.Green)
            {
                this.Signal = LightSignal.Yellow;
            }
            else if (this.Signal == LightSignal.Yellow)
            {
                this.Signal = LightSignal.Red;
            }
        }
    }
}
