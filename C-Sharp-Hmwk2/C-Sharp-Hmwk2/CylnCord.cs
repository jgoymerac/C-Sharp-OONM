
using System;
public class CylnCord 
{
    private float m_r;
    private float m_theta;
    private float m_z;
    private void cylnCopy(ref CylnCord cc) { m_r = cc.m_r; m_theta = cc.m_theta; m_z = cc.m_z; return; }


    public CylnCord() { m_r = 0; m_theta = 0; m_z = 0; }
    public CylnCord(float r, float theta, float z) { m_r = r; m_theta = theta; m_z = z; }
    public static CylnCord operator -(CylnCord R) {
        R.m_theta += (float)Math.PI;
        R.m_z = -(R.m_z);

        return R; }
    public static float operator ~(CylnCord R)
    {
        float mag;
        mag = (float)Math.Sqrt(R.m_z * R.m_z + R.m_r * R.m_r);
        return mag;
    }
    public static CylnCord operator !(CylnCord R)
    {
        R.m_theta += (float)Math.PI;
        return R;
    }
    public float this[int i]
    {
       get
        {
            if (i == 0)
            {
                return this.m_r;
            }
            else if (i == 1)
            {
                return this.m_theta;
            }
            else
            {
                return m_z;
            }
        }
        set
        {
            if (i == 0)
            {
                this.m_r= value;
            }
            else if (i == 1)
            {
               this.m_theta=value;
            }
            else
            {
              m_z=value;
            }

        }
        
    }

    public static bool operator <(CylnCord L, CylnCord R)
    {
        float lhs, rhs;
        lhs = ~L;
        rhs = ~R;
        if (lhs < rhs)
        {
            return true;
        }
        return false;
    }

    public static bool operator >(CylnCord L, CylnCord R)
    {
       float lhs, rhs;
        lhs = ~L;
        rhs = ~R;
        if (lhs > rhs)
        {
            return true;
        }
        return false;
    }
    public static bool operator ==(CylnCord L, CylnCord R)
    {
        if(L.m_r==R.m_r && L.m_theta==R.m_theta && L.m_z == R.m_z)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(CylnCord L, CylnCord R)
    {
        if (L.m_r == R.m_r && L.m_theta == R.m_theta && L.m_z == R.m_z)
        {
            return false;
        }
        return true;
    }
    public string cartCord()
    {
        string cart;
        float xcord, ycord;
        xcord = (float)(this.m_r * Math.Cos((double)m_theta));
        ycord = (float)(this.m_r * Math.Sin((double)m_theta));
        cart = "(" + xcord + ", " + ycord + ", " + this.m_z + ")";
        return cart;
    }

    public override string ToString()
    {
        return "(" + m_r + ", " + m_theta + ", " + m_z +")";
    }
}