using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    [System.Serializable]
    public class MovementSettings{
        public float forwardVelocity = 10;
        public float jumpVelocity = 20; 
    }
    [System.Serializable]
    public class PhysicsSettings{
        public float downAccel = 0.75f;
    }

    public MovementSettings movementSettings = new MovementSettings();
    public PhysicsSettings physicsSettings = new PhysicsSettings();

    public Vector3 _velocity;
    public float xSpeed = 10;
    public bool isDead = false;

    private Rigidbody _rigidbody;
    private Animator _animator;
    private int _jumpInput = 0;
    private bool _onGround = false;
    private float _xMovement;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
        _velocity = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        InputHandling();
        Run();
        CheckGround();
        Jump();
        changeAnimation();
        MoveX();
        Stop();
        _rigidbody.velocity = _velocity;
    }
    void Run(){
        _velocity.z = movementSettings.forwardVelocity;
    }
    void Jump(){
        if(_jumpInput == 1 && _onGround){
            _velocity.y = movementSettings.jumpVelocity;
            _animator.SetTrigger("Jump");
        }
        else if(_jumpInput == 0 && _onGround){
            _velocity.y = 0;
        }
        else {
            _velocity.y -= physicsSettings.downAccel;
        }
        _jumpInput = 0;
    }
    void CheckGround(){
        Ray ray = new Ray(transform.position + Vector3.up * 0.1f, Vector3.down);
        RaycastHit[] hits = Physics.RaycastAll (ray, 0.5f);
        _onGround = false;
        _rigidbody.useGravity = true;
        foreach(var hit in hits){

            if(!hit.collider.isTrigger){
                if(_velocity.y <= 0){
                    _rigidbody.position = Vector3.MoveTowards (_rigidbody.position, 
                    new Vector3(hit.point.x, hit.point.y + 0.1f, hit.point.z), Time.deltaTime *10);
                }
                _rigidbody.useGravity = false;
                _onGround = true;
                break;
            }
        }
    }
    void MoveX(){
        transform.position = Vector3.MoveTowards(transform.position, new Vector3 (_xMovement, transform.position.y, transform.position.z),Time.deltaTime*xSpeed);
    }
   
    void InputHandling(){
        if(Input.GetKeyDown (KeyCode.Space)){
            _jumpInput = 1;
        }
        else if(Input.GetKeyDown(KeyCode.D)){
            if(_xMovement == 0){
                _xMovement = 2.5f;
            } else if (_xMovement == -2.5f){
                _xMovement = 0;
            }

        }
        else if(Input.GetKeyDown(KeyCode.A)){
            if (_xMovement == 0){
                _xMovement = -2.5f;
            } else if(_xMovement == 2.5f){
                _xMovement =  0;
            } 
            
        }
    }
    void changeAnimation(){
        int energy=Sliderr.slidervalue;
        if (energy==0){
             _animator.SetTrigger("Zombie Death");
             movementSettings.forwardVelocity=0;
             isDead=true;
        }
        else if (energy<=4){
             _animator.SetTrigger("Injured Walk");
             movementSettings.forwardVelocity=4;
        }
        else if (energy<=8){
             _animator.SetTrigger("Injured Run");
             movementSettings.forwardVelocity=5;
        }
        else if (energy<=12){
             _animator.SetTrigger("Running");
             movementSettings.forwardVelocity=7;
        }
        else {
             _animator.SetTrigger("Running");
             movementSettings.forwardVelocity=10;
        }
        
    }
    public void Stop(){
      //  finish f = new finish();
        
        if(transform.position.z >= 180){
            
             _animator.SetTrigger("Macarena Dance");
            movementSettings.forwardVelocity = 0; 
            
        }
    }

}
