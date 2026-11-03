namespace UnityEngine.Events;

[Token(Token = "0x200023B")]
internal class CachedInvokableCall : InvokableCall<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000798")]
	private readonly T m_Arg1; //Field offset: 0x0

	[Address(RVA = "0x16BE810", Offset = "0x16BDC10", Length = "0x38")]
	[Token(Token = "0x60017DA")]
	public CachedInvokableCall`1(object target, MethodInfo theFunction, T argument) { }

	[Address(RVA = "0x16BE620", Offset = "0x16BDA20", Length = "0x2A")]
	[Token(Token = "0x60017DB")]
	public virtual void Invoke(Object[] args) { }

	[Address(RVA = "0x16BE620", Offset = "0x16BDA20", Length = "0x2A")]
	[Token(Token = "0x60017DC")]
	public virtual void Invoke(T arg0) { }

}

