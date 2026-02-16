using UnityEngine;

public class Heart : MonoBehaviour
{

    [SerializeField] GameObject heartModel;
    void Start()
    {
        // face camera
        heartModel.transform.LookAt(Camera.main.transform);
    }
    void Update()
    {
        
    }
}
