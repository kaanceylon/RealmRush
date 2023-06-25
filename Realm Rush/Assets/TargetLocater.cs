using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocater : MonoBehaviour
{
    [SerializeField] Transform weapon;
    Transform target;

    void Start()
    {
        target = FindObjectOfType<EnemyMoover>().transform;
    }

  
    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
