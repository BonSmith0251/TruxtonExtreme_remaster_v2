namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200015A")]
public class XblHttpCallHandle : EquatableHandle
{

	[Token(Token = "0x170000A1")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x60007B2")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x60007B0")]
	internal XblHttpCallHandle(XblHttpCallHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x60007B2")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B7EA10", Offset = "0x2B7DE10", Length = "0x24")]
	[Token(Token = "0x60007B3")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B7EA40", Offset = "0x2B7DE40", Length = "0x94")]
	[Token(Token = "0x60007B1")]
	internal static int WrapInteropHandleAndReturnHResult(int hresult, XblHttpCallHandle interopHandle, out XblHttpCallHandle handle) { }

}

