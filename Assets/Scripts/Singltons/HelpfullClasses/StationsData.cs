using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Scripts.Gameplay.Interactive
{
    public class StationsData : MonoBehaviour
    {
        [SerializeReference] private List<StationLogic> stationLogics;

        public List<Transform> StationsTransforms { get; private set; }

        private void Awake()
        {
            StationsTransforms = new List<Transform>();
            for (int i = 0; i < stationLogics.Count; i++)
            {
                StationsTransforms.Add(stationLogics[i].StationPosition);
            }
        }

        public Transform GetNext(Transform currentStation)
        {
            if (StationsTransforms.Contains(currentStation))
            {
                var newIndex = StationsTransforms.IndexOf(currentStation)+1;
                if (newIndex < StationsTransforms.Count)
                {
                    return StationsTransforms[newIndex];
                }
                return currentStation;
            }
            return StationsTransforms[0];
        }

    }
}