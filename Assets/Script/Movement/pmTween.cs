using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class pmTween
    {
        public Transform Pacman
        { get; private set; }
        public Vector3 pmStartPosition
        { get; private set; }
        public Vector3 pmEndPosition
        { get; private set; }
        public float pmTime
        { get; private set; }
        public float pmDur
        { get; private set; }

        public pmTween(Transform pacman, Vector3 pmstartposition, Vector3 pmendposition, float pmtime, float pmdur)
        {
            this.pmEndPosition = pmendposition;
            this.Pacman = pacman;
            this.pmStartPosition = pmstartposition;
           
            this.pmTime = pmtime;
            this.pmDur = pmdur;
        }
    }

