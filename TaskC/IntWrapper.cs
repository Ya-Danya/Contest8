using System;

public class IntWrapper
{
    private int number;

    public int Number
    {
        get { return number; }
    }

    public IntWrapper(int number)
    {
        this.number = number;
    }

    public uint FindNumberLength()
    {
        int n = number;
        uint count = 0;
        do
        {
            n = n % 10;
            count++;
        } while (n>=0);
        return (count);
    }
}
