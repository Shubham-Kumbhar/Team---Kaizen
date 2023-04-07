using UnityEngine;
using System.Collections;

//enum MeteorSize{Small,Mid,Big};
public class Meteor: MonoBehaviour
{
    private string tag;
    public float damage;
    private float health=3f;
    private ScoreManager scoreManager;


    void Start()
    {
        tag=this.gameObject.tag;    
        scoreManager=FindObjectOfType<ScoreManager>();
    }
    void Update()
    {
        if(health<=0f)
        ScoreAdd();
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
        
    }
}