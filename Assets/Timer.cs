using Scripts.Singltons;
using System.Collections;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float startTime;
    [SerializeField] private float timeChangePeriod;
    [SerializeReference] private GameObject endMenu;
    [SerializeReference] private GameObject mainUI;

    private void Awake()
    {
        GameData.GetInstance().GameTime.TimeEnd += GameEnd;
    }

    private void OnDestroy()
    {
        GameData.GetInstance().GameTime.TimeEnd -= GameEnd;
    }

    private void Start()
    {
        endMenu.SetActive(false);
        GameData.GetInstance().GameTime.Change(startTime);
        StartCoroutine(TimerCounter());
    }

    private IEnumerator TimerCounter()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(timeChangePeriod);
            GameData.GetInstance().GameTime.Change(-timeChangePeriod);
        }
    }

    private void GameEnd()
    {
        StopCoroutine(TimerCounter());
        endMenu.SetActive(true);
        mainUI.SetActive(false);
        PauseController.GetInstance().Pause();
    }
    
}
