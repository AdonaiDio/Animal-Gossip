using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    float timer = 0;
    void FixedUpdate()
    {
        timer += Time.deltaTime;
        StartCoroutine(ChangeDirection());
        transform.Translate(Vector3.forward * 0.1f);
    }

   IEnumerator ChangeDirection()
    {
        float rndRot;
        if(Random.Range(1,3) % 2 == 0)
        {
            rndRot = 3f;
        }
        else
        {
            rndRot = -3f;
        }

        if (timer >= 2f)
        {
            ///Debug.Log("Virou");
            timer = 0;
            for (int i = 0; i < Random.Range(0,31); i++)
            {
                Debug.Log(i);
                transform.Rotate(Vector3.up, rndRot);
                yield return new WaitForFixedUpdate();
            }
        }
    }
}
