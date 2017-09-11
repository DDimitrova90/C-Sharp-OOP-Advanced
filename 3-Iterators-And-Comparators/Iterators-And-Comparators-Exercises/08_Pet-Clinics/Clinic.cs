namespace _08_Pet_Clinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Clinic
    {
        private IList<Pet> rooms;
        private int startIndex;
        private Stack<Pet> firstPart;
        private Queue<Pet> secondPart;

        public Clinic(string name, List<Pet> rooms)
        {
            this.Name = name;
            this.Rooms = rooms;
            this.startIndex = this.Rooms.Count / 2;
            this.firstPart = new Stack<Pet>(this.Rooms.Take(startIndex));
            this.secondPart = new Queue<Pet>(this.Rooms.Skip(startIndex + 1));
        }

        public string Name { get; private set; }

        public IList<Pet> Rooms
        {
            get
            {
                return this.rooms;
            }

            private set
            {
                if (value.Count % 2 == 0)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                this.rooms = value;
            }
        }

        public bool AddPet(Pet pet)
        {
            int count = 1;

            while (this.Rooms.Any(r => r == null))
            {
                if (this.Rooms[startIndex] == null)
                {
                    this.Rooms[startIndex] = pet;
                    return true;
                }
                else if (firstPart.Count > 0 && firstPart.Peek() == null)
                {
                    this.Rooms[this.startIndex - count] = pet;
                    count++;
                    return true;
                }
                else if (secondPart.Count > 0 && secondPart.Peek() == null)
                {
                    this.Rooms[this.startIndex + count] = pet;
                    count++;
                    return true;
                }
            }

            return false;
        }

        public bool ReleasePet()
        {
            for (int i = this.startIndex; i < this.Rooms.Count; i++)
            {
                if (this.Rooms[i] != null)
                {
                    this.Rooms[i] = null;
                    return true;
                }
            }

            for (int i = 0; i < this.startIndex; i++)
            {
                if (this.Rooms[i] != null)
                {
                    this.Rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            if (this.Rooms.Any(r => r == null))
            {
                return true;
            }

            return false;
        }

        public string PrintAll()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var room in this.Rooms)
            {
                if (room == null)
                {
                    sb.AppendLine("Room empty");
                }
                else
                {
                    sb.AppendLine(room.ToString());
                }
            }

            return sb.ToString().Trim();
        }

        public string PrintRoom(int room)
        {
            return this.Rooms[room - 1].ToString();
        }
    }
}
