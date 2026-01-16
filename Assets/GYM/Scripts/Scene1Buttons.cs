using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Buttons : MonoBehaviour
{
    public void GoToKitchenScene ()
    {
        Debug.Log("BUTTON CLICKED -> loading KitchenScene");
        SceneManager.LoadScene("Kitchen");
    }

}
