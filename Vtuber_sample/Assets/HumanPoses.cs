using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class HumanPoses : MonoBehaviour {

	 [System.SerializableAttribute]

     public class SrializeHumanPoses
    {
        public Vector3 bodyPosition;
        public Quaternion bodyRotaion;
        public float[] muscles;
        public int frameCount;
    }


    void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
}
