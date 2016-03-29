namespace C_Sharp_Hmwk2
{
    internal class CylnCord<T>
    {
        private T m_r;
        private T m_theta;
        private T m_z;
        private void cylnCopy(ref CylnCord<T> cc) { m_r = cc.m_r;m_theta = cc.m_theta;m_z = cc.m_z;return; }
        

    }
}