namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001B6")]
public class XblPresenceRecordHandle : EquatableHandle
{

	[Token(Token = "0x1700018B")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x600094B")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000949")]
	internal XblPresenceRecordHandle(XblPresenceRecordHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x600094B")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B8AC50", Offset = "0x2B8A050", Length = "0x24")]
	[Token(Token = "0x600094C")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B8AC80", Offset = "0x2B8A080", Length = "0x94")]
	[Token(Token = "0x600094A")]
	internal static int WrapInteropHandleAndReturnHResult(int hresult, XblPresenceRecordHandle interopHandle, out XblPresenceRecordHandle handle) { }

}

