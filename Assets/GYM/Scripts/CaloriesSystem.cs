using UnityEngine;
using UnityEngine.UI;

public class CaloriesSystem : MonoBehaviour
{
    [SerializeField] private Text caloriesText;
    [SerializeField] private ExperienceSystem experienceSystem;

    private int calories;

    private void Start()
    {
        UpdateText();
    }

    public void AddCalories(int amount)
    {
        calories += amount;
        UpdateText();

    }
    public void RemoveCalories(int amount)
    {   
        if (calories > 0)
        {
            calories -= amount;
            UpdateText();
        }
       

        if (experienceSystem != null)
        {
            experienceSystem.AddExp(amount);
        }
    }
    private void UpdateText()
    {
        if (caloriesText != null)
            caloriesText.text = "Calories: " + calories;
    }
}
