using Scripts.Singltons;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.UI
{
    public class ButtonScript : MonoBehaviour
    {
        [SerializeReference] private GameObject collectButton;

        private delegate void OnCollectEventHelper(int points);

        private static event OnCollectEventHelper CollectEvent;

        private int collectPoints=0;

        private void Awake()
        {
            collectButton.SetActive(false);
            CollectEvent += CollectEventListener;
        }

        private void OnDestroy()
        {
            CollectEvent -= CollectEventListener;
        }

        public static void CanCollect(int points)
        {
            CollectEvent(points);   
        }

        private void CollectEventListener(int points)
        {
            collectPoints = points;
            collectButton.SetActive(true);
        }

        public void CollectPoints()
        {
            GameData.GetInstance().PointCounter.Add(collectPoints);
            collectPoints = 0;
            collectButton.SetActive(false);
        }
    }
}