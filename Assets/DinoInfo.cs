using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DinoInfo : MonoBehaviour {

	public GameObject dinoImageTarget;
	public Text infoText;
	bool isPressed = false;


	void Update(){
		if (isPressed) {
			Allosaurus ();
			TRex ();
		} else {
			infoText.enabled = false;
		}
	}

	public void Allosaurus(){
		if (dinoImageTarget.name == "AllosaurusImageTarget") {
			infoText.enabled = true;
		}
	}

	public void TRex(){
		if (dinoImageTarget.name == "T-RexImageTarget") {
			infoText.enabled = true;
		}
	}

	public void ToggleChanged(bool newValue){
		isPressed = newValue;
	}

}
