﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortraitOrientation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.orientation = ScreenOrientation.Portrait;
        InAppBrowser.ClearCache();
}
}
