using UnityEngine;
using System.Collections;

public class CharacterController : MonoBehaviour
{
    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        animator.SetTrigger("isHit");
    }
}
