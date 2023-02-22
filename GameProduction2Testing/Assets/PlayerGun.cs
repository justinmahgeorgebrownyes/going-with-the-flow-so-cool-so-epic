using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public GameObject bullet;


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("YES");
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
