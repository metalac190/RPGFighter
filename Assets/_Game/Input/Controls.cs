// GENERATED AUTOMATICALLY FROM 'Assets/_Game/Input/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Combat"",
            ""id"": ""1c1917e9-8d28-4a8a-a68f-7787dce0516f"",
            ""actions"": [
                {
                    ""name"": ""Attack01"",
                    ""type"": ""Button"",
                    ""id"": ""de677641-f9aa-4002-9803-d9b76d8e0751"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack02"",
                    ""type"": ""Button"",
                    ""id"": ""27a56768-4071-46c3-81ca-a4a20c6410da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack03"",
                    ""type"": ""Button"",
                    ""id"": ""d40e89d6-2f9b-4353-a756-ea6c6286e7b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack04"",
                    ""type"": ""Button"",
                    ""id"": ""fa6052ea-7f0d-483b-8f7c-1d3270e4e5e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""21e4ff68-d99e-4880-9481-b68daa1cd9df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSelectUp"",
                    ""type"": ""Button"",
                    ""id"": ""0eeb482e-8d20-48e5-8f61-8a896b35cb94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSelectDown"",
                    ""type"": ""Button"",
                    ""id"": ""ec21b4e5-a91d-434f-ba6a-340bdd4c72a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSelectLeft"",
                    ""type"": ""Button"",
                    ""id"": ""2fda3455-1b39-4908-b792-7a67cb4a1933"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveSelectRight"",
                    ""type"": ""Button"",
                    ""id"": ""f364b82d-f30e-4f41-8897-04c18e87e005"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4214b302-f96a-4d15-8718-8b8a8559c8f5"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Attack01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac88a03a-c897-4ea9-b94c-415e00bb8f5a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Attack02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a00ec592-7ab0-4788-9fd8-d20dde8e9f44"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Attack03"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59134ef3-1457-411a-9b1b-e5ac648668a9"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Attack04"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fb354d70-3ff5-4085-99f3-a812a611ac50"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20a973fd-96f7-4ed6-b59c-75f9de4a9200"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MoveSelectUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba5cc4ed-a236-4b0e-9a76-5fadb9e8edfe"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MoveSelectDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cd75963-b24e-4c00-9487-0c8a34d9b326"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MoveSelectLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1cd38d50-1f6b-4ef6-a4e5-7cc6d3cb3454"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""MoveSelectRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
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
        }
    ]
}");
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Attack01 = m_Combat.FindAction("Attack01", throwIfNotFound: true);
        m_Combat_Attack02 = m_Combat.FindAction("Attack02", throwIfNotFound: true);
        m_Combat_Attack03 = m_Combat.FindAction("Attack03", throwIfNotFound: true);
        m_Combat_Attack04 = m_Combat.FindAction("Attack04", throwIfNotFound: true);
        m_Combat_Pause = m_Combat.FindAction("Pause", throwIfNotFound: true);
        m_Combat_MoveSelectUp = m_Combat.FindAction("MoveSelectUp", throwIfNotFound: true);
        m_Combat_MoveSelectDown = m_Combat.FindAction("MoveSelectDown", throwIfNotFound: true);
        m_Combat_MoveSelectLeft = m_Combat.FindAction("MoveSelectLeft", throwIfNotFound: true);
        m_Combat_MoveSelectRight = m_Combat.FindAction("MoveSelectRight", throwIfNotFound: true);
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

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Attack01;
    private readonly InputAction m_Combat_Attack02;
    private readonly InputAction m_Combat_Attack03;
    private readonly InputAction m_Combat_Attack04;
    private readonly InputAction m_Combat_Pause;
    private readonly InputAction m_Combat_MoveSelectUp;
    private readonly InputAction m_Combat_MoveSelectDown;
    private readonly InputAction m_Combat_MoveSelectLeft;
    private readonly InputAction m_Combat_MoveSelectRight;
    public struct CombatActions
    {
        private @Controls m_Wrapper;
        public CombatActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Attack01 => m_Wrapper.m_Combat_Attack01;
        public InputAction @Attack02 => m_Wrapper.m_Combat_Attack02;
        public InputAction @Attack03 => m_Wrapper.m_Combat_Attack03;
        public InputAction @Attack04 => m_Wrapper.m_Combat_Attack04;
        public InputAction @Pause => m_Wrapper.m_Combat_Pause;
        public InputAction @MoveSelectUp => m_Wrapper.m_Combat_MoveSelectUp;
        public InputAction @MoveSelectDown => m_Wrapper.m_Combat_MoveSelectDown;
        public InputAction @MoveSelectLeft => m_Wrapper.m_Combat_MoveSelectLeft;
        public InputAction @MoveSelectRight => m_Wrapper.m_Combat_MoveSelectRight;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Attack01.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack01;
                @Attack01.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack01;
                @Attack01.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack01;
                @Attack02.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack02;
                @Attack02.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack02;
                @Attack02.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack02;
                @Attack03.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack03;
                @Attack03.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack03;
                @Attack03.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack03;
                @Attack04.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack04;
                @Attack04.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack04;
                @Attack04.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnAttack04;
                @Pause.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnPause;
                @MoveSelectUp.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectUp;
                @MoveSelectUp.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectUp;
                @MoveSelectUp.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectUp;
                @MoveSelectDown.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectDown;
                @MoveSelectDown.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectDown;
                @MoveSelectDown.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectDown;
                @MoveSelectLeft.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectLeft;
                @MoveSelectLeft.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectLeft;
                @MoveSelectLeft.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectLeft;
                @MoveSelectRight.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectRight;
                @MoveSelectRight.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectRight;
                @MoveSelectRight.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMoveSelectRight;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Attack01.started += instance.OnAttack01;
                @Attack01.performed += instance.OnAttack01;
                @Attack01.canceled += instance.OnAttack01;
                @Attack02.started += instance.OnAttack02;
                @Attack02.performed += instance.OnAttack02;
                @Attack02.canceled += instance.OnAttack02;
                @Attack03.started += instance.OnAttack03;
                @Attack03.performed += instance.OnAttack03;
                @Attack03.canceled += instance.OnAttack03;
                @Attack04.started += instance.OnAttack04;
                @Attack04.performed += instance.OnAttack04;
                @Attack04.canceled += instance.OnAttack04;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @MoveSelectUp.started += instance.OnMoveSelectUp;
                @MoveSelectUp.performed += instance.OnMoveSelectUp;
                @MoveSelectUp.canceled += instance.OnMoveSelectUp;
                @MoveSelectDown.started += instance.OnMoveSelectDown;
                @MoveSelectDown.performed += instance.OnMoveSelectDown;
                @MoveSelectDown.canceled += instance.OnMoveSelectDown;
                @MoveSelectLeft.started += instance.OnMoveSelectLeft;
                @MoveSelectLeft.performed += instance.OnMoveSelectLeft;
                @MoveSelectLeft.canceled += instance.OnMoveSelectLeft;
                @MoveSelectRight.started += instance.OnMoveSelectRight;
                @MoveSelectRight.performed += instance.OnMoveSelectRight;
                @MoveSelectRight.canceled += instance.OnMoveSelectRight;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get
        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
    public interface ICombatActions
    {
        void OnAttack01(InputAction.CallbackContext context);
        void OnAttack02(InputAction.CallbackContext context);
        void OnAttack03(InputAction.CallbackContext context);
        void OnAttack04(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMoveSelectUp(InputAction.CallbackContext context);
        void OnMoveSelectDown(InputAction.CallbackContext context);
        void OnMoveSelectLeft(InputAction.CallbackContext context);
        void OnMoveSelectRight(InputAction.CallbackContext context);
    }
}
