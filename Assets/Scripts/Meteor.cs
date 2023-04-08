using UnityEngine;
using System.Collections;

//enum MeteorSize{Small,Mid,Big};
public class Meteor: MonoBehaviour
{
    private string tag;
    [SerializeField]private float speed;
    [SerializeField]private Sprite deadHeart;
    [SerializeField]private GameObject destroyAnim;
    private GameObject player;
    public float damage;
    public float probability;
    public float health=1f;
    private ScoreManager scoreManager;


    private void OnEnable()
    {
        if(!this.gameObject.CompareTag("Big"))
        health = 1f;
        else
        health=3f;
    }
    void Start()
    {
        tag =this.gameObject.tag;    
        scoreManager=FindObjectOfType<ScoreManager>();
        player=GameObject.FindWithTag("Player");
        Classify();
        //Invoke("DestroyMeteor", 5f);
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
            case "meteriod": damage=10f; health=1f;probability=0.5f; break;
            case "Mid": damage=20f; health=1f;probability=0.4f; break;
            case "Big": damage=30f; health=3f;probability=0.1f;break;
            default: break;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("bullet"))
        {
            health--;
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.CompareTag("Player"))
        {
        gameObject.SetActive(false);
        other.gameObject.GetComponent<PlayerHealth>().noOfLives--;
        other.gameObject.GetComponent<PlayerHealth>().liveHearts[other.gameObject.GetComponent<PlayerHealth>().noOfLives].GetComponent<SpriteRenderer>().sprite=deadHeart;
        }
    }
    void DestroyMeteor()
    {
        Instantiate(destroyAnim, this.transform.position, Quaternion.identity);
        //soundPlay
        gameObject.SetActive(false);
        //Destroy(this.gameObject);
    }
    void ScoreAdd()
    {
        switch(tag)
        {
            case "meteriod": scoreManager.score+=10f; break;
            case "Mid": scoreManager.score+=10f; break;
            case "Big": scoreManager.score+=20f; break;
            default: break;
        }
        
    }
}