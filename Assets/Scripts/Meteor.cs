using UnityEngine;
using System.Collections;

//enum MeteorSize{Small,Mid,Big};
public class Meteor: MonoBehaviour
{
    private string tag;
    private GameObject player;
    public float damage;
    private float health=3f;
    private ScoreManager scoreManager;


    void Start()
    {
        tag=this.gameObject.tag;    
        scoreManager=FindObjectOfType<ScoreManager>();
        player=GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if(health<=0f)
        ScoreAdd();
        DodgeMeteor();
    }
    void Classify()
    {
        switch(tag)
        {
            case "Small": damage=10f; health=1f; break;
            case "Mid": damage=20f; health=1f;break;
            case "Big": damage=30f; health=3f;break;
            default: break;
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        health--;
    }
    void ScoreAdd()
    {
        switch(tag)
        {
            case "Small": scoreManager.score+=10f; break;
            case "Mid": scoreManager.score+=10f; break;
            case "Big": scoreManager.score+=20f; break;
            default: break;
        }
    }
    void DodgeMeteor()
    {
        if(this.transform.position.y<=player.transform.position.y)
        scoreManager.score+=5f;
    }
}