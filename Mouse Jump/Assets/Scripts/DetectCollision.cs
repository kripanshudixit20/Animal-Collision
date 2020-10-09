using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    Vector3 newScale;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.CompareTag(collision.gameObject.tag))
        {
            Debug.Log($"{gameObject.tag} collided with {collision.gameObject.tag}");
            newScale = gameObject.transform.localScale;
            newScale.x *= 2;
            newScale.y *= 2;
            transform.localScale = newScale;
            Destroy(collision.gameObject);
        }
       
    }
}
