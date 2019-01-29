<h2>Problem statement for which code is provided:</h2>
Types of vehicles: <br/>
•	Motored Vehicle/Automobile<br/>
•	Non-motored vehicle/Non-Automobile<br/><br/>
 
No. of wheels possible for motored vehicle:<br/>
2,3,4,6<br/><br/>
 
No.of wheels possible for non-motored vehicle:<br/>
1,2,3,4,5,6<br/><br/>
 
In case user creates a non-motored vehicle with invalid number of wheels<br/>

The message should read: <br/>
 
<b>"Non-motored vehicles with {x} wheels cannot be made in our factory."</b><br/>
Where x is the number of wheels entered by the user.<br/>
No other operation should be further permitted.<br/><br/>
 
In case user creates a motored vehicle with with invalid number of wheels<br/>
The message should read: <br/><br/>
 <b>
"Motored vehicles with {x} wheels cannot be made in our factory."</b><br/>
Where x is the number of wheels entered by the user.<br/>
No other operation should be further permitted.<br/><br/>
 
In case the option entered by the user is valid:<br/>
Log to the console what has been created.<br/>
E.g.<br/><br/>
 
Type of vehicle: Non-Motored.<br/>
No. of wheels: 3<br/><br/>
 
Log: A tricycle has been created for you!<br/><br/>
 
All the above logging should be done by a service which should be a singleton.
