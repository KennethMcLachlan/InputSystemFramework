﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

namespace Game.Scripts.LiveObjects
{
    public class Laptop : MonoBehaviour
    {
        [SerializeField]
        private Slider _progressBar;
        [SerializeField]
        private int _hackTime = 5;
        private bool _hacked = false;
        [SerializeField]
        private CinemachineVirtualCamera[] _cameras;
        private int _activeCamera = 0;
        [SerializeField]
        private InteractableZone _interactableZone;

        //public int zoneID;

        public static event Action onHackComplete;
        public static event Action onHackEnded;

        private PlayerInputActions _input;

        private void Start()
        {
            _input = new PlayerInputActions();
            _input.Player.Enable();
            _input.Player.Interact.performed += Interact_performed;
            _input.Player.Interact.canceled += Interact_canceled;
            _input.Player.CamEscape.performed += CamEscape_performed;
            _input.Player.CamEscape.canceled += CamEscape_canceled;
        }

        private void CamEscape_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            //CamEscapeCanceled
        }

        private void CamEscape_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
        {
            //Cancel Performed
        }

        private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            //    //    //Interact Input

            //    //////_progressBar.gameObject.SetActive(true);
            //    //////StartCoroutine(HackingRoutine());
            //    //////onHackComplete?.Invoke();

            //    //    //InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;

            //    //    //OnEnable();

            //    //    //if (zoneID == 3 && _hacked == false) //Hacking terminal
            //    //    //{
            //    //    //    _progressBar.gameObject.SetActive(true);
            //    //    //    StartCoroutine(HackingRoutine());
            //    //    //    onHackComplete?.Invoke();
            //    //    //}


        }

        private void Interact_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
        {
            //    //    ////////if (_hacked == true)
            //    //    ////////    return;

            //    //    ////////StopAllCoroutines();
            //    //    ////////_progressBar.gameObject.SetActive(false);
            //    //    ////////_progressBar.value = 0;
            //    //    ////////onHackEnded?.Invoke();

            //    //    //InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;

            //    //    //OnDisable();

            //    //    //if (zoneID == 3) //Hacking terminal
            //    //    //{
            //    //    //    if (_hacked == true)
            //    //    //        return;

            //    //    //    StopAllCoroutines();
            //    //    //    _progressBar.gameObject.SetActive(false);
            //    //    //    _progressBar.value = 0;
            //    //    //    onHackEnded?.Invoke();
            //    //    //}



        }

        private void OnEnable()
        {
            InteractableZone.onHoldStarted += InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded += InteractableZone_onHoldEnded;
        }


        

        private void Update()
        {
            if (_hacked == true)
            {
                var interact = _input.Player.Interact.WasPressedThisFrame();

                var escape = _input.Player.CamEscape.WasPressedThisFrame();

                if (interact)
                {
                    var previous = _activeCamera;
                    _activeCamera++;


                    if (_activeCamera >= _cameras.Length)
                        _activeCamera = 0;


                    _cameras[_activeCamera].Priority = 11;
                    _cameras[previous].Priority = 9;
                }

                if (escape)
                {
                    _hacked = false;
                    onHackEnded?.Invoke();
                    ResetCameras();
                }

                //if (Input.GetKeyDown(KeyCode.E))
                //{
                //    var previous = _activeCamera;
                //    _activeCamera++;


                //    if (_activeCamera >= _cameras.Length)
                //        _activeCamera = 0;


                //    _cameras[_activeCamera].Priority = 11;
                //    _cameras[previous].Priority = 9;
                //}

                //if (Input.GetKeyDown(KeyCode.Escape))
                //{
                //    _hacked = false;
                //    onHackEnded?.Invoke();
                //    ResetCameras();
                //}

            }
        }

        void ResetCameras()
        {
            foreach (var cam in _cameras)
            {
                cam.Priority = 9;
            }
        }

        private void InteractableZone_onHoldStarted(int zoneID)
        {

            if (zoneID == 3 && _hacked == false) //Hacking terminal
            {
                _progressBar.gameObject.SetActive(true);

                StartCoroutine(HackingRoutine());
                onHackComplete?.Invoke();
            }
        }

        private void InteractableZone_onHoldEnded(int zoneID)
        {

            if (zoneID == 3) //Hacking terminal
            {
                if (_hacked == true)
                    return;

                StopAllCoroutines();
                _progressBar.gameObject.SetActive(false);
                _progressBar.value = 0;
                onHackEnded?.Invoke();
            }
        }


        IEnumerator HackingRoutine()
        {
            while (_progressBar.value < 1)
            {
                _progressBar.value += Time.deltaTime / _hackTime;
                yield return new WaitForEndOfFrame();
            }

            //successfully hacked
            _hacked = true;
            _interactableZone.CompleteTask(3);

            //hide progress bar
            _progressBar.gameObject.SetActive(false);

            //enable Vcam1
            _cameras[0].Priority = 11;
        }

        private void OnDisable()
        {
            InteractableZone.onHoldStarted -= InteractableZone_onHoldStarted;
            InteractableZone.onHoldEnded -= InteractableZone_onHoldEnded;
        }
    }

}

