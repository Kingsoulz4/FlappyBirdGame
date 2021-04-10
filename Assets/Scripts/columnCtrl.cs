using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

public class columnCtrl : MonoBehaviour
{
    public GameObject obj;
    //private Vector3 defaultPosition;
    private float defaultPositionX;
    public float moveSpeed;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        defaultPositionX =10;
       
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = new Vector3(obj.transform.position.x - 1 * Time.deltaTime * moveSpeed, obj.transform.position.y, 0);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("ResetColumn"))
            obj.transform.position = new Vector3(defaultPositionX, Random.Range(minY, maxY), 0);

      
    }
}
