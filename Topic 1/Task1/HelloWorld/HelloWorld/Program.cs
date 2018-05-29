using System;

namespace HelloWorld
{
	class MainClass
	{
		

		public static void Main (string[] args)
		{
			Message myMessage;
			Message[] messages;
			String name;

			messages = new Message[4];

			myMessage = new Message ("Hello World!");
			myMessage.Print ();



			Console.Write ("Enter Name:");

			name = Console.ReadLine ();

			messages [0] = new Message ( name + " is a bad name");
			messages [1] = new Message (name + "....");
			messages [2] = new Message (name + " is an awesome name");
			messages [3] = new Message (name + " isn't a name");

			if (name.ToLower () == "andrew") {
				myMessage = (messages [0]);
				myMessage.Print ();
			} else if (name.ToLower () == "willem") {
				myMessage = (messages [1]);
				myMessage.Print ();
			} else if (name.ToLower () == "simon") {
				myMessage = (messages [2]);
				myMessage.Print ();
			} else if (name.ToLower () == "asdf") {
				myMessage = (messages [3]);
				myMessage.Print ();
			}

		}
	}
}
