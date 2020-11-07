using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Scripts.Singltons;

namespace Scripts.UI
{
    public class PointsViewer : MonoBehaviour
    {
        [Tooltip("UI колличества очков (в виде текста)")]
        [SerializeField] private Text pointText;

        private void Awake()
        {
            GameData.GetInstance().PointCounter.PointChangeEvent += ViewPoint;
        }

        private void ViewPoint(int value)
        {
            pointText.text = value.ToString();
        }

        private void OnDestroy()
        {
            GameData.GetInstance().PointCounter.PointChangeEvent -= ViewPoint;
        }
    }
}