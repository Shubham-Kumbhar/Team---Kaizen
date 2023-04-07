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
    
    [SerializeField]private float Health=100f;

      void Start()
      {
        ms=FindObjectOfType<MeteorSpawner>();
      }
      void Update()
      {
        DistTravelled+=0.05f;
        text.text=score.ToString();
        Difficulty();
        if(Health<=0) 
            noOfLives--;
        
        if(noOfLives==0)
        SceneManager.LoadScene("GameOver");
      }
      void Difficulty()
      {
        if(DistTravelled>=100)
        ms.spawnInterval=1.5f;
        else if(DistTravelled>=200)
        spawner1.SetActive(true);
        else if(DistTravelled>=300)
        spawner2.SetActive(true);


      }
      

}