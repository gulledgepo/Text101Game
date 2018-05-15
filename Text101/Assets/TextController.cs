using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour 
{

	public Text text; 
    //As important events happen that indicate new branches with new text, state numbers are incremented.
	private enum States { room, room_1, painting_0, painting_1, painting_2, painting_transition, bed_0, bed_1, bed_2, door_0, door_1, door_unlock, hallway_2,
                          room_2, stairs_2, hallwaydoor_2, window_2, window_3, hallwaydoor_3, stairs_3, hallway_3, room_3, painting_3, bed_3,
                          room_4, bed_4, painting_4, hallway_4, stairs_4, window_4, hallwaydoor_4, room_5, bed_5, painting_5, hallway_5,
                          stairs_5, window_5, windowtransition, hallwaydoor_5};
	private States mystate;

	void Start () 
	{
		mystate = States.room;
	}
	
	// Update is called once per frame, and checks the current state. Depending on the state
    //It calls the corresponding displays
	void Update ()
	{
		print (mystate);
		if      (mystate == States.room) 		         {state_room();} 
		else if (mystate == States.bed_0)	             {state_bed_0();} 
		else if (mystate == States.door_0)               {state_door_0();}
		else if (mystate == States.painting_0)           {state_painting_0();}
		else if (mystate == States.painting_transition)  {state_painting_transition();}
		else if (mystate == States.room_1)               {state_room_1();}
		else if (mystate == States.bed_1)                {state_bed_1();}
		else if (mystate == States.painting_1)           {state_painting_1();}
		else if (mystate == States.door_1)               {state_door_1();}
		else if (mystate == States.door_unlock)          {state_door_unlock();}
        else if (mystate == States.hallway_2)            {state_hallway_2(); }
        else if (mystate == States.room_2)               {state_room_2(); }
        else if (mystate == States.bed_2)                { state_bed_2(); }
        else if (mystate == States.painting_2)           { state_painting_2(); }
        else if (mystate == States.stairs_2)             {state_stairs_2(); }
        else if (mystate == States.window_2)             {state_window_2(); }
        else if (mystate == States.hallwaydoor_2)        {state_hallwaydoor_2(); }
        else if (mystate == States.hallwaydoor_3)        { state_hallwaydoor_3(); }
        else if (mystate == States.hallway_3)            { state_hallway_3(); }
        else if (mystate == States.stairs_3)             { state_stairs_3(); }
        else if (mystate == States.room_3)               { state_room_3(); }
        else if (mystate == States.bed_3)                { state_bed_3(); }
        else if (mystate == States.painting_3)           { state_painting_3(); }
        else if (mystate == States.window_3)             { state_window_3(); }
        else if (mystate == States.hallwaydoor_4)        { state_hallwaydoor_4(); }
        else if (mystate == States.hallway_4)            { state_hallway_4(); }
        else if (mystate == States.stairs_4)             { state_stairs_4(); }
        else if (mystate == States.room_4)               { state_room_4(); }
        else if (mystate == States.bed_4)                { state_bed_4(); }
        else if (mystate == States.painting_4)           { state_painting_4(); }
        else if (mystate == States.window_4)             { state_window_4(); }
        else if (mystate == States.windowtransition)     { state_windowtransition(); }
        else if (mystate == States.hallwaydoor_5)        { state_hallwaydoor_5(); }
        else if (mystate == States.hallway_5)            { state_hallway_5(); }
        else if (mystate == States.stairs_5)             { state_stairs_5(); }
        else if (mystate == States.room_5)               { state_room_5(); }
        else if (mystate == States.bed_5)                { state_bed_5(); }
        else if (mystate == States.painting_5)           { state_painting_5(); }
        else if (mystate == States.window_5)             { state_window_5(); }
    }
    //Our states will determine what text to display and the options of where the user can go.
    //All the rooms in the game have multiple states, depending on what the user has acquired or done
    //Obviously this is extremely tedious and not the best way to do it, but was just a lesson in
    //getting used to states. 
    #region state display and transitions
    void state_room()
	{
		text.text = "You are in the middle of small room. Looking around, you notice " +
		"a bed with white sheets, an odd looking painting on the wall, and a door.\n\n" +
		"Press B to view the bed, P to view the Painting, and D to view the Door.";
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			mystate = States.bed_0;
		}
        else if (Input.GetKeyDown (KeyCode.D)) 
		{
			mystate = States.door_0;
		}
        else if (Input.GetKeyDown (KeyCode.P)) 
		{
			mystate = States.painting_0;
		}
	}
	void state_bed_0()
	{
		text.text = "You rummage through the bed looking for anything of interest. Sadly, the only thing " +
					"you come up with is some dirt from sheets that are in obvious need of cleaning.\n\n" +
					"Press R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room;
		}
	}
	void state_door_0()
	{
		text.text = "You try to open the door, but the handle will not turn. Above the door handle " +
					"you notice a keyhole. If only you had the key.\n\n" +
					"Press R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room;
		}
	}
	void state_painting_0()
	{
		text.text = "You see a picture of an elderly man and his cat. Is this who put you in this room? " +
					"You notice the picture is hanging crooked.\n\n" +
					"Press S to straighten the painting or R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room;
		}
        else if (Input.GetKeyDown(KeyCode.S))
		{
			mystate = States.painting_transition;
		}
	}
	void state_painting_transition()
	{
		text.text = "As you are straightening the painting, you notice an object falls down and thuds on the floor." +
					"Looking down, you see that it is a key. You grab the key.\n\n" +
					"Press R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room_1;
		}
	}
	void state_room_1()
	{
		text.text = "You are in the middle of small room, however, you now have a key in your possession. " +
					"Looking around, you notice a bed with white sheets, an odd looking painting on the wall, and a door.\n\n" +
					"Press B to view the bed, P to view the Painting, and D to view the Door.";
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			mystate = States.bed_1;
		}
        else if (Input.GetKeyDown (KeyCode.D)) 
		{
			mystate = States.door_1;
		}
        else if (Input.GetKeyDown (KeyCode.P)) 
		{
			mystate = States.painting_1;
		}
	}
	void state_bed_1()
	{
		text.text = "You find the bed in the same state as before; dirty and lacking anything of interest. " +
					"\n\n" +
					"Press R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room_1;
		}
	}
	void state_painting_1()
	{
		text.text = "You see a picture of an elderly man and his cat. Is this who put you in this room? " +
					"You notice the picture is now hanging up correctly, thanks to you.\n\n" +
					"Press R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room_1;
		}
	}
	void state_door_1 ()
	{
		text.text = "You try to open the door, but the handle will not turn. Above the door handle " +
		"you notice a keyhole. Perhaps the key you have is for this door.\n\n" +
		"Press K to insert the key or R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) {
			mystate = States.room_1;
		}
        else if (Input.GetKeyDown (KeyCode.K)) 
		{
			mystate = States.door_unlock;
		}
	}
	void state_door_unlock()
	{
		text.text = "You insert the key and turn. To your relief, this unlocks the door. " +
					"Opening the door, you notice a hallway ahead of you.\n\n" +
					"Press H to go into the hallway or R to return to looking around the room.";
		if (Input.GetKeyDown (KeyCode.R)) 
		{
			mystate = States.room_2;
		}
        else if (Input.GetKeyDown (KeyCode.H)) 
		{
			mystate = States.hallway_2;
		}
	}
	void state_room_2()
	{
		text.text = "You are in the middle of small room. Looking around, you notice a bed with white sheets," +
					" an odd looking painting on the wall, and an open door leading to a hallway.\n\n" +
					"Press B to view the bed, P to view the Painting, and H to head into the hallway.";
		if (Input.GetKeyDown (KeyCode.B)) 
		{
			mystate = States.bed_2;
		}
        else if (Input.GetKeyDown (KeyCode.H)) 
		{
			mystate = States.hallway_2;
		}
        else if (Input.GetKeyDown (KeyCode.P)) 
		{
			mystate = States.painting_2;
		}
	}
    void state_bed_2()
    {
        text.text = "You find the bed in the same state as before; dirty and lacking anything of interest. " +
                    "\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_2;
        }
    }
    void state_painting_2()
    {
        text.text = "You see a picture of an elderly man and his cat. The sight of this duo is beginning to wane on you. " +
                    "You notice the picture is now hanging up correctly, thanks to you.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_2;
        }
    }
    void state_hallway_2()
    {
        text.text = "You are in a hallway. To your left, you notice stairs that go up and you can hear music coming from above. " +
                    "Straight ahead, you notice a door leading to outside. Halfway down the hall, you see the sun shining through a window " +
                    "onto a red circle on the wall.\n\n" +
                    "Press S to check out the stairs, D to view the door, W to view the window, or R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_2;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.stairs_2;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.window_2;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            mystate = States.hallwaydoor_2;
        }
    }
    void state_stairs_2()
    {
        text.text = "At the base of the stairs you hear several loud clangs and grunts, followed by " +
                    "shouting. It appears whoever is up there is not in a good mood. You don't think you want " +
                    "to go up there.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_2;
        }
    }
    void state_window_2()
    {
        text.text = "You notice a small red circle on the wall covered by sunlight with a nail just above it. You place your hand over " +
                    "the circle and hear a loud click several feet away. Removing your hand, you hear another loud click.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_3;
        }
    }
    void state_hallwaydoor_2()
    {
        text.text = "The door leads to the outside, to freedom. You try to open the door but the door is clearly locked." +
            "       Surely there is some way to open it.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_2;
        }
    }
    void state_hallway_3()
    {
        text.text = "You are in a hallway. To your left, you notice stairs that go up and you can hear music coming from above. " +
                    "Straight ahead, you notice a door leading to outside. Halfway down the hall, you see the sun shining through a window" +
                    "onto a red circle on the wall.\n\n" +
                    "Press S to check out the stairs, D to view the door, W to view the window, or R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_3;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.stairs_3;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.window_3;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            mystate = States.hallwaydoor_3;
        }
    }
    void state_hallwaydoor_3()
    {
        text.text = "The door leads to the outside, to freedom. You try to open the door but the door is clearly locked. " +
                    "Surely there is some way to open it.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_3;
        }
    }
    void state_window_3()
    {
        text.text = "You notice a small red circle on the wall covered by sunlight with a nail just above it. You place your hand over " +
                    "the circle and hear a loud click several feet away. Removing your hand, you hear another loud click. If only there" +
                    "was a way to block the sunlight when you weren't near.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_3;
        }
    }
    void state_stairs_3()
    {
        text.text = "At the base of the stairs you hear several loud clangs and grunts, followed by" +
                    "shouting. It appears whoever is up there is not in a good mood. You don't think you want" +
                    "to go up there.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_3;
        }
    }
    void state_painting_3()
    {
        text.text = "You see a picture of an elderly man and his cat. The sight of this duo is beginning to wane on you. " +
                    "You notice the picture is now hanging up correctly, thanks to you.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_3;
        }
    }
    void state_bed_3()
    {
        text.text = "You find the bed in the same state as before. It occurs to you that these dirty sheets " +
                    "could be hung on the nail above the red circle." +
                    "\n\n" +
                    "Press S to take the sheets or R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_3;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.room_4;
        }
    }
    void state_room_3()
    {
        text.text = "You are in the middle of small room. Looking around, you notice a bed with white sheets," +
                    " an odd looking painting on the wall, and an open door leading to a hallway.\n\n" +
                    "Press B to view the bed, P to view the Painting, and H to head into the hallway.";
        if (Input.GetKeyDown(KeyCode.B))
        {
            mystate = States.bed_3;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            mystate = States.hallway_3;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            mystate = States.painting_3;
        }
    }
    void state_room_4()
    {
        text.text = "You are in the middle of small room. Looking around, you notice an empty bed," +
                    " an odd looking painting on the wall, and an open door leading to a hallway.\n\n" +
                    "Press B to view the bed, P to view the Painting, and H to head into the hallway.";
        if (Input.GetKeyDown(KeyCode.B))
        {
            mystate = States.bed_4;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            mystate = States.hallway_4;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            mystate = States.painting_4;
        }
    }
    void state_bed_4()
    {
        text.text = "You find the bed missing the sheets that were once on them. This is because " +
                    "the sheets are now in your possession. You find nothing else of interest.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_4;
        }
    }
    void state_painting_4()
    {
        text.text = "You see a picture of an elderly man and his cat. The sight of this duo is beginning to wane on you. " +
                    "If you don't get out of here soon you may start talking to them. " +
                    "You notice the picture is now hanging up correctly, thanks to you.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_4;
        }
    }
    void state_hallway_4()
    {
        text.text = "You are in the same hallway as before. To your left, you notice stairs that go up and you can hear shouting coming from above. " +
                    "Straight ahead, you notice a door leading to outside. Halfway down the hall, you see the sun shining through a window " +
                    "onto a red circle on the wall.\n\n" +
                    "Press S to check out the stairs, D to view the door, W to view the window, or R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_4;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.stairs_4;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.window_4;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            mystate = States.hallwaydoor_4;
        }
    }
    void state_stairs_4()
    {
        text.text = "At the base of the stairs you hear several loud clangs and grunts, followed by " +
                    "shouting. The faint sound of crying can also be heard. You are positive you don't want" +
                    "to go up there\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_4;
        }
    }
    void state_window_4()
    {
        text.text = "You notice a small red circle on the wall covered by sunlight with a nail just above it. You place your hand over " +
                    "the circle and hear a loud click several feet away. Removing your hand, you hear another loud click. You imagine " +
                    "that if you hang the sheet on the nail it will block the circle while you are gone.\n\n" +
                    "Press S to place sheet on the nail or R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_4;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.windowtransition;
        }
    }
    void state_windowtransition()
    {
        text.text = "You hang the sheet on the nail making sure that it blocks all of the sunlight from the red circle. " +
                     "You hear the same noise as before, however now you are certain you can find where it was as the sunlight " +
                     "no longer hits the circle.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_5;
        }
    }
    void state_hallwaydoor_4()
    {
        text.text = "The door leads to the outside, to freedom. You try to open the door but the door is clearly locked." +
            "       Surely there is some way to open it. Perhaps something to do with that red circle on the wall.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_4;
        }
    }
    void state_hallwaydoor_5()
    {
        text.text = "The door leads to the outside, to freedom. You try to open the door and to your astonishment it " +
                     "opens leading you to the outside. You are free! You did it! Congratulations!\n\n" +
                     "Press P to play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            mystate = States.room;
        }
    }
    void state_hallway_5()
    {
        text.text = "You are in the same hallway as before. To your left, you notice stairs that go up and you can hear shouting coming from above." +
                    "Straight ahead, you notice a door leading to outside. Halfway down the hall, you see the sun shining through a window " +
                    "onto a red circle on the wall. You aren't certain what that thunk was but you intend to find out.\n\n" +
                    "Press S to check out the stairs, D to view the door, W to view the window, or R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_5;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            mystate = States.stairs_5;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            mystate = States.window_5;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            mystate = States.hallwaydoor_5;
        }
    }
    void state_window_5()
    {
        text.text = "There is a sheet hanging on a nail on the wall. Behind it is a red circle. You " +
                    "wonder what the sound was when you blocked the sun from hitting the red circle.\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_5;
        }
    }
    void state_stairs_5()
    {
        text.text = "At the base of the stairs you hear several loud clangs and grunts, followed by " +
                    "shouting. The crying once heard has now become more intense mixed with screams of" +
                    "agony. You are absolutely positive you don't want" +
                    "to go up there\n\n" +
                    "Press R to return to the hallway.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.hallway_5;
        }
    }
    void state_room_5()
    {
        text.text = "You are back in the middle of small room you started out in. Looking around, you notice an empty bed," +
                    " an odd looking painting on the wall, and an open door leading to a hallway.\n\n" +
                    "Press B to view the bed, P to view the Painting, and H to head into the hallway.";
        if (Input.GetKeyDown(KeyCode.B))
        {
            mystate = States.bed_5;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            mystate = States.hallway_5;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            mystate = States.painting_5;
        }
    }
    void state_bed_5()
    {
        text.text = "You find the bed missing the sheets that were once on them. This is because " +
                    "the sheets are now in your possession. The sheets proved to be useful" +
                    "in blocking out the sunlight from the red circle. You find nothing else of interest.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_5;
        }
    }
    void state_painting_5()
    {
        text.text = "You see a picture of an elderly man and his cat. The sight of this duo is beginning to wane on you. " +
                    "If you don't get out of here soon you may start talking to them. Is this the man causing the torture " +
                    "at the top of the stairs? " +
                    "You notice the picture is now hanging up correctly, thanks to you.\n\n" +
                    "Press R to return to looking around the room.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            mystate = States.room_5;
        }
    }
    #endregion


}
