using UnityEngine;
using UnityEngine.SceneManagement;
public class plsmove : MonoBehaviour
{
   private Rigidbody _rigidbody;
    
    [SerializeField] private float _movementForce = 10f;
    
    [SerializeField] private float _turnSpeed = 3f;

    [SerializeField] private float _jumpForce = 300f;

    [SerializeField] private double _maximumVelocity = 10f;

    float horizontal;

    //private bool _shouldJump;

    public LayerMask groundLayers;
    private SphereCollider col;

#region Monobehaviour API

    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
        col = GetComponent<SphereCollider>();

    }


    private void Update()
    {
        
         horizontal = Input.GetAxis("Horizontal");

         if(transform.position.y< -1f)
            Restart();

        /*if (_shouldJump == false)
            _shouldJump = Input.GetKeyDown(KeyCode.Space);*/
    }

    private void FixedUpdate()
    {
        transform.Rotate(horizontal * _turnSpeed * Vector3.up, Space.World);

        if (_rigidbody.velocity.magnitude >= _maximumVelocity)
            return;

        if (Input.GetKey(KeyCode.W))
            _rigidbody.AddForce(_movementForce * transform.forward);
        
        if (Input.GetKey(KeyCode.S))
            _rigidbody.AddForce(_movementForce * -transform.forward); // -forward gives us back

        /*if (Input.GetKey(KeyCode.D))
            _rigidbody.AddForce(_movementForce * transform.right);
        
        if (Input.GetKey(KeyCode.A))
            _rigidbody.AddForce(_movementForce * -transform.right); // -right gives us left
        */
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {            
            _rigidbody.AddForce(_jumpForce * transform.up);
            //_shouldJump = false;
        }
       
    }
    private bool IsGrounded()
    {
        return Physics.CheckCapsule(col.bounds.center, new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z), col.radius * .9f, groundLayers);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



#endregion

}
