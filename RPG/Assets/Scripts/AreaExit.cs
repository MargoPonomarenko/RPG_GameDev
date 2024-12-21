using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaExit : MonoBehaviour
{
    public string areaToLoad;
    public string areaTransitionName;

    public AreaEntrance theEntrance;

    void Start()
    {
        theEntrance.transitionName = areaTransitionName;
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(areaToLoad);

            PlayerController.instance.areaTransitionName = areaTransitionName;
        }
    }
}
