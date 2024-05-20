namespace DiamondPlaza.Services.Helpers
{
    public static class CodeHelper
    {
        public static string GeneratorCode(string prefix, int number)
        {
            return prefix + "-" + number.ToString();
        }
        public static int StringToInt(string code)
        {
            return int.Parse(code.Split("-")[1]);
        }
    }
}
