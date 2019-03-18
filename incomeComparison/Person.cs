namespace incomeComparison
{
    public class Person
    {

    
      //Build Field///
        private int _hourlyRate;
        private int _hoursPerWeek;

        //Constructor//
        public Person(int hourlyRate, int hoursPerWeek)
        {
            _hoursPerWeek = hourlyRate;
            _hoursPerWeek = hoursPerWeek;
        }
         //Properties//
        public int HourlyRate
        {
            get { return _hourlyRate; }
            set { _hourlyRate = value; }
        }
        public int HoursPerWeek
        {
            get { return _hoursPerWeek; }
            set { _hoursPerWeek = value; }
        }
        //Methods//
        public int WeeklySalary()
        {
            return _hourlyRate * _hoursPerWeek;
        
        }
    }
}