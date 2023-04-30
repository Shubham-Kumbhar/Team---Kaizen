using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager: MonoBehaviour
{
    [SerializeField]private Text text;
    [SerializeField]private GameObject spawner1;
    [SerializeField]private GameObject PlayerPrefab;
    [SerializeField]private GameObject spawner2;
    [SerializeField]private GameObject[] abilitiesIcon;
    public int coins=0;
    public int NoOfBulletsFired=0;
    public int NukeThreshold=16;
    public bool CoinAdded=true;
    public int coinThreshold=100;
    public float score=0;
    public float DistTravelled=0f;
    private Meteor meteor;
    
    private MeteorSpawner ms;
    private float dt;
      Vector3 x1,x2;
    bool a= true;

      void Start()
      {
        ms=FindObjectOfType<MeteorSpawner>();

        x1=Camera.main.ViewportToWorldPoint(new Vector3(0,1,0));
        x2=Camera.main.ViewportToWorldPoint(new Vector3(1,1,0));
        GameObject go=Instantiate(PlayerPrefab,new Vector3(0,-2.04f,0),Quaternion.identity);
        go.GetComponent<PlayerMovement>().joyStick=FindObjectOfType<Slider>();
        for(int i=0;i<3;i++)
        {
          go.GetComponent<PlayerHealth>().liveHearts[i]=GameObject.FindGameObjectsWithTag("Heart")[i];
        }
        if (PlayerPrefs.HasKey("Coins"))
        coins=PlayerPrefs.GetInt("Coins");
      }
      void Update()
      {
        PlayerPrefs.SetInt("Coins",coins);
        DistTravelled+=0.05f;
        dt=DistTravelled;
        
        text.text=score.ToString();
        Difficulty();
        if(score%coinThreshold==0 && score!=0 && CoinAdded){
        CoinAdded=false;
        StartCoroutine(dealy());
       //SpawnAbilities();
        if(a)
        {
          a= false;
          //StartCoroutine(SpawnAbilities());
        }
        
        }
        
      }

      IEnumerator dealy()
      {
        coins++;
        yield return new WaitForSeconds(3f);
        CoinAdded = true;
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
        a=true;
        Debug.Log("YEs");
        Instantiate(abilitiesIcon[Random.Range(0,abilitiesIcon.Length-1)],new Vector3(Random.Range(x1.x,x2.x),5.08f,0f), Quaternion.identity);
      }
      }

