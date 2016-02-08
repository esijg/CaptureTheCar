using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

	public int NumberOfPlayers = 4;
	Object[] CarPrefabs;
	GameObject[] PlayerCameras;

	GameObject p1;
	GameObject p2;
	GameObject p3;
	GameObject p4;

	Camera[] p1Camera;
	Camera[] p2Camera;
	Camera[] p3Camera;
	Camera[] p4Camera;

	Object overviewCamera;
	GameObject overviewCameraClone;

	// Use this for initialization
	void Start () {
		SpawnPlayers();
		AdjustCameras();
	}

	void SpawnPlayers () {
		// Load all Car prefabs
		CarPrefabs = new Object[4];
		CarPrefabs[0] = Resources.Load("HotRod");
		CarPrefabs[1] = Resources.Load("Jeep");
		CarPrefabs[2] = Resources.Load("Racer");
		CarPrefabs[3] = Resources.Load("VWBraud");

		// Spawn players on spawnpoints
		int i = 0;
		foreach (Transform child in transform)
		{
			if (i == 0) {
				p1 = Instantiate(CarPrefabs[i], child.transform.position, child.transform.rotation) as GameObject;
			}
			if (i == 1 && NumberOfPlayers > 1) {
				p2 = Instantiate(CarPrefabs[i], child.transform.position, child.transform.rotation) as GameObject;
			}
			if (i == 2 && NumberOfPlayers > 2) {
				p3 = Instantiate(CarPrefabs[i], child.transform.position, child.transform.rotation) as GameObject;
			}
			if (i == 3 && NumberOfPlayers > 3) {
				p4 = Instantiate(CarPrefabs[i], child.transform.position, child.transform.rotation) as GameObject;
			}
			i++;
		}
	}

	void AdjustCameras () {
		// Spawn Cameras and adjust according to player count
		if(NumberOfPlayers == 1) {
			p1Camera = p1.GetComponentsInChildren<Camera>();
			p1Camera[0].rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
		}

		if(NumberOfPlayers == 2) {
			p1Camera = p1.GetComponentsInChildren<Camera>();
			p1Camera[0].rect = new Rect(0.0f, 0.0f, 1.0f, 0.5f);
			p2Camera = p2.GetComponentsInChildren<Camera>();
			p2Camera[0].rect = new Rect(0.0f, 0.5f, 1.0f, 0.5f);
		}

		if(NumberOfPlayers > 2) {
			p1Camera = p1.GetComponentsInChildren<Camera>();
			p1Camera[0].rect = new Rect(0.0f, 0.5f, 0.5f, 1.0f);

			p2Camera = p2.GetComponentsInChildren<Camera>();
			p2Camera[0].rect = new Rect(0.5f, 0.5f, 0.5f, 1.0f);

			p3Camera = p3.GetComponentsInChildren<Camera>();
			p3Camera[0].rect = new Rect(0.0f, 0.0f, 0.5f, 0.5f);

			if(NumberOfPlayers == 3) {
				overviewCamera = Resources.Load("OverviewCamera");
				overviewCameraClone = Instantiate(overviewCamera,  new Vector3(0, 100f, 0), Quaternion.Euler(90,0,0)) as GameObject;
			}

			if(NumberOfPlayers == 4) {
				p4Camera = p4.GetComponentsInChildren<Camera>();
				p4Camera[0].rect = new Rect(0.5f, 0.0f, 0.5f, 0.5f);
			}
		}
	}
}
