using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_API.Services
{
    public class GuessItMediumServices
    {
        public List<string> mediumAnswer = new();
        public Random rng = new Random();
        public List<string> YourAnswerMedium(string yourInput){
            int mediumMode = rng.Next(1, 51);
            int intGuess;
            bool boolGuess = int.TryParse(yourInput, out intGuess);

            if (boolGuess)
            {

                    //medium Mode
                    if (intGuess == mediumMode)
                    {
                        mediumAnswer.Add($"Wow, you actually did it! I was thinking of {mediumMode}!");
                        return mediumAnswer;

                    }
                    else if (intGuess >= 51)
                    {
                        mediumAnswer.Add($"Buddy, you chose Medium Mode. Keep your guess within the Parameters");
                        return mediumAnswer;
                    }
                    else if (intGuess > mediumMode)
                    {
                        mediumAnswer.Add($"You're too high - The Answer is {mediumMode}");
                        return mediumAnswer;
                    }
                    else
                    {
                        mediumAnswer.Add($"You're too low - The Answer is {mediumMode}");
                        return mediumAnswer;
                    }

                }
                return mediumAnswer;
        }
    }
}