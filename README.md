<h2>Problem statement for which code is provided:</h2>
Types of vehicles: 
•	Motored Vehicle/Automobile
•	Non-motored vehicle/Non-Automobile
 
No. of wheels possible for motored vehicle:
2,3,4,6
 
No.of wheels possible for non-motored vehicle:
1,2,3,4,5,6
 
In case user creates a non-motored vehicle with invalid number of wheels
The message should read: 
 
"Non-motored vehicles with {x} wheels cannot be made in our factory."
Where x is the number of wheels entered by the user.
No other operation should be further permitted.
 
In case user creates a motored vehicle with with invalid number of wheels
The message should read: 
 
"Motored vehicles with {x} wheels cannot be made in our factory."
Where x is the number of wheels entered by the user.
No other operation should be further permitted.
 
In case the option entered by the user is valid:
Log to the console what has been created.
E.g.
 
Type of vehicle: Non-Motored.
No. of wheels: 3
 
Log: A tricycle has been created for you!
 
All the above logging should be done by a service which should be a singleton.
