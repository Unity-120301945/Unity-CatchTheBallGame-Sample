using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * 随机掉落球的生成管理器
 */
public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;
    private float minInterval = 3f;  // 最小间隔时间
    private float maxInterval = 5f;  // 最大间隔时间

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
        //初次调用SpawnRandomBall方法，延迟 startDelay 秒
        Invoke(nameof(SpawnRandomBall), startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        //随机生成球的索引和生成位置
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        //随机生成球的索引
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        //实例化球物体
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);

        // 递归调用 SpawnRandomBall 方法，使用随机的间隔时间
        Invoke(nameof(SpawnRandomBall), Random.Range(minInterval, maxInterval));
    }

}
