using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour
{

    private Transform followTfm;

    float smoothTime = 0.5f;

    Vector3 velocity = Vector3.zero;

    void Start()
    {
        followTfm = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // 追従対象オブジェクトのTransformから、目的地を算出
        Vector3 targetPos = followTfm.TransformPoint(new Vector3(0.5f, 1.0f, -1.0f));

        // 移動
        transform.position =
            Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

    }
}