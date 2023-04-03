using System;

namespace MyDaysOnEarth
{
    internal class DaysCounter
    {
        private DateOnly DateOfBirth;
        public DaysCounter() 
        {
            DateOfBirth = DateOnly.FromDateTime(DateTime.Today).AddDays(-1);
        }

        public DaysCounter(DateTime dateTimeOfBirth) 
        {
            DateOfBirth = DateOnly.FromDateTime(dateTimeOfBirth);
        }

        public DaysCounter(DateOnly dateOfBirth)
        {
            DateOfBirth = dateOfBirth;
        }

        public DaysCounter(int yearOfBirth, int monthOfBirth, int dayOfBirth)
        {
            if (yearOfBirth < 1 || yearOfBirth > 9999)
            {
                return;
            }
            if (monthOfBirth < 1 || monthOfBirth > 12)
            {
                return;
            }

            try
            {
                DateOfBirth = new DateOnly(yearOfBirth, monthOfBirth, dayOfBirth);
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal int Count()
        {
            if (DateOfBirth.CompareTo(DateOnly.FromDateTime(DateTime.Today)) >= 0)
            {
                return 0;
            }
            return DateOnly.FromDateTime(DateTime.Today).DayNumber - DateOfBirth.DayNumber;
        }
    }
}
