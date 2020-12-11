using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static int Defeated {get; set;}

    public IEnemyStrategy Strategy {get; set;}
    public IEnemyState State {get; set;}

    public int Health {get; set;}

    static Enemy()
    {
        Defeated = 0;
    }

    private void OnMouseDown()
    {
        Hit();
    }

    public void Hit()
    {
        State.Hit();
    }
    public void Die()
    {
        State.Die();
    }
}
