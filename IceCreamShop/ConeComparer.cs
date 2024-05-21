namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            if (x.Cost - y.Cost > 0)
            {
                return 1;
            }
            else if (x.Cost.Equals(y.Cost))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}