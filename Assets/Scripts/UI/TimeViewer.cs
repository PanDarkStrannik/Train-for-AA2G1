using Scripts.Singltons;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Scripts.UI
{
    public class TimeViewer : MonoBehaviour
    {
        [Tooltip("UI времени (в виде текста)")]
        [SerializeField] private Text timeText;

        private void Awake()
        {
            GameData.GetInstance().GameTime.TimeChangeEvent += ViewTime;
        }

        private void ViewTime(float value)
        {
            timeText.text = value.ToString();
        }

        private void OnDestroy()
        {
            GameData.GetInstance().GameTime.TimeChangeEvent -= ViewTime;
        }
    }

}
