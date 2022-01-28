namespace Exercises.Classes
{
    public class HomeworkAssignment
    {

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            this.PossibleMarks = possibleMarks;
            this.SubmitterName = submitterName;
        }
        public int EarnedMarks { get; set; }

        
        public int PossibleMarks { get; private set; }

        
        public string SubmitterName { get; private set; }


        public string LetterGrade
        {
            get
            {
                if (((decimal)this.EarnedMarks / (decimal)this.PossibleMarks) * 100 > 90)
                {
                    return "A";
                }
                else if (((decimal)this.EarnedMarks / (decimal)this.PossibleMarks) * 100 > 80)
                {
                    return "B";
                }
                else if (((decimal)this.EarnedMarks / (decimal)this.PossibleMarks) * 100 > 70)
                {
                    return "C";
                }
                else if (((decimal)this.EarnedMarks / (decimal)this.PossibleMarks) * 100 > 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
           
            
                
            





        }
       
    }

    
}
