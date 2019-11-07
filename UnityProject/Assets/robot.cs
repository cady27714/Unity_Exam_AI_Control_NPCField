using UnityEngine;

public class robot : MonoBehaviour
{
    public int speed = 20;
    public float jump = 2.0f;
    public string robotName = "機器人";
    public bool isground = false;

    private Rigidbody2D r2d;

    private void Start()
    {
        r2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D)) transform.eulerAngles = new Vector3(0, 0, 0);
        if (Input.GetKeyDown(KeyCode.A)) transform.eulerAngles = new Vector3(0, 180, 0);
    }
    private void FixedUpdate()
    {
        Walk();
    }

    //<summary>
    //走路
    //</summary>

    private void Walk()
    {
        r2d.AddForce(new Vector2(speed * Input.GetAxis("走路"), 0));
    }
    }
