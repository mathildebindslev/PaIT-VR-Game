using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingItem : MonoBehaviour
{
    // https://forum.unity.com/threads/how-to-make-an-object-move-up-and-down-on-a-loop.380159/

    //adjust this to change speed
    public float speed;

    //adjust this to change how high it goes
    public float height;

    private Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }

    void Update()
    { 
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) * height + pos.y;

        //set the object's Y to the new calculated Y
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
     }
}
