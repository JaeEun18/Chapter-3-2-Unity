using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipTool : Equip
{
    public float attackRate; //공격 주기
    private bool attacking;  
    public float attackDistance; //최대 공격 거리

    [Header("Resource Gathering")]
    public bool doesGatherResouteces;

    [Header("Combat")]
    public bool doesDealDamage;
    public int damage;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public override void OnAttackInput()
    {
        if(!attacking)
        {
            attacking = true;
            animator.SetTrigger("Attack");
            Invoke("OnCanAttack", attackRate);
        }
    }

    void OnCanAttack()
    {
        attacking = false;
    }

}
