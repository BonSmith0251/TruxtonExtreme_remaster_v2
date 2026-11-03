namespace Unity.XGamingRuntime;

[Token(Token = "0x200028B")]
public class XTaskQueueTerminateCallbackHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DC")]
	internal XTaskQueueTerminateCallbackHandle interop; //Field offset: 0x10

	[Token(Token = "0x170002E6")]
	public bool IsValid
	{
		[Address(RVA = "0x2B842E0", Offset = "0x2B836E0", Length = "0x44")]
		[Token(Token = "0x6000D6B")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002E7")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D6C")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D6D")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B84250", Offset = "0x2B83650", Length = "0x87")]
	[Token(Token = "0x6000D6A")]
	internal XTaskQueueTerminateCallbackHandle(XTaskQueueTerminatedCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B84200", Offset = "0x2B83600", Length = "0x44")]
	[Token(Token = "0x6000D6E")]
	public void Dispose() { }

	[Address(RVA = "0x2B842E0", Offset = "0x2B836E0", Length = "0x44")]
	[Token(Token = "0x6000D6B")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D6C")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D6D")]
	public void set_Token(ulong value) { }

}

