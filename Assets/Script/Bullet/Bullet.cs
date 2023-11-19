using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 2f;
    private Rigidbody2D bulletRb;

    private void OnEnable()
    {
        bulletRb = GetComponent<Rigidbody2D>();
        bulletRb.velocity = Vector2.up * bulletSpeed;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
    }
}
