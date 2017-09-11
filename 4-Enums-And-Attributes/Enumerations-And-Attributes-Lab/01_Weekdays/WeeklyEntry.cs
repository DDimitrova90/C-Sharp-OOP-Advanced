namespace _01_Weekdays
{
    using System;

    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        private WeekDay weekDay;

        public WeeklyEntry(string weekday, string notes)
        {
            Enum.TryParse(weekday, out this.weekDay);
            this.Notes = notes;
        }

        public WeekDay Weekday
        {
            get { return this.weekDay; }
            private set { this.weekDay = value; }
        }

        public string Notes { get; private set; }

        public int CompareTo(WeeklyEntry otherEntry)
        {
            int result = this.Weekday.CompareTo(otherEntry.Weekday);

            if (result == 0)
            {
                result = this.Notes.CompareTo(otherEntry.Notes);
            }

            return result;
        }

        public override string ToString()
        {
            return $"{this.Weekday} - {this.Notes}";
        }
    }
}
