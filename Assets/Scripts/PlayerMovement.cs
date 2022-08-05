using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float acceleration = 0;
    string lastKeyPressed = "";
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up, -3f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up, 3f);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            // Trigger Shout Event!
        }
        AccelerateTortoise();
    }

    void AccelerateTortoise()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (lastKeyPressed == "X"){
               acceleration += 6f;
            }
            lastKeyPressed = "Z";
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            if (lastKeyPressed == "Z")
            {
                acceleration += 6f;
            }
            lastKeyPressed = "X";
        }

        if (acceleration > 0)
        {
            this.transform.Translate(Vector3.forward * 0.1f);
        }

        acceleration = acceleration - 1f < 0 ? 0 : acceleration - 1f;
        //Debug.Log("Aceleração: " + acceleration);
    }
}
