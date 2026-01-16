using UnityEngine;

public class ClickableFoodProp : MonoBehaviour
{
    [SerializeField] private int caloriesOnClick = 20;

    public int CaloriesOnClick => caloriesOnClick;
}