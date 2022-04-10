using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemies : MonoBehaviour
{
    public Transform target;
    [Range(0, 10)] public float speed;
    [Range(0, 10)] public float evadeSpeed;
    public bool enemyMove;

    void Update()
    {
        if (enemyMove)
            MoveEnemy();
        else
            MoveNormal();
    }

    void MoveNormal()
    {
        transform.position =Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void MoveEnemy()
    {
        //get a random direction
        Vector3 r = Random.insideUnitCircle;    //for 2D
        
        //for 3D top down, you need to swap the x and z components
        r.Set(r.x, 0, r.y);

        transform.position = Vector3.MoveTowards(transform.position, transform.position + r, evadeSpeed * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }
}
