using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 5;
    public float attackRate = 1f;
    float nextAttackTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackEnemy()
    {
        if(Time.time >= nextAttackTime)
        {
            Attack();
            nextAttackTime = Time.time + 1f / attackRate;
        }
    }

    void Attack()
    {
        animator.SetTrigger("attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach(Collider2D enemy in hitEnemies)
        {
            Health enemyHealth = enemy.GetComponent<Health>();
            Enemy enemyScript = enemy.GetComponent<Enemy>();

        // Check if the components exist before calling methods on them
        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(attackDamage);
        }

        if (enemyScript != null)
        {
            enemyScript.TakeDamage(attackDamage);
        }
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
