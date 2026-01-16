using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSpawnPlacer : MonoBehaviour
{
    [SerializeField] private string playerTag = "Player";
    [SerializeField] private string spawnTag = "PlayerSpawn";

    private void Start ()
    {
        // Nađi player i spawn u sceni
        var player = GameObject.FindGameObjectWithTag(playerTag);
        var spawn = GameObject.FindGameObjectWithTag(spawnTag);

        if (player == null)
        {
            Debug.LogError("Nema Player objekta (tag Player).");
            return;
        }

        if (spawn == null)
        {
            Debug.LogError("Nema Spawn objekta (tag PlayerSpawn).");
            return;
        }

        player.transform.position = spawn.transform.position;
    }
}
