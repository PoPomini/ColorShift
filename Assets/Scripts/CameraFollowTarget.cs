using UnityEngine;

public class CameraFollowTarget : MonoBehaviour
{
    [SerializeField]
    private Transform target; // The target to follow

    [SerializeField]
    private float yOffset = 3f; // Vertical offset from the target

    private void LateUpdate()
    {
        // 타겟이 할당되지 않았을 때만 실행 중단
        if (target == null)
        {
            return;
        }

        transform.position = new Vector3(0f, target.position.y + yOffset, transform.position.z);
    }
}