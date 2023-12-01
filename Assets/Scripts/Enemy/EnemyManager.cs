using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    private const string EnemyUnlockedKey = "EnemyUnlocked";

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public bool IsEnemyUnlocked(string enemyName)
    {
        return PlayerPrefs.GetInt($"{EnemyUnlockedKey}_{enemyName}", 0) == 1;
    }

    public void UnlockEnemy(string enemyName)
    {
        PlayerPrefs.SetInt($"{EnemyUnlockedKey}_{enemyName}", 1);
        PlayerPrefs.Save();
    }
}
