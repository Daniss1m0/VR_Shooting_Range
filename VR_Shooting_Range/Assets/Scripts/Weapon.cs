using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(XRGrabInteractable))]
public class Weapon : MonoBehaviour
{
    [SerializeField] protected float shootingForce;
    [SerializeField] protected Transform bulletSpawn;
    [SerializeField] private float recoilForce;
    [SerializeField] private float damage;
    [SerializeField] private int maxAmmo = 30;
    [SerializeField] private TextMeshProUGUI ammoText;

    protected int currentAmmo;
    private Rigidbody rigidBody;
    private XRGrabInteractable interactableWeapon;

    protected virtual void Awake()
    {
        interactableWeapon = GetComponent<XRGrabInteractable>();
        rigidBody = GetComponent<Rigidbody>();
        SetupInteractableWeaponEvents();
        currentAmmo = maxAmmo;

        if (ammoText == null)
        {
            ammoText = FindObjectOfType<TextMeshProUGUI>();
        }

        UpdateAmmoText();
    }

    private void SetupInteractableWeaponEvents()
    {
        interactableWeapon.onActivate.AddListener(StartShooting);
        interactableWeapon.onDeactivate.AddListener(StopShooting);
    }

    protected virtual void StartShooting(XRBaseInteractor interactor) { }

    protected virtual void StopShooting(XRBaseInteractor interactor) { }

    protected virtual void Shoot()
    {
        if (currentAmmo > 0)
        {
            currentAmmo--;
            ApplyRecoil();
            UpdateAmmoText();
        }
        else
        {
            UpdateAmmoText("Out of ammo!");
        }
    }

    private void ApplyRecoil()
    {
        rigidBody.AddRelativeForce(Vector3.back * recoilForce, ForceMode.Impulse);
    }

    public float GetShootingForce()
    {
        return shootingForce;
    }

    public float GetDamage()
    {
        return damage;
    }

    private void UpdateAmmoText(string extraText = "")
    {
        if (ammoText != null)
        {
            ammoText.text = extraText == "" ? $"Ammo: {currentAmmo}/{maxAmmo}" : extraText;
        }
    }
}
