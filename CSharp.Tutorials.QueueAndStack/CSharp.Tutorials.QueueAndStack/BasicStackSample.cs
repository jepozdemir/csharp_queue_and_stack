class BasicStackSample
{
	public void Execute()
	{
		Stack<int> stack = new Stack<int>();

		// Push elements onto the stack
		stack.Push(1);
		stack.Push(2);
		stack.Push(3);

		// Peek at the top element
		Console.WriteLine("Top element: " + stack.Peek());

		// Pop elements off the stack
		while (stack.Count > 0)
		{
			Console.WriteLine("Popped element: " + stack.Pop());
		}
	}
}
