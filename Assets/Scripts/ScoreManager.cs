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
    
    [SerializeField]private float Health=100f;

      void Start()
      {

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
      

}