namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x200014D")]
public class XblAchievementsResultHandle : EquatableHandle
{

	[Token(Token = "0x17000098")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x6000790")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x600078F")]
	internal XblAchievementsResultHandle(XblAchievementsResultHandle interopHandle) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x6000790")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B7E9E0", Offset = "0x2B7DDE0", Length = "0x24")]
	[Token(Token = "0x6000791")]
	protected virtual bool ReleaseHandle() { }

}

