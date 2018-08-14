using UnityEngine;

public class LevelSelector : MonoBehaviour {

    public SceneFader sceneFader;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Select (string levelName)
    {

        sceneFader.FadeTo(levelName);

    }

}
