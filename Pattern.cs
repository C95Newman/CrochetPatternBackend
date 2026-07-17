using CrochetPatternBackend;

namespace CrochetPatternBackend
{
    public enum PatternCategory
    {
        Apparel_General = 0,
        Apparel_Shirt,
        Apparel_Bottoms,
        Toy_Stuffy,
        Toy_Other

    };
    public class Pattern
    {
        public List<String> steps = new List<String>();

        public string patternName = "";

        public int yarnWeight = 4;

        public PatternCategory category;
        public static string getJSON(Pattern pattern)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(pattern);
        }

    }
    
}
