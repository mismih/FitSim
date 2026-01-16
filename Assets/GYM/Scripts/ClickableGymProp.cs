using UnityEngine;

public class ClickableGymProp : MonoBehaviour
{
    [SerializeField] private int caloriesOnClick = 10;

    public int CaloriesOnClick => caloriesOnClick;
}
