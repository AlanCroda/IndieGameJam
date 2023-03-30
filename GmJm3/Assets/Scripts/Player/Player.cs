using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [Header("Files")]
    [Tooltip("Files connected to this script")]
    //areas
    [SerializeField]
    internal PlayerInput playerInput;
    [SerializeField]
    internal PlayerMovement playerMovement;
    [SerializeField]
    internal PlayerCollision collisionScript;

    [Header("Layers")]
    [SerializeField]
    internal LayerMask ground;

    [Header("Movement")]
    [SerializeField]
    internal float walkSpeed;
    [SerializeField]
    internal float acceleration;
    [SerializeField]
    internal float decceleration;
    [SerializeField]
    internal float frictionAmount;

    [Header("Jumping")]
    [SerializeField]
    internal float jumpForce;
    [SerializeField]
    internal float fallMultiplier;
    [SerializeField]
    internal float maxFallSpeed;
    [SerializeField]
    internal float jumpHangTimeThreshold;
    [SerializeField]
    internal float jumpHangAccelerationMultiplier;
    [SerializeField]
    internal float jumpHangMaxSpeedMultiplier;

    [Header("GroundCheck")]
    [SerializeField]
    internal Vector3 BoxSize;
    [SerializeField]
    internal float maxDistance;
}
