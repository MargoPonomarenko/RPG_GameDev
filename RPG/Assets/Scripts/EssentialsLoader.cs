using UnityEngine;

public class EssentialsLoader : MonoBehaviour
{
    public GameObject UIScreen;
    public GameObject player;
    public GameObject gameManag;
    void Start()
    {
        if(UIFade.instance == null)
        {
            UIFade.instance = Instantiate(UIScreen).GetComponent<UIFade>();
        }

        if (PlayerController.instance == null)
        {
            PlayerController clone = Instantiate(player).GetComponent<PlayerController>();
            PlayerController.instance = clone;
        }

        if(GameManager.instance == null)
        {
            Instantiate(gameManag);
        }
    }

    void Update()
    {
        
    }
}
