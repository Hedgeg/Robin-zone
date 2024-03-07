How do I convert uint to int in C#
http://stackoverflow.com/questions/1131843/ddg#1131851

Given:

 uint n = 3;

int i = checked((int)n); //throws OverflowException if n > Int32.MaxValue
int i = unchecked((int)n); //converts the bits only 
                           //i will be negative if n > Int32.MaxValue

int i = (int)n; //same behavior as unchecked

or

int i = Convert.ToInt32(n); //same behavior as checked

--EDIT

Included info as mentioned by Kenan E. K.

--Samuel Carrijo