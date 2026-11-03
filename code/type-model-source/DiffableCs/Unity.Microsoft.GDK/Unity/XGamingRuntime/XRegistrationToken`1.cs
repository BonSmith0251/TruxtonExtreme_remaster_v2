namespace Unity.XGamingRuntime;

[Token(Token = "0x200025A")]
public abstract class XRegistrationToken : CallbackWrapper<T>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400065F")]
	public ulong Token; //Field offset: 0x0

	[Token(Token = "0x1700026C")]
	public bool IsValid
	{
		[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
		[Token(Token = "0x6000C33")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x1550FA0", Offset = "0x15503A0", Length = "0x1E")]
	[Token(Token = "0x6000C32")]
	protected XRegistrationToken`1(T callback, IntPtr context, T staticCallback) { }

	[Address(RVA = "0x1550F30", Offset = "0x1550330", Length = "0x64")]
	[Token(Token = "0x6000C34")]
	protected virtual void Dispose(bool disposing) { }

	[Token(Token = "0x6000C35")]
	protected abstract void DisposeInternal(bool disposing) { }

	[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
	[Token(Token = "0x6000C33")]
	public bool get_IsValid() { }

}

