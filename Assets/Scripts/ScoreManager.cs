using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager: MonoBehaviour
{
    [SerializeField]private Text text;
    public float score;
    public float DistTravelled;
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
        DistTravelled++;
        text.text=score.ToString();
        if(Health<=0) 
            noOfLives--;
        
        if(noOfLives==0)
        SceneManager.LoadScene("GameOver");
      }
      void Difficulty()
      {
        if(DistTravelled>=100)
        ms.spawnInterval=1.5f;
        
      }
      

}