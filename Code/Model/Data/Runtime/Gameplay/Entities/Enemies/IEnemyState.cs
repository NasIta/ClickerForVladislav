using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyState
{
    Enemy Instance {get; set;}
    void Hit();
    void Die();
}
