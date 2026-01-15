using UnityEngine;
using UnityEngine.UI;

public class CaloriesSystem : MonoBehaviour
{
    [SerializeField] private Text caloriesText;
    private int calories;

    private void Start()
    {
        RefreshUI();
    }

    public void AddCalories(int amount)
    {
        calories += amount;
        RefreshUI();
    }

    private void RefreshUI()
    {
        if (caloriesText != null)
            caloriesText.text = "Calories : " + calories;
    }
}
