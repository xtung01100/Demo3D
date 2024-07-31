using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealthPoint;
    public Animator anim;
    public UnityEvent onDie;
    private int healPoint;
    private bool isDead => healPoint <= 0;
    private void Start() => healPoint = maxHealthPoint;
    public void TakeDamage(int damage)
    {
        if (isDead) return;
        healPoint = -damage;
        if (isDead)
        {
            Die();
        }
    }
    private void Die()
    {
        anim.SetTrigger("Die");
        onDie.Invoke();
    }
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
