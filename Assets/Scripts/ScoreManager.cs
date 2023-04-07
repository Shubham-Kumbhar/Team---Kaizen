using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager: MonoBehaviour
{
    [SerializeField]private Text text;
    [SerializeField]private GameObject spawner1;
    [SerializeField]private GameObject spawner2;
    public float score;
    public float DistTravelled=0f;
    private Meteor meteor;
    [SerializeField]private int noOfLives=3;
    private MeteorSpawner ms;
    private float dt;
    
    [SerializeField]private float Health=100f;

      void Start()
      {
        ms=FindObjectOfType<MeteorSpawner>();
      }
      void Update()
      {
        DistTravelled+=0.05f;
        dt=DistTravelled;
        //text.text=score.ToString();
        Difficulty();
        if(Health<=0) 
            noOfLives--;
        
        if(noOfLives==0)
        SceneManager.LoadScene("GameOver");
      }
      void Difficulty()
      {
        if(DistTravelled>=100 && DistTravelled<=200)
        ms.spawnInterval=1.75f;
        
        if(DistTravelled>200 && DistTravelled<=300){
        spawner1.SetActive(true);
        ms.spawnInterval=1.5f;}
        if(DistTravelled>300){
        spawner2.SetActive(true);
        ms.spawnInterval=1.25f;
        }
      }
      void SpawnAbilities()
      {
        if(dt==100)
        SpawnA1();
        if(dt==200)
        SpawnA2();
        if(dt==300)
        SpawnA3();
        if(dt==400){
        SpawnA4();
        dt-=400f;
      }
      }

}