class StackImplementation
{
  public static void Stack()
  {
    Stack<int> st = new Stack<int>();
    st.Push(10);
    st.Push(20);
    st.Push(30);
    st.Push(40);
    st.Push(50);
    st.Push(60);
    st.Push(70);
    st.Push(80);
    Console.WriteLine(st.Count);
    Console.WriteLine(st.Pop());
    Console.WriteLine(st.Peek());
    Console.WriteLine(st.Count);
    //Contains
    Console.WriteLine(st.Contains(10));

    foreach (var i in st)
      Console.Write(i + " ");
  }
}