namespace Scripts.Singltons.Helpfull
{
    public class GameTime
    {

        private float time;


        public delegate void GameTimeHelper(float value);
        public event GameTimeHelper TimeChangeEvent;

        public delegate void GameTimeNullHelper();
        public event GameTimeNullHelper TimeEnd;

        public GameTime()
        {
            time = 0;
            TimeChangeEvent?.Invoke(time);
        }

    

        public void Change(float value)
        {
            time += value;
            if (time <= 0)
            {
                time = 0;
                TimeEnd?.Invoke();
            }
            TimeChangeEvent?.Invoke(time);
        }       

        public void RefreshTime()
        {
            time = 0;
            TimeChangeEvent?.Invoke(time);
        }

    }
}