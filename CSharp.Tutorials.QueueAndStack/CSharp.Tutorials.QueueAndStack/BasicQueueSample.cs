class BasicQueueSample
{
	public void Execute()
	{
		Queue<int> queue = new Queue<int>();

		// Enqueue elements into the queue
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);

		// Peek at the front element
		Console.WriteLine("Front element: " + queue.Peek());

		// Dequeue elements from the queue
		while (queue.Count > 0)
		{
			Console.WriteLine("Dequeued element: " + queue.Dequeue());
		}
	}
}
