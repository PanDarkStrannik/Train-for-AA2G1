using Scripts.Gameplay.Interactive;
using UnityEngine;
using UnityEngine.AI;

public class TrainMovement : MonoBehaviour
{
    [SerializeReference] private NavMeshAgent agent;
    [SerializeReference] private StationsData stationsData;
    [SerializeField] private float minDistanceToStation=3f;

    [SerializeField] private float maxSpeed = 3f;
    [SerializeField] private float minSpeed = 0f;
    [SerializeField] private float speedChangeValue = 1f;

    [SerializeField] private float maxAcceleration = 1f;
    [SerializeField] private float minAcceleration = 0f;
    [SerializeField] private float accelerationChangeValue=1f;


    public delegate void TrainStopEventHelper();
    public event TrainStopEventHelper TrainStopEvent;

    private PlayerInput input;

    private Transform currentTarget;


    private void Awake()
    {
        input = new PlayerInput();

        agent.speed = minSpeed;
        agent.acceleration = minAcceleration;

        input.Move.MoveDirection.performed += delegate { Move(); };

    }

    private void Start()
    {
        currentTarget = stationsData.StationsTransforms[0];
        agent.SetDestination(currentTarget.position);
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }


    private void Update()
    {  
        if(agent.remainingDistance < minDistanceToStation)
        { 
            currentTarget = stationsData.GetNext(currentTarget);
            agent.SetDestination(currentTarget.position);
        }
    }


    private void Move()
    {
        var inputValue = input.Move.MoveDirection.ReadValue<Vector2>().y;

        Debug.Log(inputValue);

        var newAcceleration = agent.acceleration + inputValue * accelerationChangeValue;
        newAcceleration = Mathf.Clamp(newAcceleration, minAcceleration, maxAcceleration);
        agent.acceleration = newAcceleration;


        var newSpeed = agent.speed + inputValue * speedChangeValue;
        newSpeed = Mathf.Clamp(newSpeed, minSpeed, maxSpeed);
        agent.speed = newSpeed;

        if (agent.acceleration == minAcceleration && agent.speed == minSpeed)
        {
            agent.velocity = Vector3.zero;
        }



        if (agent.velocity == Vector3.zero)
        {
            TrainStopEvent?.Invoke();
        }

    }



}
