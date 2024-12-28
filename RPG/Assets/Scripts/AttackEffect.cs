using UnityEngine;

public class AttackEffect : MonoBehaviour
{
    public float effectLength;

    void Start()
    {
        
    }


    void Update()
    {
        Destroy(gameObject, effectLength);
    }
}
