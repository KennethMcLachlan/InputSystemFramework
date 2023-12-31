//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Scripts/Inputs/PlayerInputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""256a8896-b6b8-40e3-8fd9-9f61707e2248"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""dfb264f6-292f-4d99-9af3-4f97e8164df6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""67bd8c8f-4438-4576-844f-ffb54c6e034c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CamEscape"",
                    ""type"": ""Button"",
                    ""id"": ""79e185ba-7b8f-4c87-9990-6ca9f8ae5e71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""26a38a13-bb78-4614-b8f7-810c9220cde7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b278c4f5-6c9b-4535-af74-f83093d8d04c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1b287cd1-3b06-4915-b634-0b25375b69da"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ab2af42-bdbb-47f0-914f-1b957ea2bed3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c0e67018-4e13-4267-9dee-56ec6e8f7aab"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""85aabb86-adb8-468b-8754-826514cf41b3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press(pressPoint=1.401298E-45)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7c65e6d-e74a-4ff7-867c-516c451889d2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CamEscape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""126278be-64e0-487e-ad7d-8c2dfc6b91b7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""a40fb85c-8b46-4a9f-90e7-db061603e4ba"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""4f4ba262-c744-4d75-bb4e-061c6fa2de0e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""53d823c4-8d78-46c9-baf3-27b23a9b1cac"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1557c9e-45e0-4429-b8db-24847e6f5e2a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d32c4f26-8d42-4676-9901-ee6d717d9d31"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8a425c25-95eb-4594-8e3f-5ba7d07a4251"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d121b2af-c2c0-465c-84a0-0b9dd1352cc2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""2dd4f8e3-9f67-47c7-9972-2529548a9587"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""ea7978f2-bd2f-4e08-9d42-3e78bae996b9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f015ed21-2962-498b-862e-3fdd0f4874a6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""bbe0e234-527e-4a2a-b97f-d7eb7246adf3"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""78b674bf-9525-4377-8c70-aabc7083cd53"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Forklift"",
            ""id"": ""0c130d71-8f5a-4513-82ea-c2aa7426f71a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3e475373-9418-4578-903a-abd5becf92f0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Lift"",
                    ""type"": ""Value"",
                    ""id"": ""7e2180a6-8f5d-4390-a33d-b7cda75e34c8"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1107780c-65c2-4d2b-ab4a-330cf7c85368"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""6cedb2c0-5f58-4423-92ec-efab469da133"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""58ab6d98-9ba0-4f25-8c32-caca0e9def0d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lift"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""455af66e-d0b3-41f0-889a-963e8eb349af"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f5d89829-ca55-431c-a595-7d5cc0ebff1d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3f4bb0c5-5e28-4705-b708-c5ca5c4ed040"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""df19765e-858f-43f5-a570-459b504ae31c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6589287c-743b-4a08-baaa-509f1d7ae659"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Crate"",
            ""id"": ""577319fd-76d6-4d7b-a0e0-9bc215c3917e"",
            ""actions"": [
                {
                    ""name"": ""Destroy"",
                    ""type"": ""Button"",
                    ""id"": ""6229cbed-92f9-457d-821f-d5700d015b05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1a27595-8f99-46c8-ad5a-a7bbc4367d79"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Hold(duration=1,pressPoint=0.1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Destroy"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_CamEscape = m_Player.FindAction("CamEscape", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_Movement = m_Drone.FindAction("Movement", throwIfNotFound: true);
        m_Drone_Rotate = m_Drone.FindAction("Rotate", throwIfNotFound: true);
        // Forklift
        m_Forklift = asset.FindActionMap("Forklift", throwIfNotFound: true);
        m_Forklift_Movement = m_Forklift.FindAction("Movement", throwIfNotFound: true);
        m_Forklift_Lift = m_Forklift.FindAction("Lift", throwIfNotFound: true);
        // Crate
        m_Crate = asset.FindActionMap("Crate", throwIfNotFound: true);
        m_Crate_Destroy = m_Crate.FindAction("Destroy", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_CamEscape;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @CamEscape => m_Wrapper.m_Player_CamEscape;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @CamEscape.started += instance.OnCamEscape;
            @CamEscape.performed += instance.OnCamEscape;
            @CamEscape.canceled += instance.OnCamEscape;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @CamEscape.started -= instance.OnCamEscape;
            @CamEscape.performed -= instance.OnCamEscape;
            @CamEscape.canceled -= instance.OnCamEscape;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private List<IDroneActions> m_DroneActionsCallbackInterfaces = new List<IDroneActions>();
    private readonly InputAction m_Drone_Movement;
    private readonly InputAction m_Drone_Rotate;
    public struct DroneActions
    {
        private @PlayerInputActions m_Wrapper;
        public DroneActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Drone_Movement;
        public InputAction @Rotate => m_Wrapper.m_Drone_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void AddCallbacks(IDroneActions instance)
        {
            if (instance == null || m_Wrapper.m_DroneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DroneActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Rotate.started += instance.OnRotate;
            @Rotate.performed += instance.OnRotate;
            @Rotate.canceled += instance.OnRotate;
        }

        private void UnregisterCallbacks(IDroneActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Rotate.started -= instance.OnRotate;
            @Rotate.performed -= instance.OnRotate;
            @Rotate.canceled -= instance.OnRotate;
        }

        public void RemoveCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDroneActions instance)
        {
            foreach (var item in m_Wrapper.m_DroneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DroneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // Forklift
    private readonly InputActionMap m_Forklift;
    private List<IForkliftActions> m_ForkliftActionsCallbackInterfaces = new List<IForkliftActions>();
    private readonly InputAction m_Forklift_Movement;
    private readonly InputAction m_Forklift_Lift;
    public struct ForkliftActions
    {
        private @PlayerInputActions m_Wrapper;
        public ForkliftActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Forklift_Movement;
        public InputAction @Lift => m_Wrapper.m_Forklift_Lift;
        public InputActionMap Get() { return m_Wrapper.m_Forklift; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ForkliftActions set) { return set.Get(); }
        public void AddCallbacks(IForkliftActions instance)
        {
            if (instance == null || m_Wrapper.m_ForkliftActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ForkliftActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Lift.started += instance.OnLift;
            @Lift.performed += instance.OnLift;
            @Lift.canceled += instance.OnLift;
        }

        private void UnregisterCallbacks(IForkliftActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Lift.started -= instance.OnLift;
            @Lift.performed -= instance.OnLift;
            @Lift.canceled -= instance.OnLift;
        }

        public void RemoveCallbacks(IForkliftActions instance)
        {
            if (m_Wrapper.m_ForkliftActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IForkliftActions instance)
        {
            foreach (var item in m_Wrapper.m_ForkliftActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ForkliftActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ForkliftActions @Forklift => new ForkliftActions(this);

    // Crate
    private readonly InputActionMap m_Crate;
    private List<ICrateActions> m_CrateActionsCallbackInterfaces = new List<ICrateActions>();
    private readonly InputAction m_Crate_Destroy;
    public struct CrateActions
    {
        private @PlayerInputActions m_Wrapper;
        public CrateActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Destroy => m_Wrapper.m_Crate_Destroy;
        public InputActionMap Get() { return m_Wrapper.m_Crate; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrateActions set) { return set.Get(); }
        public void AddCallbacks(ICrateActions instance)
        {
            if (instance == null || m_Wrapper.m_CrateActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CrateActionsCallbackInterfaces.Add(instance);
            @Destroy.started += instance.OnDestroy;
            @Destroy.performed += instance.OnDestroy;
            @Destroy.canceled += instance.OnDestroy;
        }

        private void UnregisterCallbacks(ICrateActions instance)
        {
            @Destroy.started -= instance.OnDestroy;
            @Destroy.performed -= instance.OnDestroy;
            @Destroy.canceled -= instance.OnDestroy;
        }

        public void RemoveCallbacks(ICrateActions instance)
        {
            if (m_Wrapper.m_CrateActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICrateActions instance)
        {
            foreach (var item in m_Wrapper.m_CrateActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CrateActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CrateActions @Crate => new CrateActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnCamEscape(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IForkliftActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLift(InputAction.CallbackContext context);
    }
    public interface ICrateActions
    {
        void OnDestroy(InputAction.CallbackContext context);
    }
}
