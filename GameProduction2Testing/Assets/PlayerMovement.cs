using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rd;
    public Camera cam;
    Vector2 pos;
    Vector3 mousePos;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        pos.x = Input.GetAxis("Horizontal");
        pos.y = Input.GetAxis("Vertical");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
    }

    void FixedUpdate()
    {

        rd.MovePosition(rd.position + pos * speed * Time.deltaTime);
        Vector2 look = (new Vector2(mousePos.x, mousePos.y) - rd.position);
        float aim = Mathf.Atan2(look.y, look.x) * Mathf.Rad2Deg - 90f;

        rd.rotation = aim;

    }
}
