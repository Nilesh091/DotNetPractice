class AddGenericClasses<T>
{
  T n1;
  T n2;
  T result;
  public AddGenericClasses()
  { }
  public AddGenericClasses(T n1, T n2)
  {
    this.n1 = n1;
    this.n2 = n2;
  }
  public T add()
  {
    dynamic n1 = this.n1;
    dynamic n2 = this.n2;
    return n1 + n2;
  }

}