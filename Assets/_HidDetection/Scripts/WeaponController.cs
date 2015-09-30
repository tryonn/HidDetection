using UnityEngine;
using System.Collections;
using System;

public class WeaponController : MonoBehaviour {
    [SerializeField] private BaseBullet bulletPrefab;

	void Update () {
        CheckInput();	
	}

    private void CheckInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
