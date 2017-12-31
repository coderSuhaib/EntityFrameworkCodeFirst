# EntityFrameworkCodeFirst

## Objective
I have created a code first method using the entity framework. I wanted to create a carlot database table that housed all the avaliable
cars with the make, model, year, and price that are for sale. 

## Challenge
The Challenges I ran into was connecting my code from Visual Studio to my SQL Server Manager Studio and being able to update it.  

## Result
I did some research and I was able to see the one piece of information that I was missing. I needed to go into my app.config file and add
a connectionString so it can find my SQL client and connect to it. Then I needed to go into the package manager console and enable- migrations. I can then run the command add-migration to scaffold the creating the of the table.
