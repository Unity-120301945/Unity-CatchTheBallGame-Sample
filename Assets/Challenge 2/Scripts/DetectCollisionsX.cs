using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 碰撞器碰撞后销毁物体
 */
public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
