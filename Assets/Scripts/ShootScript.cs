using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;

    public void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "Baloon1(Clone)")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
