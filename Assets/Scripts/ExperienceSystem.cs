using System;
using UnityEngine;

public class ExperienceSystem : MonoBehaviour
{
    public int CurrentLevel { get; private set; } = 1;
    public int Exp { get; private set; }

    [Header("Level thresholds")]
    public int level2Exp = 100;
    public int level3Exp = 250;
    public int level4Exp = 500;

    public event Action<int> OnLevelChanged;

    public void AddExp(int amount)
    {
        Exp += amount;
        CheckLevel();
    }

    private void CheckLevel()
    {
        int newLevel = CurrentLevel;

        if (Exp >= level4Exp) newLevel = 4;
        else if (Exp >= level3Exp) newLevel = 3;
        else if (Exp >= level2Exp) newLevel = 2;
        else newLevel = 1;

        if (newLevel != CurrentLevel)
        {
            CurrentLevel = newLevel;
            Debug.Log("LEVEL UP → " + CurrentLevel);
            OnLevelChanged?.Invoke(CurrentLevel);
        }
    }
}
