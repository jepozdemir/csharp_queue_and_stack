Console.WriteLine("\r\nUsing Stack:\r\n");
var basicStack = new BasicStackSample();
basicStack.Execute();

Console.WriteLine("\r\nUsing Queue:\r\n");
var basicQueue = new BasicQueueSample();
basicQueue.Execute();

Console.WriteLine("\r\nUsing both Stack and Queue in a simple text editor:\r\n");
var editor = new SimpleTextEditor();

editor.AddText("Hello, ");
editor.DisplayText();

editor.AddText("I'm Jepozdemir. ");
editor.DisplayText();

editor.Undo();
editor.DisplayText();

editor.Redo();
editor.DisplayText();

editor.AddText("How are you?");
editor.DisplayText();