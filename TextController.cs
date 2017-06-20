using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell0, cell1 , mirror, toothbrush, cellmate0, cellmate1, putfoam, alert,knockout, freedom};
	private States myState;
	// Use this for initialization
	void Start () {
	
		myState = States.cell0;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if(myState == States.cell0){
		 	state_cell ();
		}else if (myState == States.cell1){
			state_backcell();
		}else if (myState == States.toothbrush){
			state_toothbrush();
		}else if(myState == States.cellmate0){
			state_cellmate0();
		}else if(myState == States.cellmate1){
			state_cellmate1();
		}else if(myState == States.putfoam){
			state_getready();
		}else if(myState == States.alert){
			state_knockTheGuard();
		}else if(myState == States.freedom){
			state_freedom();
			
		}
		
		
	}
	
	void state_cell(){
		text.text = "You woke up in the middle of the night... gasping for air, trying to shake off the nightmare you just had."
				+ " Frantically you look around to find familiar feeling ... that lingering feeling of "
				+ "love from your beloved wife or a gentle kiss from your daughter..."
				+ "and with every passing second you realize the bitterness of the air that you breathe, it feels almost"
				+ " nauseating.. heavy...it feels like inhaling blood... "
				+ "with every breath you take, memories starts to come back "
				+ "overflowing images of your breathless wife and daughter on your arms ... you tried to scream but your voice just wont come out.."
				+ "... 'DDRRANANG!!!' this sounds snaps you back to reality, the guard used his baton against"
				+ " your prison cell... 'go back to sleep! 2041 before ill put you back in isolation'... "
				+ "like some animal that you saw in the impound... you too are in a cage and you thought to your self"
				+ "...'2041?..Im a number? What happenned?' ... overflowing with sadness, anger, and confusion"
				+ " you thought to yourself 'One thing I know for certain....\n...Im innocent...'\n\n"
		   		+ "---in your cell you see toothpaste and tooth brush, your cell mate, and mirror---\n\n"
				+ "press T to look at Toothpaste and Toothbrush\npress C to check your Cell mate\npress M to check Mirror"; 
			
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.toothbrush;
		}else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.cellmate0;
		}
	}
	
	void state_backcell(){
		text.text = "---back in an uncomfortable bed again... you say to yourself 'you've got to get out of here'---\n\n"
			+ "press C to check your Cell mate\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.toothbrush;
		}else if(Input.GetKeyDown(KeyCode.C)){
			myState = States.cellmate0;
		}
	}
	void state_toothbrush(){
		text.text = "---as you brush your teeth, you realize you can use the foam from your mouth to aid your escape---\n\n"
			+ "press C to check your Cell mate\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.C)){
			myState = States.cellmate1;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell1;
		}	
	}
	
	void state_cellmate0(){
		text.text = "---your cellmate is soundly asleep, not even a gun shot would wake him up---\n\n"
			+ "press T to check your Toothbrush\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.T)){
			myState = States.cellmate1;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell1;
		}	
	}
	
	void state_cellmate1(){
		text.text = "---your cellmate is soundly asleep, not even a gun shot would wake him up---\n\n"
			+ "press U to use Toothbrush foam on cell mate mouth\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.U)){
			myState = States.putfoam;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell1;
		}	
	}
	void state_getready(){
		text.text = "---You made your cell mate looks like his mouth is foamy, the guards is coming around the corner---\n\n"
			+ "press A to Alert the guard\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.A)){
			myState = States.alert;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell1;
		}	
	}
	void state_knockTheGuard(){
		text.text = "---the guard opens your cell to check on your mate.....this is your chance!!..---\n\n"
			+ "press K to check your Knock the guard\npress B to go Back to your bed"; 
		
		if(Input.GetKeyDown(KeyCode.K)){
			myState = States.freedom;
		}else if(Input.GetKeyDown(KeyCode.B)){
			myState = States.cell1;
		}	
	}
	void state_freedom(){
		text.text = "---you are running for your life, towards the exit sign---\n\n"
			+ "and you've escaped and won the game" 
			+ "press P to play again"; 
		
		if(Input.GetKeyDown(KeyCode.P)){
			myState = States.cell0;
		}
	}
	
}
