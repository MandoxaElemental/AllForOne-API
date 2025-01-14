using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllForOne_API.Services
{
    public class GuessItHardServices
    {
        public List<string> hardAnswer = new();
        public Random rng = new Random();
        public List<string> YourAnswerHard(string yourInput){
            int hardMode = rng.Next(1, 101);
            int intGuess;
            bool boolGuess = int.TryParse(yourInput, out intGuess);

            if (boolGuess)
            {

                    //hard Mode
                    if (intGuess == hardMode)
                    {
                        hardAnswer.Add($"Wow, you actually did it! I was thinking of {hardMode}!");
                        return hardAnswer;

                    }
                    else if (intGuess >= 101)
                    {
                        hardAnswer.Add($"Buddy, you chose Hard Mode. Keep your guess within the Parameters");
                        return hardAnswer;
                    }
                    else if (intGuess > hardMode)
                    {
                        hardAnswer.Add($"You're too high - The Answer is {hardMode}");
                        return hardAnswer;
                    }
                    else
                    {
                        hardAnswer.Add($"You're too low - The Answer is {hardMode}");
                        return hardAnswer;
                    }

                }
                hardAnswer.Add("ERROR");
                return hardAnswer;
        }
    }
}