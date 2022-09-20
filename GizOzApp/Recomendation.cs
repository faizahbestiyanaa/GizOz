using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizOzApp
{
    public abstract class Recommendation
    {
        public int calories { get; set; }
        public void showRecommendation(int calories)
        {
            this.calories = calories;
        }
        public void calcCalories() { }
    }
}
