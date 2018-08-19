using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : Bullet {

	void Start () {
        Shoot();
	}
	
	void Update () {
		
	}

    protected override void Shoot()
    {
        base.Shoot();
    }
}
