using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class MyOnScreenJoystick : EventTrigger
{
    private Vector3 myPosition;
    private Vector3 startPosition;
    private float distance = 0.0f;

    public override void OnInitializePotentialDrag(PointerEventData data)
    {
        myPosition = transform.position;
        startPosition = Camera.main.ScreenToWorldPoint(data.position);
    }
    public override void OnBeginDrag(PointerEventData data)
    {
        Mueve(data);
    }
    public override void OnDrag(PointerEventData data)
    {
        Mueve(data);
    }
    public override void OnEndDrag(PointerEventData data)
    {
        transform.position = myPosition;
        distance = 0.0f;
    }
    private void Mueve(PointerEventData data)
    {
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(data.position);
        float diffX = newPosition.x - startPosition.x;
        float diffY = newPosition.y - startPosition.y;

        if (Math.Abs(diffX) < 1.0f && Math.Abs(diffY) < 1.0f)
        {
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
            distance = diffX;
        }
    }
    public float GetDistance()
    {
        return distance;
    }
}
