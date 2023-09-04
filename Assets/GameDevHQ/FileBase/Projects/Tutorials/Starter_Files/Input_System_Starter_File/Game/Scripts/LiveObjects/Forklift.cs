using System;
using UnityEngine;
using Cinemachine;

namespace Game.Scripts.LiveObjects
{
    public class Forklift : MonoBehaviour
    {
        [SerializeField]
        private GameObject _lift, _steeringWheel, _leftWheel, _rightWheel, _rearWheels;
        [SerializeField]
        private Vector3 _liftLowerLimit, _liftUpperLimit;
        [SerializeField]
        private float _speed = 5f, _liftSpeed = 1f;
        [SerializeField]
        private CinemachineVirtualCamera _forkliftCam;
        [SerializeField]
        private GameObject _driverModel;
        private bool _inDriveMode = false;
        [SerializeField]
        private InteractableZone _interactableZone;

        public static event Action onDriveModeEntered;
        public static event Action onDriveModeExited;


        private PlayerInputActions _input;

        private bool _liftPressed;

        private void Start()
        {
            _input = new PlayerInputActions();
            _input.Forklift.Enable();
            _input.Forklift.Movement.performed += Movement_performed;
            _input.Forklift.Lift.performed += Lift_performed;
            _input.Forklift.Lift.canceled += Lift_canceled;
        }

        private void Lift_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            //Lift Canceled
        }

        private void Lift_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            //Lift
        }

        private void Movement_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            //Movement
        }

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += EnterDriveMode;
        }

        private void EnterDriveMode(InteractableZone zone)
        {
            if (_inDriveMode !=true && zone.GetZoneID() == 5) //Enter ForkLift
            {
                _inDriveMode = true;
                _forkliftCam.Priority = 11;
                onDriveModeEntered?.Invoke();
                _driverModel.SetActive(true);
                _interactableZone.CompleteTask(5);
            }
        }

        private void ExitDriveMode()
        {
            _inDriveMode = false;
            _forkliftCam.Priority = 9;            
            _driverModel.SetActive(false);
            onDriveModeExited?.Invoke();
            
        }

        private void Update()
        {
            if (_inDriveMode == true)
            {
                LiftControls();
                CalcutateMovement();
                if (Input.GetKeyDown(KeyCode.Escape))
                    ExitDriveMode();
            }

        }

        private void CalcutateMovement()
        {
            
            var move = _input.Forklift.Movement.ReadValue<Vector2>();

            var direction = transform.forward * move.y;
            var velocity = direction * _speed;

            

            if (Mathf.Abs(velocity.y) > 0)
            {
                var tempRot = transform.rotation.eulerAngles;
                //tempRot.y += move.y * _speed / 2;
                tempRot.y += move.x * _speed / 2;
                transform.rotation = Quaternion.Euler(tempRot);
                transform.Translate(velocity * Time.deltaTime);

            }

            //float h = Input.GetAxisRaw("Horizontal");
            //float v = Input.GetAxisRaw("Vertical");

            //var direction = new Vector3(0, 0, v);
            //var velocity = direction * _speed;

            //transform.Translate(velocity * Time.deltaTime);

            //if (Mathf.Abs(v) > 0)
            //{
            //    var tempRot = transform.rotation.eulerAngles;
            //    tempRot.y += h * _speed / 2;
            //    transform.rotation = Quaternion.Euler(tempRot);
            //}
        }

        private void LiftControls()
        {
            
            //if (Input.GetKey(KeyCode.R))
            //    LiftUpRoutine();
            //else if (Input.GetKey(KeyCode.T))
            //    LiftDownRoutine();

            var liftInput = _input.Forklift.Lift.ReadValue<float>();

            if (liftInput > 0)
            {
                LiftUpRoutine();
            }
            else if (liftInput < 0)
            {
                LiftDownRoutine();
            }

        }

        private void LiftUpRoutine()
        {
            //_liftUp = true;
            if (_lift.transform.localPosition.y < _liftUpperLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y += Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
                Debug.Log("Lift Up was Performed");
            }
            else if (_lift.transform.localPosition.y >= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftUpperLimit;
        }

        private void LiftDownRoutine()
        {
            //_liftUp = false;

            if (_lift.transform.localPosition.y > _liftLowerLimit.y)
            {
                Vector3 tempPos = _lift.transform.localPosition;
                tempPos.y -= Time.deltaTime * _liftSpeed;
                _lift.transform.localPosition = new Vector3(tempPos.x, tempPos.y, tempPos.z);
                Debug.Log("LiftDow nwas performed");
            }
            else if (_lift.transform.localPosition.y <= _liftUpperLimit.y)
                _lift.transform.localPosition = _liftLowerLimit;
        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= EnterDriveMode;
        }

    }
}