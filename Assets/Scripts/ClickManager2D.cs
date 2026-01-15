using UnityEngine;

public class ClickManager2D : MonoBehaviour
{
    [SerializeField] private CaloriesSystem caloriesSystem;

    void Update ()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

        if (!hit.collider) return;

        var prop = hit.collider.GetComponent<ClickableProp>();
        if (prop == null) return;

        caloriesSystem.AddCalories(prop.CaloriesOnClick);
    }
}
