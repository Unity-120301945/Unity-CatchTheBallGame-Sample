using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 玩家生成狗的控制器
 */
public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float inputCooldown = 1f;  // 设置输入的时间间隔（秒）
    private float lastInputTime = 0f; // 上一次输入的时间

    void Start()
    {
        lastInputTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        //监听空格键
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Input {KeyCode.Space}");
            if (Time.time - lastInputTime > inputCooldown)
            {
                //限制时间，最少一秒钟一次实例物体
                Debug.Log("time is true");
                //实例化狗物体
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastInputTime = Time.time; // 更新上一次输入时间
            }

        }

    }
}
