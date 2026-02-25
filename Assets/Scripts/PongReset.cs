using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongReset : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pong"))
        {
            collision.gameObject.transform.position = new Vector3(0, 0, collision.gameObject.transform.position.z);
        }
    }
}
