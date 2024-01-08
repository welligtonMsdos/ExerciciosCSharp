namespace BradescoTest.Convert;

public class Fahrenheit : IConvertTemperatures
{
    public string Convert(double temperaturesValue)
    {
        var result = (temperaturesValue * 1.8) + 32;

        return result.ToString("0.##");
    }
}
