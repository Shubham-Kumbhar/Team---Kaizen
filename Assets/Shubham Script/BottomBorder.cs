using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomBorder : MonoBehaviour
{
    private ScoreManager sm;
    void Start() {
        {
            sm=FindObjectOfType<ScoreManager>();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {   
            other.gameObject.SetActive(false);
            sm.score+=5f;
    }
}
