# UpSave
public float[] ExpectedSavings(float[] spending, float income, float CurrentSavings) 
        {
            float[3] expectedSaving;
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
            if (avgExpectedSavings >= goals){
                return  null;
            }
            for (int i = 0; i < PossibleSavers.Count - 1; i++) {
                                   
            }

        }
