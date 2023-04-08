using UnityEngine;
using System.Collections;

//enum MeteorSize{Small,Mid,Big};
public class Meteor: MonoBehaviour
{
    private string tag;
    [SerializeField]private float speed;
    [SerializeField]private Sprite deadHeart;
    private GameObject player;
    public float damage;
    public float probability;
    private float health=1f;
    private ScoreManager scoreManager;


    void Start()
    {

        tag=this.gameObject.tag;    
        scoreManager=FindObjectOfType<ScoreManager>();
        player=GameObject.FindWithTag("Player");
        Classify();
        Invoke("DestroyMeteor", 5f);
        //Destroy(this.gameObject,7f);
        
    }
    void Update()
    {
        if(health<=0f){
        ScoreAdd();
        DestroyMeteor();
        }
        //DodgeMeteor();
        Movement();
        
    }
    void Movement()
    {
        transform.Translate(Vector2.down*speed);
    }
    void Classify()
    {
        switch(tag)
        {
            case "Small": damage=10f; health=1f;probability=0.5f; break;
            case "Mid": damage=20f; health=1f;probability=0.4f; break;
            case "Big": damage=30f; health=3f;probability=0.1f;break;
            default: break;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("bullet")){
        health--;
        Destroy(other.gameObject);}
        if(other.gameObject.CompareTag("Player")){
        gameObject.SetActive(false);
       // Destroy(this);

        other.gameObject.GetComponent<PlayerHealth>().noOfLives--;
        other.gameObject.GetComponent<PlayerHealth>().liveHearts[other.gameObject.GetComponent<PlayerHealth>().noOfLives].GetComponent<SpriteRenderer>().sprite=deadHeart;
    }}
    void DestroyMeteor()
    {
        //animPlay
        //soundPlay
        gameObject.SetActive(false);
        //Destroy(this.gameObject);
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
    // void DodgeMeteor()
    // {
    //     if(this.transform.position.y<=player.transform.position.y){
        
    //     return;
    // }}
    
}