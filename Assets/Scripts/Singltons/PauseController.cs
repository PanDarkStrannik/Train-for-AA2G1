using UnityEngine;
using UnityEngine.SceneManagement;


namespace Scripts.Singltons
{
    public class PauseController
    {
        private static PauseController instance;
        private static object synchRoot = new object();

        public bool IsPaused { get; private set; }

        protected PauseController()
        {
            IsPaused = false;
        }

        public static PauseController GetInstance()
        {
            lock (synchRoot)
            {
                if (instance == null)
                {
                    instance = new PauseController();
                }
            }
            return instance;
        }



        /// <summary>
        /// Поставить на паузу
        /// </summary>
        public void Pause()
        {
            if (!IsPaused)
            {
                Time.timeScale = 0;
                IsPaused = true;
            }
        }

        /// <summary>
        /// Снять с паузы
        /// </summary>
        public void Resume()
        {
            if (IsPaused)
            {
                Time.timeScale = 1;
                IsPaused = false;
            }
        }

        /// <summary>
        /// Выход из игры
        /// </summary>
        public void Quit()
        {
            Application.Quit();
        }

        /// <summary>
        /// Рестарт сцены
        /// </summary>
        public void Restart()
        {
            var scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.buildIndex);
        }

    }

}