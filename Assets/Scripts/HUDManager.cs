using TMPro;
using UnityEngine;

public class HUDManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI levelText;
    [SerializeField] private TextMeshProUGUI caloriesText;
    [SerializeField] private TextMeshProUGUI streakText;

    public void SetHUD(int level, int calories, int streak)
    {
        levelText.text = "Level: " + level;
        caloriesText.text = "Calories: " + calories;
        streakText.text = "Streak: " + streak;
    }

    private void Start()
    {
        SetHUD(1, 120, 3);
    }
}
