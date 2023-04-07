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
       
        
    }
    void SpawnBullets()
    {
        
    }
    void SpreadBullets()
    {
       
    }
    
}