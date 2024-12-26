using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("Item Type")]
    public bool isItem;
    public bool isWeapon;
    public bool isArmour;

    [Header("Item Details")]
    public string itemName;
    public string description;
    public int value;

    [Header("Item Details")]
    public Sprite itemSprite;

    public int amountToChange;
    public bool affectHP, affectMP, affectStrength;

    [Header("Weapon/Armour Details")]
    public int weaponStrength;
    public int armourStrength;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
