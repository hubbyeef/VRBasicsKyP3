﻿using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Move an object using velocity
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class MoveWithVelocity : MonoBehaviour
{
    [Tooltip("The speed at which the object is moved")]
    public float speed = 1.0f;
    public Slider slider;

    [Tooltip("Controls the direction of movement")]
    public Transform origin = null;

    private Vector3 inputVelocity = Vector3.zero;
    private Rigidbody rigidBody = null;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        slider.value = 5;
    }

    private void FixedUpdate()
    {
        speed = slider.value;
        ApplyVelocity();
    }

    private void ApplyVelocity()
    {
        Vector3 targetVelocity = inputVelocity * speed;
        targetVelocity = origin.TransformDirection(targetVelocity);

        Vector3 velocityChange = targetVelocity - rigidBody.velocity;
        rigidBody.AddForce(velocityChange, ForceMode.VelocityChange);
    }

    public void SetRightVelocity(float value)
    {
        inputVelocity.x = value;
    }

    public void SetForwardVelocity(float value)
    {
        inputVelocity.z = value;
    }

    public void SetUpVelocity(float value)
    {
        inputVelocity.y = value;
    }

    private void OnValidate()
    {
        if (!origin)
            origin = transform;
    }

    public void SetSpeed(float newSpeed)
    {
        speed = slider.value;
    }
}
