using UnityEngine;

public class ClickManager2D : MonoBehaviour
{
    [SerializeField] private CaloriesSystem caloriesSystem;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.zero);

            if (hit.collider != null)
            {
                ClickableGymProp prop = hit.collider.GetComponent<ClickableGymProp>();
                if (prop != null)
                {
                    caloriesSystem.RemoveCalories(prop.CaloriesOnClick);
                }
                ClickableFoodProp foodProp = hit.collider.GetComponent<ClickableFoodProp>();
                if (foodProp != null)
                {
                    caloriesSystem.AddCalories(foodProp.CaloriesOnClick);
                }
            }
        }
    }
}
