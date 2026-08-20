using System.Globalization;

namespace jp.lilxyzw.shadercore
{
    public static class NumParser
    {
        public static float Float(string value) => float.Parse(value, CultureInfo.InvariantCulture);
        public static double Double(string value) => double.Parse(value, CultureInfo.InvariantCulture);
        public static int Int(string value) => int.Parse(value, CultureInfo.InvariantCulture);
        public static long Long(string value) => long.Parse(value, CultureInfo.InvariantCulture);
        public static uint UInt(string value) => uint.Parse(value, CultureInfo.InvariantCulture);
        public static ulong ULong(string value) => ulong.Parse(value, CultureInfo.InvariantCulture);

        public static string ToString(float value) => value.ToString(CultureInfo.InvariantCulture);
        public static string ToString(double value) => value.ToString(CultureInfo.InvariantCulture);
        public static string ToString(int value) => value.ToString(CultureInfo.InvariantCulture);
        public static string ToString(long value) => value.ToString(CultureInfo.InvariantCulture);
        public static string ToString(uint value) => value.ToString(CultureInfo.InvariantCulture);
        public static string ToString(ulong value) => value.ToString(CultureInfo.InvariantCulture);

        public static bool Float(string value, out float o) => float.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
        public static bool Double(string value, out double o) => double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
        public static bool Int(string value, out int o) => int.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
        public static bool Long(string value, out long o) => long.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
        public static bool UInt(string value, out uint o) => uint.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
        public static bool ULong(string value, out ulong o) => ulong.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out o);
    }
}
