using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (_rigidbody.velocity.y > 0)
            anim.Play("Jumping");
    }
}
