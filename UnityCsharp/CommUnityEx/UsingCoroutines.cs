using UnityEngine;
using System.Collections;

public class UsingCoroutines : MonoBehaviour
{
    public float smoothing = 1;
    public Transform target;

    private void Start()
    {
        StartCoroutine(MyCoroutine(target));
        //StopCoroutine(MyCoroutine(target));
    }

    IEnumerator MyCoroutine(Transform target)
    {
        while (Vector3.Distance(transform.position, target.position) > 0.05f)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, smoothing * Time.deltaTime);

            yield return null;
        }
        Debug.Log("Reached the target.");
        yield return new WaitForSeconds(3f);
        Debug.Log("MyCoroutine");
    }
}
/*
Coroutines
協同程序可被視作
按時間間隔執行的函數

這類函數與特殊的Yield語句搭配使用
Yield語句從函數中返回代碼執行

null 將分開繼續執行中

 */