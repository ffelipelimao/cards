using System;
using UnityEngine;

public class CardFace : MonoBehaviour
{
   public GameObject target;
    public float rotationSpeed;
    public float rotationAmount;

    Vector3 rotation;
    Vector3 movement;

    private float randomRot;

    private void Start()
    {
        randomRot = UnityEngine.Random.Range(-rotationAmount, rotationSpeed);

    }

    private void Update()
    {
        if (!target.GetComponent<Card>().Played)
        {
            transform.position = Vector2.Lerp(transform.position, target.transform.position, Time.deltaTime * 25);
            Vector3 pos = (transform.position - target.transform.position);
            Vector3 movementRotation;

            movement = Vector3.Lerp(movement, pos, Time.deltaTime * 25);

            movementRotation = movement;

            rotation = Vector3.Lerp(rotation, movementRotation, rotationSpeed * Time.deltaTime);

            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, Math.Clamp(movementRotation.x, -rotationAmount, rotationAmount));

        }
        else
        {
             transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, randomRot);
        }
    }
}
