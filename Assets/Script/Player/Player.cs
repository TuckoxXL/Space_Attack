using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Input Input;
    [SerializeField] private float speed;
    [SerializeField] private float bulletOffset = 0.5f;

    private void Awake()
    {
        AwakeMetod();
    }
    public void Shoot()
    {
        GameObject bullet = BulletPool.Instance.RequestBullet();
        bullet.transform.position = transform.position + Vector3.up * bulletOffset;

    }
    private void AwakeMetod()
    {
        rb = GetComponent<Rigidbody2D>();
        Input = GetComponent<Input>();
    }

    private void FixedUpdate()
    {
        rb.velocity = Input.Moved * speed;
    }
}
