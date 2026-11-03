namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x20001E6")]
public class XblSocialManagerUserGroupHandle : EquatableHandle
{

	[Token(Token = "0x170001CF")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000A24")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x6000A22")]
	internal XblSocialManagerUserGroupHandle(XblSocialManagerUserGroupHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000A24")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000A25")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B8B6F0", Offset = "0x2B8AAF0", Length = "0x94")]
	[Token(Token = "0x6000A23")]
	internal static int WrapAndReturnHResult(int hresult, XblSocialManagerUserGroupHandle interopHandle, out XblSocialManagerUserGroupHandle handle) { }

}

