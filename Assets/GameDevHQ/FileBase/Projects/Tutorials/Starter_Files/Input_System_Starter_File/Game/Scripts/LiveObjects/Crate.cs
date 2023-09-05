using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.UI;

namespace Game.Scripts.LiveObjects
{
    public class Crate : MonoBehaviour
    {
        [SerializeField] private float _punchDelay;
        [SerializeField] private GameObject _wholeCrate, _brokenCrate;
        [SerializeField] private Rigidbody[] _pieces;
        [SerializeField] private BoxCollider _crateCollider;
        [SerializeField] private InteractableZone _interactableZone;
        private bool _isReadyToBreak = false;

        private List<Rigidbody> _brakeOff = new List<Rigidbody>();

        private PlayerInputActions _input;

        private bool _destroyHasStarted;
        private bool _destroyIsHeld;

        private float _holdStartTime;

        private void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;

            _input = new PlayerInputActions();
            _input.Crate.Enable();
            _input.Crate.Destroy.started += ctx => Destroy_started(ctx);
            _input.Crate.Destroy.canceled += ctx => Destroy_canceled(ctx);
            _input.Crate.Destroy.performed += ctx => Destroy_performed(ctx);
        }

        private void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            var destroyPressed = _destroyHasStarted;

            var destroyReleased = _input.Crate.Destroy.WasReleasedThisFrame();

            if (_isReadyToBreak && _brakeOff.Count > 0)
            {
                _destroyHasStarted = true;

                _wholeCrate.SetActive(false);
                _brokenCrate.SetActive(true);
                _isReadyToBreak = true;
            }

            if (_isReadyToBreak && zone.GetZoneID() == 6) //Crate zone            
            {
                if (_destroyHasStarted && _brakeOff.Count > 0)
                {
                    destroyPressed = true;
                    BreakPart();
                    Debug.Log("BreakPart commenced");
                    StartCoroutine(PunchDelay());
                    
                }
                else if(_destroyHasStarted && _brakeOff.Count == 0)
                {
                    _isReadyToBreak = false;
                    _crateCollider.enabled = false;
                    _interactableZone.CompleteTask(6);
                    _destroyHasStarted = false;
                    //destroyReleased = true;
                    Debug.Log("Completely Busted");
                }
            }
        }


        private void Start()
        {
            //_input = new PlayerInputActions();
            //_input.Crate.Enable();
            //_input.Crate.Destroy.started += Destroy_started;
            //_input.Crate.Destroy.canceled += Destroy_canceled;
            //_input.Crate.Destroy.performed += Destroy_performed;

            _brakeOff.AddRange(_pieces);

            //_input.Enable();
        }


        private void Destroy_started(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            _destroyHasStarted = true;
            _holdStartTime = Time.time;
            Debug.Log("Destroy Started");
        }

        private void OnDestroy()
        {
            _input.Disable();
        }

        private void Destroy_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            //Canceled
            //context.duration
            //var forceEffect = context.duration;
            //var destroyReleased = _input.Crate.Destroy.WasReleasedThisFrame();
            _destroyHasStarted = false;
            Debug.Log("Destroy Canceled");
        }

        private void Destroy_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            if (_destroyHasStarted)
            {
                float holdDuration = Time.time - _holdStartTime;
                int piecesToBreak = Mathf.FloorToInt(holdDuration / _punchDelay);
                for (int i = 0; i < piecesToBreak; i++)
                {
                    BreakPart();
                }
                Debug.Log("Destroyed " + piecesToBreak + " pieces");

            }
            //Performed
            // Use _isReadyToBreak
            //StartCoroutine(PunchDelay());
            //_destroyIsHeld = true;
            //Debug.Log("Destroy Performed");
        }

        public void BreakPart()
        {
            int rng = Random.Range(0, _brakeOff.Count);
            _brakeOff[rng].constraints = RigidbodyConstraints.None;
            _brakeOff[rng].AddForce(new Vector3(1f, 1f, 1f), ForceMode.Force);
            _brakeOff.Remove(_brakeOff[rng]);            
        }

        IEnumerator PunchDelay()
        {

            float delayTimer = 0;
            while (delayTimer < _punchDelay)
            {
                yield return new WaitForEndOfFrame();
                delayTimer += Time.deltaTime;
            }

            Debug.Log("Punch Delay Coroutine has run");

            _interactableZone.ResetAction(6);
            //_destroyIsHeld = false;


        }

        private void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
        }
    }
}
