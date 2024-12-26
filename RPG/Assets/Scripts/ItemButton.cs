using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemButton : MonoBehaviour
{
    public Image buttonImage;
    public TMP_Text amountText;
    public int buttonValue;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void Press()
    {
        if (GameManager.instance.itemsHeld[buttonValue] != "")
        {
            GameMenu.instance.SelectItem(GameManager.instance.GetItemDetails(GameManager.instance.itemsHeld[buttonValue]));
        }
    }
}
