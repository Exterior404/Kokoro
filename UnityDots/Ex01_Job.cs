using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Jobs;
using Unity.Collections;
using Unity.Burst;

public class Ex01_Job : MonoBehaviour {
    //單一線程 與 多線程 Job System

    [SerializeField] private bool useJobs;
    [SerializeField] private bool useJobUpdate;

    public int zombieS = 150;

    [SerializeField] private Transform pfZombie;
    private List<Zombie> zombieList;

    public class Zombie
    {
        public Transform transform;
        public float moveY;
    }

    private void Start()
    {
        zombieList = new List<Zombie>();
        for (int i = 0; i < zombieS; i++)
        {
            Transform transformZombie =
                Instantiate(pfZombie, new Vector3(UnityEngine.Random.Range(-18f, 18f), UnityEngine.Random.Range(-15f, 15f)), Quaternion.identity);

            zombieList.Add(new Zombie
            {
                transform = transformZombie,
                moveY = UnityEngine.Random.Range(1f, 2f)
            });
        }
    }

    private void Update() {
        //紀錄啟動以來的時間
        float startTime = Time.realtimeSinceStartup;

        if (useJobs)
        { //Job 版
            NativeArray<float3> positionArray = new NativeArray<float3>(zombieList.Count, Allocator.TempJob);
            NativeArray<float> moveYArray = new NativeArray<float>(zombieList.Count, Allocator.TempJob);

            for (int i = 0; i < zombieList.Count; i++)
            {
                positionArray[i] = zombieList[i].transform.position;
                moveYArray[i] = zombieList[i].moveY;
            }

            ReallToughParallelJob reallyToughParallelJob = new ReallToughParallelJob {
                deltaTime = Time.deltaTime,
                position = positionArray,
                moveY = moveYArray,
            };

            JobHandle jobHandle = reallyToughParallelJob.Schedule(zombieList.Count, 50);
            jobHandle.Complete();

            for (int i =0; i<zombieList.Count; i++)
            {
                zombieList[i].transform.position = positionArray[i];
                zombieList[i].moveY = moveYArray[i];
            }

            positionArray.Dispose();
            moveYArray.Dispose();
        }
        else //通常版
        {
            foreach (var zombie in zombieList)
            {
                zombie.transform.position += new Vector3(0, zombie.moveY * Time.deltaTime);

                if (zombie.transform.position.y > 5f) {
                    zombie.moveY = -math.abs(zombie.moveY);
                }
                if (zombie.transform.position.y < -5f) {
                    zombie.moveY = +math.abs(zombie.moveY);
                }
                float value = 0f;
                for (int i = 0; i < 1500; i++)
                {
                    value = math.exp10(math.sqrt(value));
                }
            }
        }

        

        //--------------------------------------//

        if (useJobUpdate) {
            if (useJobs) { //Job版執行
                NativeList<JobHandle> jobHandlesList = new NativeList<JobHandle>(Allocator.Temp);

                for (int i = 0; i < 10; i++)
                {//復數任務則要一個列表器收集 jobHandle
                    JobHandle jobHandle = ReallyToughTaskJob();
                    jobHandlesList.Add(jobHandle);//加job List
                                                  //jobHandle.Complete();// Complete會暫停主線 直到Job完成後再繼續
                }
                JobHandle.CompleteAll(jobHandlesList);//通知完成全job List
                jobHandlesList.Dispose();//在使用 NativeList & Array 需要在最後 Dispose 處理它們
            }
            else { //一般版本 * 10路徑
                for (int i = 0; i < 10; i++) {
                    ReallyToughTask();
                }
            }
        }
        //得知任務運行時間
        Debug.Log(((Time.realtimeSinceStartup - startTime) * 1000f) + "ms");
    }

    /// <summary>
    /// 一個大型循環路徑任務
    /// </summary>
    private void ReallyToughTask() {
        float value = 0f;
        for (int i = 0; i < 50000; i++)
            value = math.exp10(math.sqrt(value));
        //會重復特定的運算五萬次
        // Represents a tough task like some pathfinding or really complex calculation
    }

    /// <summary>
    /// 安排JOB多線程方法
    /// </summary>
    /// <returns></returns>
    private JobHandle ReallyToughTaskJob() {
        ReallToughJob job = new ReallToughJob();
        return job.Schedule();//在可能的線程上安排這個Job
    }
}

/// <summary>
/// Job的編寫
/// BurstCompile只要寫在這就好
/// </summary>
[BurstCompile]
public struct ReallToughJob : IJob {
    //public float something; //可自行加入Job所需額外片段
    public void Execute() {
        float value = 0f;
        for (int i = 0; i < 50000; i++)
            value = math.exp10(math.sqrt(value));
    }
}
/*
 先編寫一個 Job行為的 struct結構
 接著創建一個Job實例
 在Job上排布Job
 然後讓 JobHandle系統完成這個Job
*/

/* 單線程測試 其實沒有差別
    private void Update() {
        //紀錄啟動以來的時間
        float startTime = Time.realtimeSinceStartup;
        if (useJobs) { //Job版執行
            JobHandle jobHandle = ReallyToughTaskJob();
            jobHandle.Complete();// Complete會暫停主線 直到Job完成後再繼續
        }
        else { //一般版本
            ReallyToughTask();
        }
        //得知任務運行時間
        Debug.Log(((Time.realtimeSinceStartup - startTime) * 1000f) + "ms");        
    }
*/

[BurstCompile]
public struct ReallToughParallelJob : IJobParallelFor
{
    //V3那些只能用在主線程 這邊得改
    //數組的方式如下
    public NativeArray<float3> position;
    public NativeArray<float> moveY;
    [ReadOnly] public float deltaTime;

    public void Execute(int index)
    {
        position[index] += new float3(0, moveY[index] * deltaTime, 0f);

        if (position[index].y > 5f)
        {
            moveY[index] = -math.abs(moveY[index]);
        }
        if (position[index].y < -5f)
        {
            moveY[index] = +math.abs(moveY[index]);
        }
        float value = 0f;
        for (int i = 0; i < 500; i++)
        {
            value = math.exp10(math.sqrt(value));
        }
    }
}