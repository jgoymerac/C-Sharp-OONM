
    public class CylnCord<T>
    {
        private T m_r;
        private T m_theta;
        private T m_z;

    public float r { get; internal set; }

    private void cylnCopy(ref CylnCord<T> cc) { m_r = cc.m_r;m_theta = cc.m_theta;m_z = cc.m_z;return; }
        public CylnCord(T r, T theta, T z) { m_r = r; m_theta = theta; m_z = z; }
        public void set(T r,T theta, T z) { m_r = r; m_theta = theta; m_z = z; }        
}