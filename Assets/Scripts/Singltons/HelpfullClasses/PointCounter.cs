namespace Scripts.Singltons.Helpfull
{
    public class PointCounter
    {

        private int points;      


        public delegate void PointCounterHelper(int value);
        public event PointCounterHelper PointChangeEvent;


        public PointCounter()
        {
            points = 0;
            PointChangeEvent?.Invoke(points);
        }


        public void Add(int value)
        {
            points += value;
            if (points < 0)
            {
                points = 0;
            }
            PointChangeEvent?.Invoke(points);
        }

        public void RefreshPoints()
        {
            points = 0;
            PointChangeEvent?.Invoke(points);
        }


    }
}
