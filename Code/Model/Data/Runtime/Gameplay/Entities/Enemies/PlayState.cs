using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayState : IEnemyState
{
    public Enemy Instance {get; set;}

    public PlayState(Enemy instance)
    {
        this.Instance = instance;
    }

    public void Hit()
    {
        Instance.Strategy.Hit();
    }

    public void Die()
    {
        Instance.Strategy.Die();
    }
}
