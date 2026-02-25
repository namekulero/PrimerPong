using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 8f;
    [SerializeField] private bool isPaddle1;

    void Update()
    {
        float movement;

        if (isPaddle1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

            transform.position += new Vector3(0, movement * moveSpeed * Time.deltaTime, 0);
    }
}
