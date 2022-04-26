using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportationManager : MonoBehaviour
{
    [SerializeField] private InputActionAsset actionAsset;
    [SerializeField] private XRRayInteractor rayInteractor;
    private InputAction thumbstick;

    // Start is called before the first frame update
    void Start()
    {
        var activate = actionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Activate");
        activate.Enable();
        activate.performed += OnTeleportActivate;

        var cancel = actionAsset.FindActionMap("XRI LeftHand").FindAction("Teleport Mode Cancel");
        cancel.Enable();
        cancel.performed += OnTeleportCancel;
        
        thumbstick = actionAsset.FindActionMap("XRI LeftHand").FindAction("Move");
        thumbstick.Enable();
    }

    private void OnTeleportActivate(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void OnTeleportCancel(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }
// Update is called once per frame
    void Update()
    {
        
    }
}
