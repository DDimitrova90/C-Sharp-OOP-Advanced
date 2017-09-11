﻿namespace _06_Birthday_Celebrations.Models
{
    using Interfaces;

    public class Robot : IRobot
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Id { get; private set; }

        public string Model { get; private set; }
    }
}
