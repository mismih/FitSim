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
    [SerializeField] private ExperienceSystem experienceSystem;

    private void Awake()
    {
        if (sr == null)
            sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (experienceSystem != null)
        {
            experienceSystem.OnLevelChanged += ApplyLevel;
            ApplyLevel(experienceSystem.CurrentLevel);
        }
    }

    private void OnDestroy()
    {
        if (experienceSystem != null)
            experienceSystem.OnLevelChanged -= ApplyLevel;
    }

    public void ApplyLevel(int currentLevel)
    {
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
        Debug.Log("Skin applied for level " + currentLevel);
    }
}
