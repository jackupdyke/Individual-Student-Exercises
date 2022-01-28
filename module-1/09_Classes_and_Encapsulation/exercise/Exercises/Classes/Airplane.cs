namespace Exercises.Classes
{
    public class Airplane
    {

        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        public string PlaneNumber { get; private set; }
        public int TotalFirstClassSeats { get; private set; }
        public int BookedFirstClassSeats { get; private set; }
        public int AvailableFirstClassSeats
        {
            get
            {
               return  TotalFirstClassSeats - BookedFirstClassSeats;
            }
        }
        public int TotalCoachSeats { get; private set; }
        public int BookedCoachSeats { get; private set; }
        public int AvailableCoachSeats
        {
            get
            {
                return TotalCoachSeats - BookedCoachSeats;
            }
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if(forFirstClass && totalNumberOfSeats <= AvailableFirstClassSeats)
            {
                BookedFirstClassSeats = totalNumberOfSeats; 
                if(AvailableFirstClassSeats >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(forFirstClass == false && totalNumberOfSeats <= AvailableCoachSeats)
            {
                BookedCoachSeats = totalNumberOfSeats;
                if(AvailableCoachSeats >= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            
        }

    }
}
