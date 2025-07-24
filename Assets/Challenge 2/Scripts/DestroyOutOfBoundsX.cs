using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 物体超过范围销毁物体
 */
public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = 50;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        //Debug.Log($"{transform.gameObject.tag} -> x = {transform.position.x}");
        //Debug.Log($"{transform.gameObject.tag} -> z = {transform.position.z}");
        // Destroy dogs if x position less than left limit
        if (transform.position.x < -leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
