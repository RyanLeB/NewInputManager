using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    // OnMove is called every Input Action
    // Note: OnMove is related to "Move" in the input system, if it is renamed to let's say "Movement", OnMove will have to change to OnMovement.
    void OnMove(InputValue movementValue)
    {
        // extracting player movement
        Vector2 movementVector2 = movementValue.Get<Vector2>();


        // make player move... 
        Vector3 movementVector;
        movementVector.x = movementVector2.x;
        movementVector.y = 0.0f;
        movementVector.z = movementVector2.y;
        gameObject.transform.Translate(movementVector);
        
        Debug.Log("Movement value: " + movementVector2);

    }




}
