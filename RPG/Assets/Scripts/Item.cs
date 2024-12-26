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

    public void Use(int charToUseOn)
    {
        CharStats selectedChar = GameManager.instance.playerStats[charToUseOn];

        if (isItem)
        {
            if (affectHP)
            {
                selectedChar.currentHP += amountToChange;

                if (selectedChar.currentHP > selectedChar.maxHP)
                {
                    selectedChar.currentHP = selectedChar.maxHP;
                }
            }

            if (affectMP)
            {
                selectedChar.currentMP += amountToChange;

                if (selectedChar.currentMP > selectedChar.maxMP)
                {
                    selectedChar.currentMP = selectedChar.maxMP;
                }
            }

            if (affectStrength)
            {
                selectedChar.strength += amountToChange;
            }
        }

        if (isWeapon)
        {
            if (selectedChar.equippedWeapon != "")
            {
                GameManager.instance.AddItem(selectedChar.equippedWeapon);
            }

            selectedChar.equippedWeapon = itemName;
            selectedChar.weaponPower = weaponStrength;
        }

        if (isArmour)
        {
            if (selectedChar.equippedArmour != "")
            {
                GameManager.instance.AddItem(selectedChar.equippedArmour);
            }

            selectedChar.equippedArmour = itemName;
            selectedChar.armourPower = armourStrength;
        }

        GameManager.instance.RemoveItem(itemName);
    }
}
