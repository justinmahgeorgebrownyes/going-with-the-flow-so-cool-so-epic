using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    private Rigidbody2D shot;
    float shotVel = 10;
    float lifeTimer = 0;

    void Start()
    {

  
        shot = GetComponent<Rigidbody2D>();

        shot.velocity = transform.up * 10;





    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            shot.velocity = new Vector3(transform.up.x*-1, transform.up.y, transform.up.z) * shotVel;

        }
        if (Input.GetButtonDown("Fire3"))
        {
            shot.velocity = new Vector3(transform.up.x * 1, transform.up.y, transform.up.z) * shotVel;

        }
    }


    void FixedUpdate()
    {


        lifeTimer += Time.fixedDeltaTime;
        if (lifeTimer > 5)
        {
            Destroy(gameObject);
        }
    }
}