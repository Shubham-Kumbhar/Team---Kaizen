using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    [SerializeField] int abilityType = 0;

void Update()
{
    transform.Translate(Vector2.down*0.01f);
}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerMovement>().typeOFWepon = abilityType;
            collision.GetComponent<PlayerMovement>().abilityActivte =true;
            Destroy(gameObject);
        }
    }
}
