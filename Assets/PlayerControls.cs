//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""433b7076-959d-49b3-9014-0705c2b1f182"",
            ""actions"": [
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""29f4a009-6c59-4d85-acbc-a1db51d644df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightPunch"",
                    ""type"": ""Button"",
                    ""id"": ""a35f775f-6301-48bc-a8ec-1729f9f874c8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LightKick"",
                    ""type"": ""Button"",
                    ""id"": ""ba03dc73-aa0e-405b-9f24-e9893f5552a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MediumPunch"",
                    ""type"": ""Button"",
                    ""id"": ""9cd46ece-a8a7-4ed8-bac6-4842ed49d159"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MediumKick"",
                    ""type"": ""Button"",
                    ""id"": ""42ed3966-6093-4b39-b178-49f1a3f01652"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b43f9430-fde3-4d5c-8f2a-f557904c6ca8"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""171cccaf-3b78-41c4-a786-f6c5a299aae6"",
                    ""path"": ""<DualShockGamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MediumPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""819ebe83-73c7-4923-9566-a01d47b23267"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MediumKick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d61228ec-7385-4f93-a6d7-5740954ee33b"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e86443b3-1052-4f74-ac32-aea3a90fe732"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LightPunch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_MoveUp = m_Gameplay.FindAction("MoveUp", throwIfNotFound: true);
        m_Gameplay_LightPunch = m_Gameplay.FindAction("LightPunch", throwIfNotFound: true);
        m_Gameplay_LightKick = m_Gameplay.FindAction("LightKick", throwIfNotFound: true);
        m_Gameplay_MediumPunch = m_Gameplay.FindAction("MediumPunch", throwIfNotFound: true);
        m_Gameplay_MediumKick = m_Gameplay.FindAction("MediumKick", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private List<IGameplayActions> m_GameplayActionsCallbackInterfaces = new List<IGameplayActions>();
    private readonly InputAction m_Gameplay_MoveUp;
    private readonly InputAction m_Gameplay_LightPunch;
    private readonly InputAction m_Gameplay_LightKick;
    private readonly InputAction m_Gameplay_MediumPunch;
    private readonly InputAction m_Gameplay_MediumKick;
    public struct GameplayActions
    {
        private @PlayerControls m_Wrapper;
        public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveUp => m_Wrapper.m_Gameplay_MoveUp;
        public InputAction @LightPunch => m_Wrapper.m_Gameplay_LightPunch;
        public InputAction @LightKick => m_Wrapper.m_Gameplay_LightKick;
        public InputAction @MediumPunch => m_Wrapper.m_Gameplay_MediumPunch;
        public InputAction @MediumKick => m_Wrapper.m_Gameplay_MediumKick;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void AddCallbacks(IGameplayActions instance)
        {
            if (instance == null || m_Wrapper.m_GameplayActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Add(instance);
            @MoveUp.started += instance.OnMoveUp;
            @MoveUp.performed += instance.OnMoveUp;
            @MoveUp.canceled += instance.OnMoveUp;
            @LightPunch.started += instance.OnLightPunch;
            @LightPunch.performed += instance.OnLightPunch;
            @LightPunch.canceled += instance.OnLightPunch;
            @LightKick.started += instance.OnLightKick;
            @LightKick.performed += instance.OnLightKick;
            @LightKick.canceled += instance.OnLightKick;
            @MediumPunch.started += instance.OnMediumPunch;
            @MediumPunch.performed += instance.OnMediumPunch;
            @MediumPunch.canceled += instance.OnMediumPunch;
            @MediumKick.started += instance.OnMediumKick;
            @MediumKick.performed += instance.OnMediumKick;
            @MediumKick.canceled += instance.OnMediumKick;
        }

        private void UnregisterCallbacks(IGameplayActions instance)
        {
            @MoveUp.started -= instance.OnMoveUp;
            @MoveUp.performed -= instance.OnMoveUp;
            @MoveUp.canceled -= instance.OnMoveUp;
            @LightPunch.started -= instance.OnLightPunch;
            @LightPunch.performed -= instance.OnLightPunch;
            @LightPunch.canceled -= instance.OnLightPunch;
            @LightKick.started -= instance.OnLightKick;
            @LightKick.performed -= instance.OnLightKick;
            @LightKick.canceled -= instance.OnLightKick;
            @MediumPunch.started -= instance.OnMediumPunch;
            @MediumPunch.performed -= instance.OnMediumPunch;
            @MediumPunch.canceled -= instance.OnMediumPunch;
            @MediumKick.started -= instance.OnMediumKick;
            @MediumKick.performed -= instance.OnMediumKick;
            @MediumKick.canceled -= instance.OnMediumKick;
        }

        public void RemoveCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameplayActions instance)
        {
            foreach (var item in m_Wrapper.m_GameplayActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameplayActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnLightPunch(InputAction.CallbackContext context);
        void OnLightKick(InputAction.CallbackContext context);
        void OnMediumPunch(InputAction.CallbackContext context);
        void OnMediumKick(InputAction.CallbackContext context);
    }
}
