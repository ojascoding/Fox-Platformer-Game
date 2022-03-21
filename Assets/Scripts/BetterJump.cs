using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BetterJump : MonoBehaviour
{
    [SerializeField] private float fallMultiplier = 2.5f; //The gravity amount when falling
    [SerializeField] private float lowJumpMultiplier = 2f; //The gravity amount when jumping up
    private float defaultGravity; //The default gravity set at the beginning of the game

    private Rigidbody2D rigidBody;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        defaultGravity = rigidBody.gravityScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rigidBody.velocity.y < 0)
        {
            rigidBody.gravityScale = fallMultiplier;
        }
        else if (rigidBody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rigidBody.gravityScale = lowJumpMultiplier;
        }
        else
        {
            rigidBody.gravityScale = defaultGravity;
        }
    }
}
