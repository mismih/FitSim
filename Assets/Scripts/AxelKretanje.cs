using UnityEngine;

public class AxelKretanje : MonoBehaviour
{
    float brzinaKretanja = 2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
      float x_osa = Input.GetAxis("Horizontal");
      float y_osa = Input.GetAxis("Vertical");

      rb.velocity = new Vector2(x_osa, y_osa) * brzinaKretanja;  
    }
}
