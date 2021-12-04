using static SgSeason2.Lib.Enums;

namespace SgSeason2.Lib
{
    public class ChemistryResult
    {
        public int ChemistryValue { get; set; }

        public Chemistry Chemistry { get; set; }

        public override bool Equals(object? obj)
        {
            var currentObj = obj as ChemistryResult;
            if ( currentObj.ChemistryValue.Equals(this.ChemistryValue) && currentObj.Chemistry.Equals(this.Chemistry)) return true;
            return false;
        }

        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                hash = hash * 13 + ChemistryValue.GetHashCode();
                hash = hash * 13 + Chemistry.GetHashCode();                
                return hash;
            }
        }
    }
}
