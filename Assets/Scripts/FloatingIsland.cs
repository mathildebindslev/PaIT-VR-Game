using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://forum.unity.com/threads/how-to-make-an-object-move-up-and-down-on-a-loop.380159/

public class FloatingIsland : MonoBehaviour
{
    //adjust this to change speed
    private float speed;

    //adjust this to change how high it goes
    private float height;

    private Vector3 pos;

    private void Start()
    {
        pos = transform.position;

        speed = Random.Range(0.3f, 0.75f);

        height = Random.Range(2, 4);
    }

    void FixedUpdate()
    {
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;

        //set the object's Y to the new calculated Y
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
