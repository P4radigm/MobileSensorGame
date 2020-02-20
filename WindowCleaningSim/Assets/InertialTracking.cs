// GENERATED AUTOMATICALLY FROM 'Assets/InertialTracking.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InertialTracking : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InertialTracking()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InertialTracking"",
    ""maps"": [
        {
            ""name"": ""SensorControls"",
            ""id"": ""b948d0d4-4202-4879-9285-6048465d1b00"",
            ""actions"": [
                {
                    ""name"": ""Gyroscope"",
                    ""type"": ""Value"",
                    ""id"": ""1c13e508-6db5-4540-bdaa-3e8065831dde"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""de741778-6962-4e62-a22e-807f5507a097"",
                    ""path"": ""<Gyroscope>/angularVelocity"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gyroscope"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // SensorControls
        m_SensorControls = asset.FindActionMap("SensorControls", throwIfNotFound: true);
        m_SensorControls_Gyroscope = m_SensorControls.FindAction("Gyroscope", throwIfNotFound: true);
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

    // SensorControls
    private readonly InputActionMap m_SensorControls;
    private ISensorControlsActions m_SensorControlsActionsCallbackInterface;
    private readonly InputAction m_SensorControls_Gyroscope;
    public struct SensorControlsActions
    {
        private @InertialTracking m_Wrapper;
        public SensorControlsActions(@InertialTracking wrapper) { m_Wrapper = wrapper; }
        public InputAction @Gyroscope => m_Wrapper.m_SensorControls_Gyroscope;
        public InputActionMap Get() { return m_Wrapper.m_SensorControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SensorControlsActions set) { return set.Get(); }
        public void SetCallbacks(ISensorControlsActions instance)
        {
            if (m_Wrapper.m_SensorControlsActionsCallbackInterface != null)
            {
                @Gyroscope.started -= m_Wrapper.m_SensorControlsActionsCallbackInterface.OnGyroscope;
                @Gyroscope.performed -= m_Wrapper.m_SensorControlsActionsCallbackInterface.OnGyroscope;
                @Gyroscope.canceled -= m_Wrapper.m_SensorControlsActionsCallbackInterface.OnGyroscope;
            }
            m_Wrapper.m_SensorControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Gyroscope.started += instance.OnGyroscope;
                @Gyroscope.performed += instance.OnGyroscope;
                @Gyroscope.canceled += instance.OnGyroscope;
            }
        }
    }
    public SensorControlsActions @SensorControls => new SensorControlsActions(this);
    public interface ISensorControlsActions
    {
        void OnGyroscope(InputAction.CallbackContext context);
    }
}
