class Lasagna
{
    private int _expectedOvenTime = 40;

    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        int expectedOvenTime = _expectedOvenTime;
        return expectedOvenTime;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int elapsedTime)
    {
        return ExpectedMinutesInOven() - elapsedTime;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int elapsedTime)
    {
        return PreparationTimeInMinutes(layers) + elapsedTime;
    }
}
