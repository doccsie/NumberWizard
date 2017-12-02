<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min = 1;
	int guess;
	
	
	void Start () {
		StartGame ();	
	}
	void StartGame () {
		min = 1;
        max = 1000;
		print ("=========================");
		print ("Welcome to Number Wizard!");
               
        print("Press \"A\" if you want to set a higher number as 10000");
        print("Press \"B\" if you want to set a higher number as 100000");
        print("Press \"C\" if you want to set a higher number as 1000000");
        print("Pick a number in your head, but don\'t tell me");


	//	print ("The highest number you can pick is " + max);
	//	print ("The lowest number you can take is " + min);
		
	//	print ("Is the number you picked higher or lower than " + guess + "?");
		print ("Press \"Up arrow\" for higher, \"Down arrow\" for lower or \"Enter\" for equals");
		max += 1;
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.A))
        {
            max = 10000;
            print("You choosed 1 to 10k range, let's rock");
            NextGuess();
            print("And my guess is " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            max = 100000;
            print("You choosed 1 to 100k range, let's rock");
            NextGuess();
            print("And my guess is " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            max = 1000000;
            print("You choosed 1 to 1kk range, let's rock");
            NextGuess();
            print("And my guess is " + guess);
        }

            if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess ();
			print("Higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess ();
			print("Higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("You Won");
			StartGame();
		}
	}
	void NextGuess () {
		guess = Random.Range(min, max);
		print ("Press \"Up arrow\" for higher, \"Down arrow\" for lower or \"Enter\" for equals");
		
	}
}
=======
﻿using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min = 1;
	int guess;
	
	
	void Start () {
		StartGame ();	
	}
	void StartGame () {
		min = 1;
        max = 1000;
		print ("=========================");
		print ("Welcome to Number Wizard!");
               
        print("Press \"A\" if you want to set a higher number as 10000");
        print("Press \"B\" if you want to set a higher number as 100000");
        print("Press \"C\" if you want to set a higher number as 1000000");
        print("Pick a number in your head, but don\'t tell me");


	//	print ("The highest number you can pick is " + max);
	//	print ("The lowest number you can take is " + min);
		
	//	print ("Is the number you picked higher or lower than " + guess + "?");
		print ("Press \"Up arrow\" for higher, \"Down arrow\" for lower or \"Enter\" for equals");
		max += 1;
		
	}

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(KeyCode.A))
        {
            max = 10000;
            print("You choosed 1 to 10k range, let's rock");
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            max = 100000;
            print("You choosed 1 to 100k range, let's rock");
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            max = 1000000;
            print("You choosed 1 to 1kk range, let's rock");
        }
    
       if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess ();
			print("Higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            NextGuess ();
			print("Higher or lower than " + guess + "?");
		}
		
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("You Won");
			StartGame();
		}
	}
	void NextGuess () {
		guess = Random.Range(min, max);
		print ("Press \"Up arrow\" for higher, \"Down arrow\" for lower or \"Enter\" for equals");
		
	}
}
>>>>>>> 35d9e4efefe65c69085e66dc58c470c6eb1f8954
