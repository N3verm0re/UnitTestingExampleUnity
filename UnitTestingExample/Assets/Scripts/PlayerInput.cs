using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Vector2 movement;
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        switch (movement.x)
        {
            case 1f when (movement.y == 0):
                MoveRight();
                break;
            case -1f when (movement.y == 0):
                MoveLeft();
                break;
            case 0 when (movement.y == 1f):
                MoveUp();
                break;
            case 0 when (movement.y == -1f):
                MoveDown();
                break;
            case 1f when (movement.y == 1f):
                MoveUp();
                MoveRight();
                break;
            case -1f when (movement.y == 1f):
                MoveUp();
                MoveLeft();
                break;
            case 1f when (movement.y == -1f):
                MoveDown();
                MoveRight();
                break;
            case -1f when (movement.y == -1f):
                MoveDown();
                MoveLeft();
                break;
            default:
                break;
        }
    }

    public void MoveLeft()
    {
        this.transform.position += new Vector3(-1f, 0) * Time.deltaTime;
    }
    public void MoveRight()
    {
        this.transform.position += new Vector3(1f, 0) * Time.deltaTime;
    }
    public void MoveUp()
    {
        this.transform.position += new Vector3(0, 1f) * Time.deltaTime;
    }
    public void MoveDown()
    {
        this.transform.position += new Vector3(0, -1f) * Time.deltaTime;
    }
}
