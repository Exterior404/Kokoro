using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;

public class System_Fps : MonoBehaviour
{//用來顯示遊戲資源的腳本
    public Text txt;
    string info, fps;

    void Start()
    {
        Application.targetFrameRate = 1000;
        info = "\n"
        + "獨顯存：" + SystemInfo.graphicsMemorySize + "mb\n"
        + "記憶體：" + SystemInfo.systemMemorySize + "mb\n"
        + "保留記憶體：" + (Profiler.GetTotalReservedMemoryLong() / 1024f / 1024f) + "mb\n"
        + "保留未分配：" + (Profiler.GetTotalUnusedReservedMemoryLong() / 1024f / 1024f) + "mb\n"
        + "分配記憶體：" + (Profiler.GetTotalAllocatedMemoryLong() / 1024f / 1024f) + "mb\n"
        + SystemInfo.copyTextureSupport;
        StartCoroutine(FPS());
    }

    int lastFrameCount, frameCount;
    float lastTime, timeSpan;

    private IEnumerator FPS()
    {
        for (; ; )
        {
            // Capture frame-per-second
            lastFrameCount = Time.frameCount;
            lastTime = Time.realtimeSinceStartup;
            yield return new WaitForSeconds(1);
            timeSpan = Time.realtimeSinceStartup - lastTime;
            frameCount = Time.frameCount - lastFrameCount;
            fps = string.Format("FPS: {0}", Mathf.RoundToInt(frameCount / timeSpan));
            txt.text = fps + info;
        }
    }
}