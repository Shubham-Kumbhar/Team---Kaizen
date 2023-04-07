using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager: MonoBehaviour
{
    [SerializeField]private Text text;
    [SerializeField]private GameObject spawner1;
    [SerializeField]private GameObject spawner2;
    [SerializeField]private GameObject[] abilitiesIcon;
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
        SpawnAbilities();
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
        Vector3 x1=Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
        Vector3 x2=Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
        if(dt%100==0)
        Instantiate(abilitiesIcon[Random.Range(0,abilitiesIcon.Length-1)],new Vector3(Random.Range(x1.x,x2.x),5.08f), Quaternion.identity);
      }
      }

