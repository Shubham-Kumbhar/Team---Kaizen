using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    [SerializeField] float speed;
    void Update()
    {
        transform.Translate(Vector2.up* speed);
    }

    void setActiveFalse()
    {
        gameObject.SetActive(false);
        
    }
}
