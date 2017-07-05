using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperrilfel :Gun {

    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("bullet to your head");
    }
}
