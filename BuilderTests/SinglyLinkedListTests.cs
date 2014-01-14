using System;
using NUnit.Framework;
using DataStructures.SinglyLinkedList;
namespace BuilderTests
{
	[TestFixture()]
	public class SinglyLinkedListTests
	{
		[Test()]
		public void ListTerminates ()
		{
			var head = Factory.Create(2);
			Assert.IsTrue(head.Next.Next == null);
		}

		[Test()]
		public void DataMatchesQuantityRequesed ()
		{
			var head = Factory.Create(2);
			Assert.AreEqual(0, head.Data);
			Assert.AreEqual(1, head.Next.Data);
		}

		[Test()]
		public void ObjectDataIsSetInOrder()
		{
			var dataArray = new string[]{"steve", "mayszak"};
			var head = Factory.CreateFor(dataArray);
			Assert.AreEqual("steve", head.Data);
			Assert.AreEqual("mayszak", head.Next.Data);
		}
	}
}

