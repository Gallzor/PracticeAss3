using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAss3
{
    public class Score
    {
        public Score()
        {
            ScoreValue = 0;
        }

        public Score(int defaultScore)
        {
            ScoreValue = defaultScore;
        }

        public int? ScoreValue
        {
          get; set;
        }

        public void AddPoints(int scoreValue)
        {
            ScoreValue += scoreValue;
        }
        public void AddPoints(int scoreValue, int multyply)
        {
            ScoreValue += scoreValue * multyply;
        }

        public void RemovePoints(int scoreValue)
        {
            ScoreValue -= scoreValue;
        }

        public void ResetScore()
        {
            ScoreValue = null;
        }
    }
}
