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
        public static decimal[] Goals(decimal[] spending, decimal[] last, float income, float CurrentSavings, float goals) {
            decimal[] savings = new decimal[6];
            for (int i = 0; i < 6; i++){
                decimal diff = spending[i] - last[i];
                if (diff < 0) { 
                    diff *= -1;        
                }
                savings[i] = diff;
        }
            
            return savings;
        }

        
 }
    }