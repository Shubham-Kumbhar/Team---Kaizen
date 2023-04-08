using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField] int abilityType = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().typeOFWepon = abilityType;
            collision.GetComponent<PlayerMovement>().acilityActivated = true;
            Destroy(gameObject);
        }
    }
}
