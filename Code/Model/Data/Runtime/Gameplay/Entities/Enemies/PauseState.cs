using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseState : IEnemyState
{
    public Enemy Instance {get; set;}

    public PauseState(Enemy instance)
    {
        this.Instance = instance;
    }
    
    public void Hit()
    {
        // do nothing.
    }

    public void Die()
    {
        // do nothing.
    }
}
