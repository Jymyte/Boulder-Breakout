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
    }
    // Update is called once per frame
    void Update()
    {
        currentYVelocity = _rigidbody.velocity.y;

        if (currentYVelocity > 0 || previousYVelocity <= 0)
            anim.Play("Jumping");
    }
}
