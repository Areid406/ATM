The ATM lab assignment is our first forray into C#.
The nature of the program is to read in an amount of change needed to be dispensed by an ATM
accompanied by the amount of each available denomination.

The assignment required us to check that making change is even possible given 
the requested amount and available change (i.e. if 95$ worth of change was asked for but
the ATM is only stated to contain 85$ worth of change). This was resolved in the 
isChangePossible() function that exists in Processor.cs

Our program consists of 3 classes; Change, Processor, and ATM.
Our program could have easily been implemented with the use of a single class,
but we are anticipating the need to further modify/extend the behavior of this program
with future assignments, thus hopefully making our program more flexible to increased
constraints.
