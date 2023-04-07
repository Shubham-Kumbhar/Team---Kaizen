using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager: Monobehaviour
{
    [SerializeField]private Text text;
    public float DistTravelled;
    private Meteor meteor;
    [SerializeField]private int noOfLives=3;
    //[SerializeField]private bool IsAlive=true;
    [SerializeField]private float Health=100f;

      void Start()
      {

      }
      void Update()
      {
        DistTravelled++;
        text.text=(DistTravelled*10f).ToString();
        if(Health<=0) 
            noOFLives--;
        
        if(noOfLives=0)
        SceneManager.LoadScene("GameOver");
      }
      private void OnCollisionEnter(Collision other) {
        meteor=other.GetComponent<Meteor>();
        health-=meteor.damage;
      }

}