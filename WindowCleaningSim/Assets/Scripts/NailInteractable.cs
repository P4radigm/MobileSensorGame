using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NailInteractable : MonoBehaviour
{
    private Transform mainTransform;
    [SerializeField] private Transform hammerTransform;
    private Quaternion initialRotation;
    [SerializeField] private float yStart;
    [SerializeField] private float yEnd;

    [SerializeField] private float rotAngle;
    public float RotAngle
    {
        get { return rotAngle; }
        set
        {
            if (value >= 2 && rotAngle < 2)
            {
                OnHit();
            }
            rotAngle = value;
        }
    }
    private float hammerRotAngle;
    public float HammerRotAngle
    {
        get { return hammerRotAngle; }
        set
        {
            if (value >= 3)
            {
                value = 3;
            }
        }
    }
    
    [SerializeField] private float gravityMeasure1;
    [SerializeField] private float gravityMeasure2;
    [SerializeField] private float gmAccuracy;
    private bool firstCalibration = false;
    [SerializeField] private float progress = 0;
    [SerializeField] private float progressNeeded = 5;
    [SerializeField] private float topAngle = -10;
    [SerializeField] private bool makeProgressEnabled = false;





    private UnityEngine.Gyroscope m_Gyro;

    // Start is called before the first frame update
    void Start()
    {
        mainTransform = this.transform;
        initialRotation = hammerTransform.rotation;
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
        m_Gyro.updateInterval = 0.02f;
        firstCalibration = false;
    }

    // Update is called once per frame
    void Update()
    {
        mainTransform.position = new Vector3(mainTransform.position.x, Mathf.Lerp(yStart, yEnd, progress/progressNeeded), mainTransform.position.z);

        if (firstCalibration)
        {                        
            RotAngle += m_Gyro.rotationRateUnbiased.z;
            hammerTransform.rotation = Quaternion.AngleAxis(HammerRotAngle, new Vector3(0, 0, 1)) * initialRotation;
        }

        if (RotAngle < 3)
        {
            hammerRotAngle = RotAngle;
        }
        else
        {
            hammerRotAngle = 3;
        }

        if(Mathf.Round(m_Gyro.gravity.x * 100) / 100 > gravityMeasure1 || Mathf.Round(m_Gyro.gravity.x * 100) / 100 < -gravityMeasure1)
        {
            Debug.Log("first round");
            if (Mathf.Round(m_Gyro.gravity.y * 100) / 100 > (gravityMeasure2 - gmAccuracy) && Mathf.Round(m_Gyro.gravity.y * 100) / 100 < (gravityMeasure2 + gmAccuracy))
            {
                if (firstCalibration)
                {
                    Debug.Log("Ayy Calibrated Hammer");
                    RotAngle = 3;
                }
                if (!firstCalibration)
                firstCalibration = true; Debug.Log("Calibrated Hammer"); RotAngle = 3;
            }
        }

        if (RotAngle < topAngle)
        {
            makeProgressEnabled = true;
        }
    }

    void OnHit()
    {
        if(makeProgressEnabled)
        progress++; makeProgressEnabled = false;
    }
}
