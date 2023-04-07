using UnityEngine;
using System.Collections;

public class LaserShooting: MonoBehaviour
{
    [SerializeField]private GameObject bullet;
    [SerializeField]private float ForceMagnitude;
    private ScoreManager scoreManager;
    void Start()
    {
        scoreManager=FindObjectOfType<ScoreManager>();
    }
    void Update()
    {
        if(scoreManager.DistTravelled>=300f)
        Invoke("SpawnBullets",5f);
        
    }
    void SpawnBullets()
    {
        GameObject gb=Instantiate(bullet,this.transform.position,this.transform.rotation);
        gb.GetComponent<Rigidbody>().AddForce(this.transform.forward*ForceMagnitude,ForceMode.Impulse);
    }
    void SpreadBullets()
    {
        GameObject gb=Instantiate(bullet,this.transform.position,this.transform.rotation);
    }
    
}