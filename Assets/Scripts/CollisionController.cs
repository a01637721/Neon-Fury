using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            Debug.Log("Enter");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            Debug.Log("Stay");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            Debug.Log("Exit");
        }
    }
    */

    private void onTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obs")
        {
            Debug.Log("test");
        }
    }

}

