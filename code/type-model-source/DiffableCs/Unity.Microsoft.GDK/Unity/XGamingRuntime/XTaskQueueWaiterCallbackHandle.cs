namespace Unity.XGamingRuntime;

[Token(Token = "0x2000288")]
public class XTaskQueueWaiterCallbackHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006D9")]
	internal XTaskQueueWaiterCallbackHandle interop; //Field offset: 0x10

	[Token(Token = "0x170002E0")]
	public bool IsValid
	{
		[Address(RVA = "0x2B84460", Offset = "0x2B83860", Length = "0x44")]
		[Token(Token = "0x6000D58")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002E1")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D59")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D5A")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B843C0", Offset = "0x2B837C0", Length = "0x9F")]
	[Token(Token = "0x6000D57")]
	internal XTaskQueueWaiterCallbackHandle(XTaskQueueHandle queue, XTaskQueueCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B84330", Offset = "0x2B83730", Length = "0x44")]
	[Token(Token = "0x6000D5D")]
	public void Dispose() { }

	[Address(RVA = "0x2B84460", Offset = "0x2B83860", Length = "0x44")]
	[Token(Token = "0x6000D58")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D59")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D5A")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B84380", Offset = "0x2B83780", Length = "0x1E")]
	[Token(Token = "0x6000D5B")]
	public void Unregister(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B843A0", Offset = "0x2B837A0", Length = "0x1D")]
	[Token(Token = "0x6000D5C")]
	public void Unregister() { }

}

