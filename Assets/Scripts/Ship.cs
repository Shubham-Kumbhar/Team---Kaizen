using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    // Start is called before the first frame update
    public int price=0;
    private GameObject player;
    private Sprite sprite;
    private ScoreManager scoreManager;

    void Start()
    {
        player=GameObject.FindWithTag("Player");
        scoreManager=FindObjectOfType<ScoreManager>();
        sprite=GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if(scoreManager.coins>=price)
        {
            scoreManager.coins-=price;
            player.GetComponent<SpriteRenderer>().sprite=sprite;
        }
    }
    public void Equip()
    {
         player.GetComponent<SpriteRenderer>().sprite=sprite;
    }
}
