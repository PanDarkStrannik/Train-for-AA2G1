using UnityEngine;

namespace Scripts.Gameplay.Interactive
{
    [RequireComponent(typeof(BoxCollider))]
    public class TriggerZone : MonoBehaviour
    {
        [SerializeField] private Vector3 size;
        [SerializeField] private Color gizmosColor;
        [SerializeReference] private BoxCollider boxCollider;

        public delegate void OnEnterEventHelper(GameObject enterObjects);
        public event OnEnterEventHelper EnterEvent;

        public delegate void OnExitEventHelper(GameObject enterObjects);
        public event OnExitEventHelper ExitEvent;


        private void Start()
        {
            boxCollider.isTrigger = true;
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = gizmosColor;
            boxCollider.size = size;
            Gizmos.DrawCube(gameObject.transform.position, transform.TransformVector(boxCollider.size));
        }

        private void OnTriggerEnter(Collider other)
        {
            EnterEvent?.Invoke(other.gameObject);
        }

        private void OnTriggerExit(Collider other)
        {           
            ExitEvent?.Invoke(other.gameObject);
        }
    }
}