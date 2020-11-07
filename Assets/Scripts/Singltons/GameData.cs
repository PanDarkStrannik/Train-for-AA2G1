using Scripts.Singltons.Helpfull;

namespace Scripts.Singltons
{
    public class GameData
    {
        private static GameData instance;
        private static object synchRoot = new object();


        public GameTime GameTime { get; private set; }

        public PointCounter PointCounter { get; private set; }


        protected GameData()
        {
            GameTime = new GameTime();
            PointCounter = new PointCounter();
        }

        public static GameData GetInstance()
        {
            lock (synchRoot)
            {
                if (instance == null)
                {
                    instance = new GameData();
                }
            }
            return instance;
        }


    }
}