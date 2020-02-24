using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrewInteractable : MonoBehaviour
{
    [SerializeField] private Transform startTransform;
    [SerializeField] private float yStart;
    [SerializeField] private float yEnd;
    [SerializeField] private float turnsNeeded = 1;

    [SerializeField] private float rotateAngle;
    [SerializeField] private float animRotateAngle;
    [SerializeField] private float gravityMeasure;

    private bool oneTimeCheck = true;
    private bool backBool = true;

    UnityEngine.Gyroscope m_Gyro;

    // Start is called before the first frame update
    void Start()
    {
        startTransform = this.transform;
        yStart = startTransform.position.y;
        yEnd = yStart - 0.3f;
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        m_Gyro.updateInterval = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateAngle < -360 * turnsNeeded)
        {
            rotateAngle = -360 * turnsNeeded;
        }
        if (rotateAngle >= 360)
        {
            rotateAngle = 0;
        }
        

        if (SystemInfo.supportsGyroscope)
        {
            if (Mathf.Round(m_Gyro.gravity.y * 100) / 100 > gravityMeasure)
            {
               rotateAngle += m_Gyro.rotationRateUnbiased.y;
            }
            transform.rotation = Quaternion.AngleAxis(rotateAngle, Vector3.up);
            transform.position = new Vector3(startTransform.position.x, Mathf.Lerp(yStart, yEnd, rotateAngle / (-360 * turnsNeeded)), startTransform.position.z);
        }
        else
        {
            Debug.LogError("No gyro support");
        }
    }
}
