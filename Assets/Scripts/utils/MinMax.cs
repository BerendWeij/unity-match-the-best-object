public class MinMax
{
    public float Min;
    public float Max;

    public MinMax(float min, float max)
    {
        Min = min;
        Max = max;
    }

    /// <summary>
    /// Method for checking if a value is inbetween the Min and Max
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Contains(float value)
    {
        return value >= Min && value <= Max;
    }

}