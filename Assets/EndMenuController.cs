using Scripts.Singltons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenuController : MonoBehaviour
{
    public void Restart()
    {
        PauseController.GetInstance().Restart();
        PauseController.GetInstance().Resume();
        GameData.GetInstance().PointCounter.RefreshPoints();
    }

    public void Quit()
    {
        PauseController.GetInstance().Quit();
    }
}
