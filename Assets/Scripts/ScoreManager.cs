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
    public int coins=0;
    public int coinThreshold=100;
    public float score=0;
    public float DistTravelled=0f;
    private Meteor meteor;
    
    private MeteorSpawner ms;
    private float dt;
    

      void Start()
      {
        ms=FindObjectOfType<MeteorSpawner>();
        if (PlayerPrefs.HasKey("Coins"))
        coins=PlayerPrefs.GetInt("Coins");
      }
      void Update()
      {
        PlayerPrefs.SetInt("Coins",coins);
        DistTravelled+=0.05f;
        dt=DistTravelled;
        
        SpawnAbilities();
        //text.text=score.ToString();
        Difficulty();
        if(score%coinThreshold==0)
        coins++;      
        
      }
      void Difficulty()
      {
        if(DistTravelled>=500 && DistTravelled<=200)
        ms.spawnInterval=1.75f;
        
        if(DistTravelled>750 && DistTravelled<=1000){
        spawner1.SetActive(true);
        ms.spawnInterval=1.5f;}
        if(DistTravelled>1000){
        spawner2.SetActive(true);
        ms.spawnInterval=3f;
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

