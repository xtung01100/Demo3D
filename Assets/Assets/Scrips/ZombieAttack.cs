using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public int damage;
    public Health playerHealth;
    public void StartAttack() => anim.SetBool("IsAttacking", true);
    public void StopAttack() => anim.SetBool("IsAttacking", false);
    public void OnAttack(int index)
    {
        playerHealth.TakeDamage(damage);
        if (index == 1)
        {
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
