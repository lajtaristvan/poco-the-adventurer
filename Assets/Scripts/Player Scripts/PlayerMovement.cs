using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : CharacterMovement
{
    private float moveX, moveY;

    private void FixedUpdate()
    {
        moveX = Input.GetAxisRaw(TagManager.HORIZONTAL_AXIS);
        moveY = Input.GetAxisRaw(TagManager.VERTICAL_AXIS);        

        HandleMovement(moveX, moveY);
    }
}
