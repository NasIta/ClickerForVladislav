using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    public static int enemyCount;
    void Start()
    {
        SpawnEnemies();
    }
    public static void SpawnEnemies()
    {
        int distance = 4;
        enemyCount = Mathf.Min(4, Enemy.Defeated / 10 + 1);
        for (int i = 0; i < enemyCount; i++)
        {
            var enemyPrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/Enemies/EnemyDefault.prefab");
            var spriteResource = AssetDatabase.LoadAssetAtPath<Sprite>($"Assets/Graphics/Sprites/Gameplay/Enemies/enemy_{Random.Range(0, 8)}.png");

            if (enemyPrefab != null)
            {
                var obj = Instantiate(enemyPrefab, enemyPrefab.transform.position + new Vector3(enemyCount * (distance / 2) - (distance / 2) - i * distance, 0, 0), Quaternion.identity);
                var rendererComponent = obj.GetComponent<SpriteRenderer>();
                if (rendererComponent != null)
                {
                    rendererComponent.sprite = spriteResource;
                }
                var enemyComponent = obj.GetComponent<Enemy>();
                if (enemyComponent != null)
                {
                    enemyComponent.Health = (Enemy.Defeated / 10) + ((Enemy.Defeated - 1) / 2 ) % 5 + 1;
                    enemyComponent.State = new PlayState(enemyComponent);
                    enemyComponent.Strategy = new DefaultStrategy(enemyComponent);
                }
            }
        }
    }
}
