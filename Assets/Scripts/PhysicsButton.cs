using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PhysicsButton : MonoBehaviour
{
    [SerializeField] private float threashold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;

    private bool _isPressed;
    private Vector3 _startPostion;
    private ConfigurableJoint _joint;

    public UnityEvent onPressed, onReleased;

    // Start is called before the first frame update
    void Start()
    {
        _startPostion = transform.localPosition;
        _joint = GetComponent<ConfigurableJoint>();
    }

    // Update is called once per frame
    void Update()
    {
       if(!_isPressed && GetValue() + threashold >= 1)
        {
            Pressed();
        } 
       if(_isPressed && GetValue() + threashold <= 0.2)
        {
            Released();
        }
    }

    private float GetValue()
    {
        var value = Vector3.Distance(_startPostion, transform.localPosition) / _joint.linearLimit.limit;
        if(Mathf.Abs(value) < deadZone)
        {
            value = 0;
        }
        return Mathf.Clamp(value, -1f, 1f);

    }

    public void Pressed()
    {
        _isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    public void Released()
    {
        _isPressed = false;
        onReleased.Invoke();
        Debug.Log("Released");

    }
}
