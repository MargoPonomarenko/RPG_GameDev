using UnityEngine;

public class AreaEntrance : MonoBehaviour
{
    public string transitionName;
    void Start()
    {
        if(transitionName == PlayerController.instance.areaTransitionName)
        {
            PlayerController.instance.transform.position = transform.position;
        }

        UIFade.instance.FadeFromBlack();
    }


    void Update()
    {
        
    }
}
