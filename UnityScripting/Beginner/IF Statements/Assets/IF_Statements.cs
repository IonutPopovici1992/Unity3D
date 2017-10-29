using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IF_Statements : MonoBehaviour {

    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;

	// Use this for initialization
	void Start() {
		
	}
	
	// Update is called once per frame
	void Update() {
		
        if (Input.GetKeyDown(KeyCode.Space)) {
            TemperatureTest();
        }

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    void TemperatureTest() {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature) {
            // ... do this.
            print("Coffee is too hot.");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature) {
            // ... do this.
            print("Coffee is too cold.");
        } else {
            // If it is neither of those then...
            print("Coffee is just right.");
        }

    }

}
