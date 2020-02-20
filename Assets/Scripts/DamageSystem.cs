using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DamageSystem : MonoBehaviour
{
    public string takeDamageFrom = null;
    public int hp = 10;
    public int damageDealt = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.takeDamageFrom != null){
            if (collision.gameObject.CompareTag(takeDamageFrom))
            {
                DamageSystem enemy = collision.gameObject.GetComponent<DamageSystem>();
                hp -= enemy.damageDealt;
                if (hp <= 0)
                {
                    death();
                }
            }
        }
    }

    private void death()
    {
        print("dead");
    }

}

