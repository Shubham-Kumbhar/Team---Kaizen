using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class ShopIcon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Text text;
    public int PriceItem;
    private float coins;
    public bool IsPurchased=false;
    public bool IsEquiped=false;
    public Sprite buyingSprite;
    public RuntimeAnimatorController animCont;
    private ShopManager shopManager;
    [SerializeField]private GameObject player;
    void Start()
    {
        shopManager=GetComponent<ShopManager>();
        coins=shopManager.coins;
        IsPurchased=IntToBool(PlayerPrefs.GetInt("Purchased"));
        //player=GameObject.FindWithTag("Player");
        
    }
    void Update()
    {
        
        if(!IsPurchased)
        text.text=PriceItem.ToString();
        else if(player.GetComponent<Animator>().runtimeAnimatorController!=animCont)
        text.text="Owned";
        PlayerPrefs.SetInt("Purchased",BoolToInt(IsPurchased));
    }

    // Update is called once per frame
   
    public void OnClick()
    {
        if(IsPurchased)
        {
            player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            player.GetComponent<Animator>().runtimeAnimatorController=animCont;
            text.text="Equiped";
            IsEquiped=true;
        }
        if(PriceItem<=coins && !IsPurchased)
        {
            FindObjectOfType<ShopManager>().coins-=PriceItem;
            //player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            text.text="Owned";
            IsPurchased=true;
        }
        
    }
    private int BoolToInt(bool b)
    {
        if(b)
        return 1;
        else
        return 0;
    }
    private bool IntToBool(int x)
    {
        if(x==1)
        return true;
        else
        return false;
    }
}
