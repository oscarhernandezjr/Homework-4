using System;
namespace Homework_4.LinkedList
{
	public class Node
	{

		public int Data { get; set; }
		public Node? Next { get; set; }

		public void DisplayNode()
		{
			Console.WriteLine(Data);
		}

	}
	
}

