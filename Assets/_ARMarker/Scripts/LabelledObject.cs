using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class LabelledObject : MonoBehaviour
{
    private Camera cam;
    private LineRenderer lineRenderer;

    // Game objects for drawing line betweem
    [SerializeField] GameObject source;
    [SerializeField] GameObject target;

    // labels
    [SerializeField] TMP_Text m_text;
    public Transform label;

    // width of line renderer
    [SerializeField] float linewidth = 0.001f;

    Vector2 mainCam;

    void Start()
    {
        cam = Camera.main;

        // get line rendered from game object
        lineRenderer = GetComponent<LineRenderer>();
        m_text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        // make label face camera
        label.transform.LookAt(transform.position + cam.transform.rotation * Vector3.forward, cam.transform.rotation * Vector3.up);
        label.Rotate(0, 180f, 0);

        // Draw the line between source and target using line renderer
        if (source != null && target != null)
        {
            Vector3[] pos = new Vector3[] { source.transform.position, target.transform.position };
            lineRenderer.SetPositions(pos);
            lineRenderer.startWidth = linewidth;
            lineRenderer.startColor = Color.black;
        }
    }

}