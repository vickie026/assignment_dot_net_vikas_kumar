Q: When should you use LINQ in your program? 

Ans : I particularly find LINQ very useful when it is used for querying some collection of objects when it is needed to meet some of the criteria. LINQ can be very useful with other data sources like XML and SQL. 
But for SQL purpose, I generally go for other ORM tools like Entity Framework. It turns out to be very effective when it is needed to query upon collections.
Suppose there is a collection of books with name,isbn,price and authors.
We need to select books which are of higher price than RS 250/- and Author Name starts with 'V'.

One way to achieve this is like


Book[] SelectedBook = new Book[100];
int i = 0;
foreach(Book book in books) {
	if(book.Price > 250 && book.Author.StartsWith("A")) 
	{
		SelectedBooks[i++] = book;
	}
}


Using LINQ

Book[] SelectedBooks = books.Where(b => b.Price > 250 && b.Author.StartsWith("A")).ToArray();

Just one liner to achive the same. Other advantage of LINQ over raw SQL (used by ADO.NET) is that it is a compiled query. If some error happens with query syntax, we can know that by compile times.
While in ADO.NET, the error is find out at runtime from database execution engine like SQL-SERVER, ORACLE, MYSQL etc. and this is generally not a good practice to find error at runtime.

LINQ is also useful to use the same query over multiple data sources like XML,SQL,Objects etc.



----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Instruction to run the program.


-> Unzip the file and import the project to visual studio (with .NET Framwork 4.7.1);
-> Execute the project with F5 or Ctrl + F5.
-> When console prompt apperas, Enter your choice from 1 to 3.


-> For MarcoPolo, you can set the value of limit upto what the game is needed to be played in Program.cs. Default is 100.
-> For MergeSortedArray, the both input arrays can be given as input in Program.cs.
-> For parsing the digits, you have to provide the path for input file and output file. The program should read from input file and generate output file
  by itself with proger output to corresponding digits.
-> Same methodogogy isused from running the Unit Test of all of these methods. Provide th correct input file paths and output file paths with expected file path.

-> You can provide different parameters for MergeSortedArray and MarcoPolo in there respective test class like limit, inputs and expected outputs. On visual studiomain menu, go to 
Test -> Run -> All Tests.





 

