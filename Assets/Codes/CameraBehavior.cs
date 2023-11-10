using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public GameObject cameraCollider;
    // Start is called before the first frame update
    private bool isCameraActive = false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!isCameraActive)
            {
                StartCoroutine(ActivateForDuration(0.5f));
            }
        }
    }

    private IEnumerator ActivateForDuration(float duration)
    {
        isCameraActive = true;
        cameraCollider.SetActive(true);

        yield return new WaitForSeconds(duration);

        cameraCollider.SetActive(false);
        isCameraActive = false;
    }
}
