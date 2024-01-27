using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerTeleportTool : MonoBehaviour
{
    public InputActionReference action;
    public Transform target1;
    public Transform target2;

    private bool isTeleporting = false;
    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) => 
        {
            StartTeleport();
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartTeleport()
    {
        if (!isTeleporting)
        {
            isTeleporting = true;

            if (transform.position == target1.position)
            {
                TeleportTo(target2.position);
            }
            else
            {
                TeleportTo(target1.position);
            }

            isTeleporting = false;
        }
    }

    void TeleportTo(Vector3 pos)
    {
        transform.position = pos;
    }
}
