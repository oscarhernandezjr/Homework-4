using System;
namespace Homework_4.LinkedList
{
	public class Node
	{

		public int Data { get; set; }
		public Node? Next { get; set; }

		/// <summary>
		/// This should ony be used with Doubly Linked Lists
		/// </summary>
		public Node? Previous { get; set; }

		public void DisplayNode()
		{
			Console.WriteLine(Data);
		}

	}
	
}

