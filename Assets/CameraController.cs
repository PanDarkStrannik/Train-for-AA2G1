using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeReference] private Transform mainCamera;
    [SerializeField] private float SensX = 5;
    [SerializeField] private float SensY = 10;


    private float moveX, moveY;
    private Quaternion startRotation;
    private bool activeFreeLook=false;

    private PlayerInput input;

    private void Awake()
    {
        startRotation = mainCamera.rotation;
        input = new PlayerInput();

        input.CameraRotation.CameraRotation.performed += delegate
        {
            if (activeFreeLook)
            {
                Rotation(input.CameraRotation.CameraRotation.ReadValue<Vector2>());
            }
        };
    }

    private void OnEnable()
    {
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    private void Rotation(Vector2 rotation)
    {
        moveY = mainCamera.rotation.eulerAngles.x - rotation.y * SensY;
        moveX = mainCamera.rotation.eulerAngles.y + rotation.x * SensX; 

        mainCamera.rotation = Quaternion.Euler(moveY, moveX, 0);

    }

    public void ChangeLook()
    {
        activeFreeLook = !activeFreeLook;

        if (!activeFreeLook)
        {
            mainCamera.rotation = startRotation;
        }
    }

}
