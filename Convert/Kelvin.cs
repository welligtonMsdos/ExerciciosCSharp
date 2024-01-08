namespace BradescoTest.Convert;

public class Kelvin : IConvertTemperatures
{
    public string Convert(double temperaturesValue)
    {
        var result = temperaturesValue + 273.15;

        return result.ToString("0.##");
    }
}
