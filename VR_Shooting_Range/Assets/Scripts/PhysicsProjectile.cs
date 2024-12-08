using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


[RequireComponent(typeof(Rigidbody))]
public class PhysicsProjectile : Projectile
{
    [SerializeField] private float lifeTime;
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
    /*
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<XRBaseInteractor>() != null) return;

        Debug.Log($"Projectile hit: {other.name}");

        ITakeDamage[] damageTakers = other.GetComponentsInParent<ITakeDamage>();
        foreach (var taker in damageTakers)
        {
            taker.TakeDamage(weapon, this, transform.position);
        }

        Destroy(gameObject);
    }
    */


}