using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [Range(0f, 10f)]
    [SerializeField] float speed = 1f;

    [SerializeField] float damage = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D OtherCollider)
    {
        var health = OtherCollider.GetComponent<Health>();
        var attacker = OtherCollider.GetComponent<Attacker>();

        if(health && attacker)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
    }
}
