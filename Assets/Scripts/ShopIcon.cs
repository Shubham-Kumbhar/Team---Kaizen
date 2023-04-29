using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopIcon : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Text text;
    public int PriceItem;
    private float coins;
    public bool IsPurchased=false;
    public Sprite buyingSprite;
    private ShopManager shopManager;
    [SerializeField]private GameObject player;
    void Start()
    {
        shopManager=GetComponent<ShopManager>();
        coins=shopManager.coins;
        //player=GameObject.FindWithTag("Player");
        
    }
    void Update()
    {
        if(!IsPurchased)
        text.text=PriceItem.ToString();
    }

    // Update is called once per frame
   
    public void OnClick()
    {
        if(IsPurchased)
        {
            player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            text.text="Equiped";
        }
        if(PriceItem<=coins && !IsPurchased)
        {
            FindObjectOfType<ShopManager>().coins-=PriceItem;
            //player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            text.text="Owned";
            IsPurchased=true;
        }
        
    }
}
