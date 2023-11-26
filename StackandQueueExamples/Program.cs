
Console.WriteLine("Hello, World!"); //Examples of the Stack
Stack<int> s = new Stack<int>();

s.Push(59);
s.Push(72);
s.Push(65);

Console.Write("Stack: ");
foreach (int i in s)
    Console.Write(i + " ");  // 65  72  59
Console.Write("\nCount: " + s.Count);  // 3

Console.Write("\nTop: " + s.Peek());  // 65
Console.Write("\nPop: " + s.Pop());  // 65

Console.Write("\nStack: ");
foreach (int i in s)
    Console.Write(i + " ");  // 72  59
Console.Write("\nCount: " + s.Count);  // 2

//the Queue is  a FIFO principle, first in first out.  Inserting an element into a queue is called enqueue.  Deleting is called Dequeue

//Queues are used whenever we need to manage objects in order starting with the first one in.

//Scenarios include printing documents on a printer, call center systems answering people on hold people, and so on

//Queue<T> properties include: Count - Gets the number of elements in the queue.
//And methods include: Dequeue() - Returns the object at the beginning of the queue and also removes it. Enqueue(T t) - Adds the object t to the end of the queue.

//Clear() - Removes all objects from the queue. Contains(T t) - Returns true when the element t is present in the queue. Peek() - Returns the object at the beginning of the queue without removing it. ToArray() - Copies the queue into a new array.

//Example:

Queue<int> q = new Queue<int>();

q.Enqueue(5);
q.Enqueue(10);
q.Enqueue(15);
Console.Write("Queue: ");
foreach (int i in q)
    Console.Write(i + " ");  // 5  10  15
Console.Write("\nCount: " + q.Count);  // 3

Console.Write("\nDequeue: " + q.Dequeue()); // 5

Console.Write("\nQueue: ");
foreach (int i in q)
    Console.Write(i + " ");  // 10  15
Console.Write("\nCount: " + q.Count);  // 2


//Example 2

Queue<int> qe = new Queue<int>();

while (qe.Count < 3)
{
    int num = Convert.ToInt32(Console.ReadLine());
    //your code goes here
    qe.Enqueue(num);


}

Console.Write("Queue: ");
foreach (int i in qe)
    Console.Write(i + " ");

Console.WriteLine();

Console.Write("Sorted: ");
//your code goes here

var sortedQueue = qe.ToArray();

Array.Sort(sortedQueue);

foreach (int i in sortedQueue)
{
    Console.Write(i + " ");
}