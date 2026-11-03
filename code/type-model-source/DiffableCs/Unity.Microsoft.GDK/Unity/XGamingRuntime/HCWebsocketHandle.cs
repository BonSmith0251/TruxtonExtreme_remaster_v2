namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000007")]
public class HCWebsocketHandle : EquatableHandle
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000019")]
	internal HCWebSocketMessageFunction messageFunc; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400001A")]
	internal HCWebSocketBinaryMessageFunction binaryMessageFunc; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400001B")]
	internal HCWebSocketCloseEventFunction closeFunc; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400001C")]
	internal HCWebSocketMessageFunction messageCallback; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400001D")]
	internal HCWebSocketBinaryMessageFunction binaryMessageCallback; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400001E")]
	internal HCWebSocketCloseEventFunction closeCallback; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400001F")]
	internal GCHandle cbHandle; //Field offset: 0x50

	[Token(Token = "0x17000007")]
	public HCWebSocketBinaryMessageFunction BinaryMessageFunction
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x600001D")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000008")]
	public HCWebSocketCloseEventFunction CloseFunction
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x600001E")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000009")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x600001F")]
		 get { } //Length: 9
	}

	[Token(Token = "0x17000006")]
	public HCWebSocketMessageFunction MessageFunction
	{
		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[Token(Token = "0x600001C")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2B33DE0", Offset = "0x2B331E0", Length = "0x2C")]
	[Token(Token = "0x6000014")]
	internal HCWebsocketHandle(IntPtr handle) { }

	[Address(RVA = "0x1E7C710", Offset = "0x1E7BB10", Length = "0x29")]
	[Token(Token = "0x6000015")]
	internal HCWebsocketHandle(IntPtr handle, bool ownsHandle) { }

	[Address(RVA = "0x2B33C30", Offset = "0x2B33030", Length = "0x7F")]
	[Token(Token = "0x6000017")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x600001D")]
	public HCWebSocketBinaryMessageFunction get_BinaryMessageFunction() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x600001E")]
	public HCWebSocketCloseEventFunction get_CloseFunction() { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x600001F")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
	[Token(Token = "0x600001C")]
	public HCWebSocketMessageFunction get_MessageFunction() { }

	[Address(RVA = "0x2B33CB0", Offset = "0x2B330B0", Length = "0x1E")]
	[Token(Token = "0x6000018")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B33910", Offset = "0x2B32D10", Length = "0x20")]
	[Token(Token = "0x600001A")]
	public static bool op_Equality(HCWebsocketHandle handle1, HCWebsocketHandle handle2) { }

	[Address(RVA = "0x2B33930", Offset = "0x2B32D30", Length = "0x36")]
	[Token(Token = "0x600001B")]
	public static bool op_Inequality(HCWebsocketHandle handle1, HCWebsocketHandle handle2) { }

	[Address(RVA = "0x2B33CD0", Offset = "0x2B330D0", Length = "0x24")]
	[Token(Token = "0x6000019")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B33D00", Offset = "0x2B33100", Length = "0xDF")]
	[Token(Token = "0x6000016")]
	internal static int WrapAndReturnHResult(int hresult, IntPtr interopHandle, out HCWebsocketHandle handle, GCHandle callbackHandle) { }

}

