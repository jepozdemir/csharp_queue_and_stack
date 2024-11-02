class SimpleTextEditor
{
	private Stack<string> undoStack = new Stack<string>();
	private Queue<string> redoQueue = new Queue<string>();
	private string currentText = "";

	public void AddText(string text)
	{
		// Push the current text to the undo stack before adding new text
		undoStack.Push(currentText);
		currentText += text;

		// Clear the redo queue since new text was added
		redoQueue.Clear();
		Console.WriteLine("Added Text: " + text);
	}

	public void Undo()
	{
		if (undoStack.Count > 0)
		{
			// Push the current text to the redo queue before undoing
			redoQueue.Enqueue(currentText);
			currentText = undoStack.Pop();
			Console.WriteLine("Undo...");
		}
		else
		{
			Console.WriteLine("Nothing to undo.");
		}
	}

	public void Redo()
	{
		if (redoQueue.Count > 0)
		{
			// Push the current text to the undo stack before redoing
			undoStack.Push(currentText);
			currentText = redoQueue.Dequeue();
			Console.WriteLine("Redo...");
		}
		else
		{
			Console.WriteLine("Nothing to redo.");
		}
	}

	public void DisplayText()
	{
		Console.WriteLine("Current Text: " + currentText);
	}
}
