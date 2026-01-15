using UnityEngine;

public class PlayerSkin : MonoBehaviour
{
    [System.Serializable]
    public struct LevelSkin
    {
        public int level;
        public Sprite sprite;
    }

    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private LevelSkin[] skins;

    private void Reset ()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void  ApplyLevel(int currentLevel)
    {
        if (sr == null) sr = GetComponent<SpriteRenderer>();

        Sprite best = sr.sprite;
        int bestLevel = int.MinValue;

        foreach (var s in skins)
        {
            if (s.sprite == null) continue;
            if (s.level <= currentLevel && s.level > bestLevel)
            {
                bestLevel = s.level;
                best = s.sprite;
            }
        }

        sr.sprite = best;
    }

    void Start ()
    {
        Debug.Log("PlayerSkin Start on: " + gameObject.name);
        ApplyLevel(2);
        Debug.Log("Applied sprite: " + sr.sprite.name);
    }

}