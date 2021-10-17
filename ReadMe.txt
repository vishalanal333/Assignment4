- create a console app
- create a file
- give 3 options to user (1. Write text to file, 2. Show text from file, 3. Exit)
- when user select write to file . take text as input and append text to file
- when user select show text show all text of a file

Note : User can read or write file multiple time till exit.

Working:-
Created function "choice" which will take choice input from the user. If user provided 1 then it will run writeFile function which uses string path from 'main' function and apply StreamWriter class to write the input in file. After writting it will again call function 'choice' to do multiple times of writing and reading of file.

If user provided input 2 then it execute readFile function in which we used StreamReader class to read the file. We use while loop to read multiple line from the file. After reading it will again call function 'choice' to do multiple times of writing and reading of file.

If user provided input 3 then it will exit and display "Bye".

If user provided input grater the 3 then it display a message "invalid input" and again call function 'choice'.So on.

In "main" function we provide path of the file and call 'choice' function.