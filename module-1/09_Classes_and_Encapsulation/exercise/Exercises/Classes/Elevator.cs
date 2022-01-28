namespace Exercises.Classes
{
    public class Elevator
    {

        public Elevator(int numberOfLevels)
        {
            NumberOfLevels = numberOfLevels;
            CurrentLevel = 1;
        }

        public int CurrentLevel { get; private set; } 
        public int NumberOfLevels { get; private set; }
        public bool DoorIsOpen { get; private set; }


        public void OpenDoor()
        {
            if(DoorIsOpen == false)
            {
                DoorIsOpen = true;
            }
            
        }

        public void CloseDoor()
        {
            if(DoorIsOpen)
            {
                DoorIsOpen = false;
            }
        }

        public void GoUp(int desiredFloor)
        {
            if(DoorIsOpen == false && (desiredFloor <= NumberOfLevels && desiredFloor > CurrentLevel))
            {
                CurrentLevel = desiredFloor;
            }
        }

        public void GoDown(int desiredFloor)
        {
            if(DoorIsOpen == false && (desiredFloor <= NumberOfLevels && desiredFloor >= 1 && desiredFloor < CurrentLevel))
            {
                CurrentLevel = desiredFloor;
            }
        }
    }
}
