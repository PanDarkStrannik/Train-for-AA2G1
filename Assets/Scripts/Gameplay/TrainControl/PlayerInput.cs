// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Gameplay/TrainControl/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""14963ba8-4c80-4ba2-99cf-6f4209281f07"",
            ""actions"": [
                {
                    ""name"": ""MoveDirection"",
                    ""type"": ""Value"",
                    ""id"": ""e192d05f-ad1f-4ecb-ac9c-67a6515ea00c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KeyboardInput"",
                    ""id"": ""c1ba5358-df51-4347-ae74-086b2e3b8429"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""154eac91-e138-4fd4-bf18-fc990c390d61"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2ef99861-c19b-4088-b875-be204e4d6ac8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""04597d14-5f85-45e4-adb4-cf237360be64"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2867cdd4-d8d8-48ac-9a29-766b4e2a37fb"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PointerController"",
                    ""id"": ""135553bf-1dd6-4922-b0dc-d2c622f01c01"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ff0bd08c-accc-4bb4-ab07-68bbdbf34bf3"",
                    ""path"": ""<Pointer>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MobileControl"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a44d865b-528d-4153-8a27-168cbb07792e"",
                    ""path"": ""<Pointer>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""MobileControl"",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0db5b45e-7d65-4b92-b2c0-dcb2c4baaf0d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""93c217ba-c877-4156-9dc0-a54a90a3e3d5"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveDirection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""CameraRotation"",
            ""id"": ""36b087f8-341e-4975-a563-6fe4d4be24b0"",
            ""actions"": [
                {
                    ""name"": ""CameraRotation"",
                    ""type"": ""Value"",
                    ""id"": ""c57f04b9-94dc-4e39-a525-e63580d68282"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""cdf4c283-bf3f-4482-93bc-ba6850503384"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0f000fdb-8392-4887-81e7-5e5f7976e7da"",
                    ""path"": ""<Pointer>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard;MobileControl"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""aeb5136f-7ce8-439b-af08-89f17cf3bd69"",
                    ""path"": ""<Pointer>/delta/y"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""MouseAndKeyboard;MobileControl"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33de1d8b-2a1e-43a7-aee8-6b094f72147c"",
                    ""path"": ""<Pointer>/delta/x"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": ""MouseAndKeyboard;MobileControl"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7851c785-69bb-4e46-93cb-62dd6c47cea7"",
                    ""path"": ""<Pointer>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard;MobileControl"",
                    ""action"": ""CameraRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""MobileControl"",
            ""bindingGroup"": ""MobileControl"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Sensor>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_MoveDirection = m_Move.FindAction("MoveDirection", throwIfNotFound: true);
        // CameraRotation
        m_CameraRotation = asset.FindActionMap("CameraRotation", throwIfNotFound: true);
        m_CameraRotation_CameraRotation = m_CameraRotation.FindAction("CameraRotation", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_MoveDirection;
    public struct MoveActions
    {
        private @PlayerInput m_Wrapper;
        public MoveActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveDirection => m_Wrapper.m_Move_MoveDirection;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @MoveDirection.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveDirection;
                @MoveDirection.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveDirection;
                @MoveDirection.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnMoveDirection;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveDirection.started += instance.OnMoveDirection;
                @MoveDirection.performed += instance.OnMoveDirection;
                @MoveDirection.canceled += instance.OnMoveDirection;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);

    // CameraRotation
    private readonly InputActionMap m_CameraRotation;
    private ICameraRotationActions m_CameraRotationActionsCallbackInterface;
    private readonly InputAction m_CameraRotation_CameraRotation;
    public struct CameraRotationActions
    {
        private @PlayerInput m_Wrapper;
        public CameraRotationActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @CameraRotation => m_Wrapper.m_CameraRotation_CameraRotation;
        public InputActionMap Get() { return m_Wrapper.m_CameraRotation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraRotationActions set) { return set.Get(); }
        public void SetCallbacks(ICameraRotationActions instance)
        {
            if (m_Wrapper.m_CameraRotationActionsCallbackInterface != null)
            {
                @CameraRotation.started -= m_Wrapper.m_CameraRotationActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.performed -= m_Wrapper.m_CameraRotationActionsCallbackInterface.OnCameraRotation;
                @CameraRotation.canceled -= m_Wrapper.m_CameraRotationActionsCallbackInterface.OnCameraRotation;
            }
            m_Wrapper.m_CameraRotationActionsCallbackInterface = instance;
            if (instance != null)
            {
                @CameraRotation.started += instance.OnCameraRotation;
                @CameraRotation.performed += instance.OnCameraRotation;
                @CameraRotation.canceled += instance.OnCameraRotation;
            }
        }
    }
    public CameraRotationActions @CameraRotation => new CameraRotationActions(this);
    private int m_MouseAndKeyboardSchemeIndex = -1;
    public InputControlScheme MouseAndKeyboardScheme
    {
        get
        {
            if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
            return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
        }
    }
    private int m_MobileControlSchemeIndex = -1;
    public InputControlScheme MobileControlScheme
    {
        get
        {
            if (m_MobileControlSchemeIndex == -1) m_MobileControlSchemeIndex = asset.FindControlSchemeIndex("MobileControl");
            return asset.controlSchemes[m_MobileControlSchemeIndex];
        }
    }
    public interface IMoveActions
    {
        void OnMoveDirection(InputAction.CallbackContext context);
    }
    public interface ICameraRotationActions
    {
        void OnCameraRotation(InputAction.CallbackContext context);
    }
}
