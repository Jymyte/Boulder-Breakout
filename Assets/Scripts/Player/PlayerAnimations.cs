using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private GameObject player;
    private Rigidbody _rigidbody;
    private Animator anim;

    private float previousYVelocity; 
    private float currentYVelocity;

    private void Awake() {
        player = GameObject.Find("Player");
        _rigidbody = player.GetComponent<Rigidbody>();
        anim = GetComponent<Animator> ();
        //anim.Play("JumpTransition");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        currentYVelocity = _rigidbody.velocity.y;

        if (currentYVelocity > 0 && previousYVelocity <= 0) {
            anim.Play("JumpStart");
            Debug.Log(currentYVelocity + "current" + previousYVelocity + "previous");
        }
        if (currentYVelocity <= 0 && previousYVelocity > 0) {
            anim.Play("JumpTransition");
            Debug.Log("PLAYING JUMP TRANSITION");
        }
        if (currentYVelocity < 0 && previousYVelocity < 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("JumpTransition")) {
            anim.Play("Falling");
             Debug.Log("PLAYING FALLING");
        }
        if (currentYVelocity == 0 && previousYVelocity == 0) {
            anim.Play("Run");
        }

        Debug.Log(currentYVelocity + "Current" + previousYVelocity + "previous");

        previousYVelocity = currentYVelocity;
    
    }
}
