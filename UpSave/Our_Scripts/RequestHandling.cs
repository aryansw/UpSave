using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class RequestHandling
    {   
        public float[] ExpectedSavings(float[] spending, float income, float CurrentSavings) 
        {
            float[] expectedSaving = new float[3];
            for (int i = 0; i < 3; i++) {
                float saving = 12 * income - 12 * spending[i];
                expectedSaving[i] = CurrentSavings + saving;
            }

            return expectedSaving;
        }
        public Dictionary<string, float> Goals(Dictionary<string, float> lastMonth, Dictionary<string, float> spending, float income, float CurrentSavings, float goals) {
            Dictionary<string, float> PossibleSavers = new Dictionary<string, float>();
            //float[3] buffer;
            for (int i = 0; i < lastMonth.Count; i++) {
                for (int j = 0; j < spending.Count; j++) {
                    string last = lastMonth.Keys.ElementAt<i>;
                    string average = spending.Keys.ElementAt<j>;
                    if (last.CompareTo(average) == 0 && (last.CompareTo("Dues") != 0)) {
                        float difference = lastMonth.Values.ElementAt<i> - spending.Values.ElementAt<j>;
                        if (difference < 0) {
                            difference = difference * -1;
                        }
                        PossibleSavers.Add(last, difference);
                    }
                }
            }
            float avgExpectedSavings = ExpectedSavings(spending.Values, income, CurrentSavings)[1];
            PossibleSavers = PossibleSavers.Keys.OrderBy(k => k).ToDictionary(k => k, k => PossibleSavers[k]); 
            return PossibleSavers;
        }


        }

        
    }
}   