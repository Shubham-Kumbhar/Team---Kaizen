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
    private bool IsPurchased=false;
    public Sprite buyingSprite;
    private ShopManager shopManager;
    [SerializeField]private GameObject player;
    void Start()
    {
        shopManager=GetComponent<ShopManager>();
        coins=shopManager.coins;
    }

    // Update is called once per frame
    void Update()
    {
        text.text=PriceItem.ToString();

    }
    public void OnClick()
    {
        if(PriceItem>=coins)
        {
            FindObjectOfType<ShopManager>().coins-=PriceItem;
            player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            text.text="Owned";
            IsPurchased=true;
        }
        if(IsPurchased)
        {
            player.GetComponent<SpriteRenderer>().sprite=buyingSprite;
            text.text="Equiped";
        }
    }
}
