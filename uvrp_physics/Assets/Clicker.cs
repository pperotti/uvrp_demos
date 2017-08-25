using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour {
	public bool clicked() {
		return Input.anyKeyDown;
	}
}
