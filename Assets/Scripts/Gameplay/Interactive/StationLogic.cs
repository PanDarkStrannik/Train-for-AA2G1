using Scripts.Singltons;
using Scripts.UI;
using UnityEngine;

namespace Scripts.Gameplay.Interactive
{
    public class StationLogic : MonoBehaviour
    {
        [SerializeReference] private TriggerZone triggerZone;
        [SerializeReference] private Transform stationPosition;
        [SerializeField] private int pointAdd=1;

        private bool alreadyCollect = false;

        public Transform StationPosition
        {
            get
            {
                return stationPosition;
            }
        }

        private void Awake()
        {
            triggerZone.EnterEvent += TrainEnter;
            triggerZone.ExitEvent += TrainExit;
        }

        private void OnDestroy()
        {
            triggerZone.EnterEvent -= TrainEnter;
            triggerZone.ExitEvent -= TrainExit;
        }

        private void TrainEnter(GameObject enterObject)
        {
            if(enterObject.CompareTag("Player"))
            {
                if (enterObject.GetComponentInChildren<TrainMovement>() != null)
                {
                    enterObject.GetComponentInChildren<TrainMovement>().TrainStopEvent += TrainStopEventListener;
                }
            }
        }

        private void TrainExit(GameObject exitObject)
        {
            if (exitObject.CompareTag("Player"))
            {
                if (exitObject.GetComponentInChildren<TrainMovement>() != null)
                {
                    exitObject.GetComponentInChildren<TrainMovement>().TrainStopEvent -= TrainStopEventListener;
                }
            }
        }

        private void TrainStopEventListener()
        {
            if (!alreadyCollect)
            {
                ButtonScript.CanCollect(pointAdd);
                alreadyCollect = true;
            }
        }




    }
}