using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public string[] questMarkerNames;
    public bool[] questMarkersComplete;

    public static QuestManager instance;

    void Start()
    {
        instance = this;

        questMarkersComplete = new bool[questMarkerNames.Length];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log(CheckIfComplete("quest test"));
            MarkQuestComplete("quest test");
            MarkQuestIncomplete("fight the dragon");
        }
    }

    public int GetQuestNumber(string questToFind)
    {
        for (int i = 0; i < questMarkerNames.Length; i++)
        {
            if (questMarkerNames[i] == questToFind)
            {
                return i;
            }
        }

        Debug.LogError("Quest " + questToFind + " does not exist");
        return 0;
    }

    public bool CheckIfComplete(string questToCheck)
    {
        if (GetQuestNumber(questToCheck) != 0)
        {
            return questMarkersComplete[GetQuestNumber(questToCheck)];
        }

        return false;
    }

    public void MarkQuestComplete(string questToMark)
    {
        questMarkersComplete[GetQuestNumber(questToMark)] = true;

        UpdateLocalQuestObjects();
    }

    public void MarkQuestIncomplete(string questToMark)
    {
        questMarkersComplete[GetQuestNumber(questToMark)] = false;

        UpdateLocalQuestObjects();
    }

    public void UpdateLocalQuestObjects()
    {
        QuestObjectActivator[] questObjects = FindObjectsOfType<QuestObjectActivator>();

        if (questObjects.Length > 0)
        {
            for (int i = 0; i < questObjects.Length; i++)
            {
                questObjects[i].CheckCompletion();
            }
        }
    }
}
