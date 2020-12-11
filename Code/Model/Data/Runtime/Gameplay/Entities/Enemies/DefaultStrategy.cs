using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultStrategy : IEnemyStrategy
{
    public Enemy Instance {get; set;}

    public DefaultStrategy(Enemy instance)
    {
        this.Instance = instance;
    }

    public void Hit()
    {
        Instance.Health--;

        if (Instance.Health <= 0)
        {
            Instance.Die();
        }
    }

    public void Die()
    {
        Enemy.Defeated++;
        GameStarter.enemyCount--;
        if (GameStarter.enemyCount <= 0)
        {
            GameStarter.SpawnEnemies();
        }
        Enemy.Destroy(Instance.gameObject, 0);
    }
}
