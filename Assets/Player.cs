using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bulletPrefab;

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			GameObject bulletObject = Instantiate (bulletPrefab);	
			Bullet bullet = bulletObject.GetComponent<Bullet> ();
			
			Vector3 shootingDirection = new Vector3 (
				Random.Range(-0.15f, 0.15f),
				Random.Range(-0.15f, 0.15f),
				1
			);
			bullet.shootingDirection = shootingDirection.normalized;
		}

	}
}
