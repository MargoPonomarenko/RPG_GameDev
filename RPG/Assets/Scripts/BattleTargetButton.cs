using UnityEngine;
using TMPro;

public class BattleTargetButton : MonoBehaviour
{
    public string moveName;
    public int activeBattlerTarget;
    public TMP_Text targetName;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Press()
    {
        BattleManager.instance.PlayerAttack(moveName, activeBattlerTarget);
    }
}
