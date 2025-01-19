using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(Rigidbody))]
public class PhysicsProjectile : Projectile
{
    [SerializeField] private float lifeTime;
    [SerializeField] private GameObject decalPrefab; // Префаб для decal
    [SerializeField] private float decalLifetime = 10f; // Время жизни decal
    private Rigidbody rigidBody;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public override void Init(Weapon weapon)
    {
        base.Init(weapon);
        Destroy(gameObject, lifeTime);
    }

    public override void Launch()
    {
        base.Launch();
        rigidBody.AddRelativeForce(Vector3.forward * weapon.GetShootingForce(), ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (decalPrefab != null)
        {
            ContactPoint contact = collision.contacts[0];

            GameObject decal = Instantiate(decalPrefab, contact.point + contact.normal * 0.01f, Quaternion.LookRotation(contact.normal));

            decal.transform.SetParent(collision.transform);

            Destroy(decal, decalLifetime);
        }

        Destroy(gameObject);
    }

}
