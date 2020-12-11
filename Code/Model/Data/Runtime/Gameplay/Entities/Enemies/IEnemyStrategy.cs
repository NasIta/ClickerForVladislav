using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyStrategy 
{
    Enemy Instance {get; set;}
    void Hit();
    void Die();
}
