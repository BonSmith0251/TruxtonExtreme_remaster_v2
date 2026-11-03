namespace Unity.XGamingRuntime;

[Token(Token = "0x2000289")]
public class XTaskQueueMonitorCallbackHandle
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006DA")]
	internal XTaskQueueMonitorCallbackHandle interop; //Field offset: 0x10

	[Token(Token = "0x170002E2")]
	public bool IsValid
	{
		[Address(RVA = "0x2B84100", Offset = "0x2B83500", Length = "0x44")]
		[Token(Token = "0x6000D5F")]
		 get { } //Length: 68
	}

	[Token(Token = "0x170002E3")]
	public ulong Token
	{
		[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
		[Token(Token = "0x6000D60")]
		 get { } //Length: 27
		[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
		[Token(Token = "0x6000D61")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x2B84060", Offset = "0x2B83460", Length = "0x9F")]
	[Token(Token = "0x6000D5E")]
	internal XTaskQueueMonitorCallbackHandle(XTaskQueueHandle queue, XTaskQueueMonitorCallback callback, IntPtr context) { }

	[Address(RVA = "0x2B83FD0", Offset = "0x2B833D0", Length = "0x44")]
	[Token(Token = "0x6000D64")]
	public void Dispose() { }

	[Address(RVA = "0x2B84100", Offset = "0x2B83500", Length = "0x44")]
	[Token(Token = "0x6000D5F")]
	public bool get_IsValid() { }

	[Address(RVA = "0x5C1260", Offset = "0x5C0660", Length = "0x1B")]
	[Token(Token = "0x6000D60")]
	public ulong get_Token() { }

	[Address(RVA = "0x2B7CEA0", Offset = "0x2B7C2A0", Length = "0x1B")]
	[Token(Token = "0x6000D61")]
	public void set_Token(ulong value) { }

	[Address(RVA = "0x2B84040", Offset = "0x2B83440", Length = "0x1E")]
	[Token(Token = "0x6000D62")]
	public void Unregister(XTaskQueueHandle queue) { }

	[Address(RVA = "0x2B84020", Offset = "0x2B83420", Length = "0x1D")]
	[Token(Token = "0x6000D63")]
	public void Unregister() { }

}

