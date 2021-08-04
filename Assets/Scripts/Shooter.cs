using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject Gun;

    public void Fire()
    {
        Instantiate(projectile, Gun.transform.position, transform.rotation);
    }


}
