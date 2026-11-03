namespace System;

[ComVisible(True)]
[Token(Token = "0x20001C0")]
public abstract class MulticastDelegate : Delegate
{
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000716")]
	private Delegate[] delegates; //Field offset: 0x78

	[Address(RVA = "0x2085AA0", Offset = "0x2084EA0", Length = "0x3A0")]
	[Token(Token = "0x6000FF4")]
	protected virtual Delegate CombineImpl(Delegate follow) { }

	[Address(RVA = "0x2085E50", Offset = "0x2085250", Length = "0xB1")]
	[Token(Token = "0x6000FEF")]
	protected virtual object DynamicInvokeImpl(Object[] args) { }

	[Address(RVA = "0x2085F10", Offset = "0x2085310", Length = "0x16F")]
	[Token(Token = "0x6000FF0")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x207F0E0", Offset = "0x207E4E0", Length = "0x94")]
	[Token(Token = "0x6000FF1")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2086080", Offset = "0x2085480", Length = "0xE5")]
	[Token(Token = "0x6000FF3")]
	public virtual Delegate[] GetInvocationList() { }

	[Address(RVA = "0x2086170", Offset = "0x2085570", Length = "0x16D")]
	[Token(Token = "0x6000FF2")]
	protected virtual MethodInfo GetMethodImpl() { }

	[Address(RVA = "0x207F340", Offset = "0x207E740", Length = "0x239")]
	[Token(Token = "0x6000FEE")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x20862E0", Offset = "0x20856E0", Length = "0x189")]
	[Token(Token = "0x6000FF5")]
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	[Address(RVA = "0x2086470", Offset = "0x2085870", Length = "0x376")]
	[Token(Token = "0x6000FF6")]
	protected virtual Delegate RemoveImpl(Delegate value) { }

}

