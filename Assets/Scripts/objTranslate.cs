using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objTranslate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;
    private Vector3 defaultPosition;
    public float moveSpeed;
    //public float rangeDistance;
    public float posReset;
    void Start()
    {
        defaultPosition = obj.transform.position;
        //defaultPosition.x -= 5;
    }

    // Update is called once per frame
    void Update()
    {
        obj.transform.position = new Vector3(obj.transform.position.x - 1 * Time.deltaTime * moveSpeed, obj.transform.position.y, 0);
        // if(Vector3.Distance(obj.transform.position, defaultPosition)>rangeDistance)
        // {
        //     //Debug.Log("sky tile:"+rangeDistance);

        //     obj.transform.position = defaultPosition;
           
        // }
        Debug.Log(obj.transform.position.x);
        if (obj.transform.position.x<posReset)
        {
            obj.transform.position = defaultPosition;
        }
    }
}
