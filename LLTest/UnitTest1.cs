using LL;
using NUnit.Framework;

namespace LLTest;

public class LinkedListTests
{
    [Test]
    public void TestAddFirst()
    {
        LinkedList list = new LinkedList();
        list.AddFirst("Joe Blow");
        Assert.AreEqual(1, list.Count);
        Assert.AreEqual("Joe Blow", list.GetValue(0));
    }

    [Test]
    public void TestAddLast()
    {
        LinkedList list = new LinkedList();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");
        list.AddLast("John Smith");
        Assert.AreEqual(3, list.Count);
        Assert.AreEqual("Joe Schmoe", list.GetValue(1));
    }

    [Test]
    public void TestRemoveFirst()
    {
        LinkedList list = new LinkedList();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");
        list.AddLast("John Smith");
        list.RemoveFirst();
        Assert.AreEqual(2, list.Count);
        Assert.AreEqual("Joe Schmoe", list.GetValue(0));
    }

    [Test]
    public void TestRemoveLast()
    {
        LinkedList list = new LinkedList();
        list.AddLast("Joe Blow");
        list.RemoveLast();
        Assert.AreEqual(0, list.Count);
    }

    [Test]
    public void TestGetValue()
    {
        LinkedList list = new LinkedList();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");
        list.AddLast("John Smith");
        Assert.AreEqual("Joe Schmoe", list.GetValue(1));
    }

    [Test]
    public void TestSizeOfList()
    {
        LinkedList list = new LinkedList();
        list.AddLast("Joe Blow");
        list.AddLast("Joe Schmoe");
        Assert.AreEqual(2, list.Count);
    }

    [Test]
    public void TestGetValueFromEmptyList()
    {
        LinkedList list = new LinkedList();
        Assert.IsNull(list.GetValue(0));
    }

    [Test]
    public void TestRemoveFromEmptyList()
    {
        LinkedList list = new LinkedList();
        list.RemoveFirst();
        list.RemoveLast();
        Assert.AreEqual(0, list.Count);
    }
}