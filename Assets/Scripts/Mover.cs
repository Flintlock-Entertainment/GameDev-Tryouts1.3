using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


/**
 * This component moves its object up/down
 * as long as the up/down arrow key is held pressed.
 */
public class Mover : MonoBehaviour
{

    [Tooltip("Movement speed in meters per second")] [SerializeField] float speed = 1f;

    [SerializeField]
    InputAction moveUp = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);

    void OnEnable() 
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

    void OnDisable()  
    {
        moveUp.Disable();
        moveDown.Disable();
        moveLeft.Disable();
        moveRight.Disable();
    }

    void Update() 
    {
        if (moveUp.IsPressed()) {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
        } else if (moveDown.IsPressed()) {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
        } else if (moveLeft.IsPressed()) {
            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
        } else if (moveRight.IsPressed()) {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        } 
    }
}


