namespace Exercises.Classes
{
    public class Television
    {

        public bool IsOn { get; private set; } 
        public int CurrentChannel { get; private set; } = 3;
        public int CurrentVolume { get; private set; } = 2;

        public void TurnOff()
        {
            if (IsOn == true)
            {
                IsOn = false;
            }
        }

        public void TurnOn()
        {
            if(IsOn == false)
            {
                IsOn = true;
                CurrentChannel = 3;
                CurrentVolume = 2;
            }
                

        }

       public void ChangeChannel(int newChannel)
        {
            if (IsOn == true && (3 <= newChannel && newChannel <= 18))
            {
                CurrentChannel = newChannel;
            }
        }

        public void ChannelUp()
        {
            if(IsOn == true && (3 <= CurrentChannel && CurrentChannel < 18))
            {
                CurrentChannel = CurrentChannel + 1;
            }
            else if(IsOn == true && CurrentChannel >= 18)
            {
                CurrentChannel = 3;
            }
            else
            {

            }
        }

        public void ChannelDown()
        {
            if (IsOn == true && (3 < CurrentChannel && CurrentChannel <= 18))
            {
                CurrentChannel = CurrentChannel - 1;
            }
            else if (IsOn == true && CurrentChannel == 3)
            {
                CurrentChannel = 18;
            }
            else
            {

            }
        }

        public void RaiseVolume()
        {
            if(IsOn == true && (0 <= CurrentVolume && CurrentVolume < 10))
            {
                CurrentVolume = CurrentVolume + 1;
            }
            
        }

        public void LowerVolume()
        {
            if(IsOn == true && (0 < CurrentVolume && CurrentVolume <= 10))
            {
                CurrentVolume = CurrentVolume - 1;
            }
        }
    }
}
