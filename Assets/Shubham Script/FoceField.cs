using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoceField : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("meteriod"))
        {
            collision.gameObject.SetActive(false);
        }
       
    }
}
