using UnityEngine;

public class ClickableProp : MonoBehaviour
{
    [SerializeField] private int caloriesOnClick = 10;

    public int CaloriesOnClick => caloriesOnClick;
}
