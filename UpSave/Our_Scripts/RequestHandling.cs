using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UpSave.Our_Scripts
{
    public class RequestHandling
    {   
        public static decimal[] ExpectedSavings(decimal[] spending, decimal income, decimal CurrentSavings, int time) 
        {
            decimal[] expectedSaving = new decimal[3];
            for (int i = 0; i < 3; i++) {
                decimal saving = time * income - time * spending[i];
                expectedSaving[i] = CurrentSavings + saving;
            }

            return expectedSaving;
        }

        public static decimal[] DecToFloat(float[] a)
        {
            decimal[] b = new decimal[a.Length];
            int count = 0;
            foreach(float s in a)
            {
                b[count++] = (decimal)s;
            }
            return b;
        }
        public static Dictionary<string, float> Goals(Dictionary<string, float> lastMonth, Dictionary<string, float> spending, float income, float CurrentSavings, float goals) {
            Dictionary<string, float> PossibleSavers = new Dictionary<string, float>();
            //float[3] buffer;
            for (int i = 0; i < lastMonth.Count; i++) {
                for (int j = 0; j < spending.Count; j++) {
                    string last = lastMonth.Keys.ElementAt<string>(i);
                    string average = spending.Keys.ElementAt<string>(j);
                    if (last.CompareTo(average) == 0 && (last.CompareTo("Dues") != 0)) {
                        float difference = lastMonth.Values.ElementAt<float>(i) - spending.Values.ElementAt<float>(j);
                        if (difference < 0) {
                            difference = difference * -1;
                        }
                        PossibleSavers.Add(last, difference);
                    }
                }
            }
            float avgExpectedSavings = (float)decimal.ToDouble(ExpectedSavings(DecToFloat(spending.Values.ToArray()), (decimal)income, (decimal)CurrentSavings, 12)[1]);
            PossibleSavers = PossibleSavers.Keys.OrderBy(k => k).ToDictionary(k => k, k => PossibleSavers[k]); 
            return PossibleSavers;
        }


        }

        
 }