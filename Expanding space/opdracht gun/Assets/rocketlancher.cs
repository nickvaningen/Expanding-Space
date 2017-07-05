using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketlancher : Gun {

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("shoet the rocket now");
    }
}
