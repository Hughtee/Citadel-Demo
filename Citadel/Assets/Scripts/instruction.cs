using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class instruction : MonoBehaviour {

	//refrence for the pause menu panel in the hierarchy
	public GameObject instructionPanel;
	//animator reference
	private Animator anim;
	//variable for checking if the game is paused 
	private bool isInstructed = false;
	// Use this for initialization
	
	
	void Start () {

		
		//get the animator component
		anim = instructionPanel.GetComponent<Animator>();
		//disable it on start to stop it from playing the default animation
		//anim.enabled = false;
	}
	
	// Update is called once per frame
	
	
	public void Update () 
	{
		//pause the game on escape key press and when the game is not already paused
		if(Input.GetKeyUp(KeyCode.Escape) && !isInstructed)
		{
			Instructed();
		}
		//unpause the game if its paused and the escape key is pressed
		else if(Input.GetKeyUp(KeyCode.Escape) && isInstructed)
		{
			UnInstructed();
		}
	}
	
	//function to pause the game
	
	
	public void Instructed(){
		//enable the animator component
		anim.enabled = true;
		//play the Slidein animation
		anim.Play("InstructionIn");
		//set the isPaused flag to true to indicate that the game is paused
		isInstructed = true;
		
	}
	//function to unpause the game
	
	
	public void UnInstructed(){
		//set the isPaused flag to false to indicate that the game is not paused
		isInstructed = false;
		//play the SlideOut animation
		anim.Play("InstructionOut");
		//set back the time scale to normal time scale
		
	}

}
