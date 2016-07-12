using UnityEngine;
using System.Collections;

public class BattleCommands : MonoBehaviour
{
    private Animator animator;
    // Use this for initialization
    void Start ()
    {
        animator = this.GetComponent<Animator>();
    }
    
    void OnAttack()
    {
        animator.SetTrigger("isAttacking");
        //animator.SetTrigger("isIdle");
    }

    void OnDodge()
    {
        Destroy(this.GetComponent<Collider>());
        animator.SetTrigger("isDodging");
    }

    void OnEvade()
    {
        Destroy(this.GetComponent<Collider>());
        animator.SetTrigger("isEvading");
    }

    void onAvoid()
    {
        Destroy(this.GetComponent<Collider>());
        animator.SetTrigger("isAvoiding");
    }
}
