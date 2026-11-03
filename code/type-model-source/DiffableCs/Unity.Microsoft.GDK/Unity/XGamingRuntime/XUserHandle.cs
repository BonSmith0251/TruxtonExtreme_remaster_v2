namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20002A6")]
public class XUserHandle : EquatableHandle
{

	[Token(Token = "0x17000302")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000DC9")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000DC5")]
	internal XUserHandle(IntPtr interopHandle) { }

	[Address(RVA = "0x2BA6210", Offset = "0x2BA5610", Length = "0x1C")]
	[Token(Token = "0x6000DC6")]
	internal XUserHandle(IntPtr interopHandle, bool ownsHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000DC9")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2BA60E0", Offset = "0x2BA54E0", Length = "0x8F")]
	[Token(Token = "0x6000DC8")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2BA6170", Offset = "0x2BA5570", Length = "0x95")]
	[Token(Token = "0x6000DC7")]
	internal static int WrapAndReturnHResult(int hresult, IntPtr interopHandle, out XUserHandle handle) { }

}

