using System;

namespace LemmaSharp
{
    [Serializable()]
    class RuleWeighted : IComparable<RuleWeighted>
    {
        #region Private Variables

        private LemmaRule lrRule;
        private double dWeight;

        #endregion

        #region Constructor(s) & Destructor(s)

        public RuleWeighted(LemmaRule lrRule, double dWeight)
        {
            this.lrRule = lrRule;
            this.dWeight = dWeight;
        }

        #endregion

        #region Public Properties

        public LemmaRule Rule
        {
            get { return lrRule; }
        }

        public double Weight
        {
            get { return dWeight; }
        }

        #endregion

        #region Essential Class Functions (comparing objects, eg.: for sorting)

        public int CompareTo(RuleWeighted rl)
        {
            if (dWeight < rl.dWeight) return 1;
            if (dWeight > rl.dWeight) return -1;
            if (lrRule.Id < rl.lrRule.Id) return 1;
            if (lrRule.Id > rl.lrRule.Id) return -1;
            return 0;
        }

        #endregion

        #region Output & Serialization Functions

        public override string ToString()
        {
            return lrRule.ToString() + dWeight.ToString("(0.00%)");
        }

        #endregion
    }
}