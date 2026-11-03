namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001F7")]
public class XblTitleStorageBlobMetadataResultHandle : EquatableHandle
{

	[Token(Token = "0x170001E1")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000A78")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000A77")]
	internal XblTitleStorageBlobMetadataResultHandle(XblTitleStorageBlobMetadataResultHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000A78")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B8C910", Offset = "0x2B8BD10", Length = "0x19")]
	[Token(Token = "0x6000A79")]
	protected virtual bool ReleaseHandle() { }

}

