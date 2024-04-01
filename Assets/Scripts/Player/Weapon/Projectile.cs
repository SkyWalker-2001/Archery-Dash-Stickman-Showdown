using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float shoot_Force;

    [SerializeField] private float projectile_GravityMultiplayer;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

        _rb.gravityScale = 2.0f;


    }

    private void FixedUpdate()
    {
        Projectile_Move();
        Gravite_Increaswe_OverTime();
        TrackMovement();
    }

    private void Projectile_Move()
    {
        if (_rb != null)
        {
            _rb.AddForce(transform.right * shoot_Force, ForceMode2D.Force);
        }
    }

    private void Gravite_Increaswe_OverTime()
    {
        _rb.gravityScale += _rb.gravityScale * Time.deltaTime;
    }

    private void TrackMovement()
    {
        Vector2 direction = _rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
