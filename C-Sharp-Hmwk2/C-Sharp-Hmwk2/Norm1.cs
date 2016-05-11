using System.Collections.Generic;

public class Norm1
{
    public static float Norm (ref List<CylnCord> List)
    {
        float norm1 = 0;
        foreach (CylnCord C in List)
        {
            norm1 += ~C;
        }
        return norm1;
    }
}
