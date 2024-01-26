using Cinemachine;
using UnityEngine;

public class ZoomInOut : MonoBehaviour
{
    private DynamicJoystick dynamicJoystick;
    private FixedJoystick _fixedJoystick;
    private CinemachineVirtualCamera cm;
    private CinemachineTransposer cmF;
    private float touchesPrevPosDif, touchesCurPosDif;
    [Range(10, 30)] public float zoomModifier;
    private Vector2 firstTouchPrevPos, secondTouchPrevPos;
    [SerializeField] private float zoomModifierSpeed = .1f;

    // Start is called before the first frame update
    void Start()
    {
        dynamicJoystick = FindObjectOfType<DynamicJoystick>();
        cm = GetComponent<CinemachineVirtualCamera>();
        cmF = cm.GetCinemachineComponent<CinemachineTransposer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 2 && !dynamicJoystick.IsDown && !_fixedJoystick.IsDown)
        {
            Touch firstTouch = Input.GetTouch(0);
            Touch seconTouch = Input.GetTouch(1);

            firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
            secondTouchPrevPos = seconTouch.position - seconTouch.deltaPosition;

            touchesPrevPosDif = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
            touchesCurPosDif = (firstTouch.position - seconTouch.position).magnitude;

            zoomModifier = (firstTouch.deltaPosition - seconTouch.deltaPosition).magnitude * zoomModifierSpeed;

            if (touchesPrevPosDif > touchesCurPosDif)
                cm.m_Lens.FieldOfView += zoomModifier;
            if (touchesPrevPosDif < touchesCurPosDif)
                cm.m_Lens.FieldOfView -= zoomModifier;
        }
        cmF.m_FollowOffset = new Vector3(0, zoomModifier, -zoomModifier-3);
    }
}