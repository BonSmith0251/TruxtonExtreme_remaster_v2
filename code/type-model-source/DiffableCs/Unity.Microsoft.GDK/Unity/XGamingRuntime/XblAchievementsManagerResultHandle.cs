namespace Unity.XGamingRuntime;

[MovedFrom("Unity.GameCore")]
[Token(Token = "0x2000153")]
public class XblAchievementsManagerResultHandle : EquatableHandle
{

	[Token(Token = "0x170000A0")]
	public virtual bool IsInvalid
	{
		[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
		[Token(Token = "0x60007A4")]
		 get { } //Length: 9
	}

	[Address(RVA = "0x2B7C0D0", Offset = "0x2B7B4D0", Length = "0x1F")]
	[Token(Token = "0x60007A0")]
	internal XblAchievementsManagerResultHandle(XblAchievementsManagerResultHandle interopHandle) { }

	[Address(RVA = "0x2B7E760", Offset = "0x2B7DB60", Length = "0x7F")]
	[Token(Token = "0x60007A2")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x5C4C10", Offset = "0x5C4010", Length = "0x9")]
	[Token(Token = "0x60007A4")]
	public virtual bool get_IsInvalid() { }

	[Address(RVA = "0x2B33CB0", Offset = "0x2B330B0", Length = "0x1E")]
	[Token(Token = "0x60007A3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2B33910", Offset = "0x2B32D10", Length = "0x20")]
	[Token(Token = "0x60007A6")]
	public static bool op_Equality(XblAchievementsManagerResultHandle handle1, XblAchievementsManagerResultHandle handle2) { }

	[Address(RVA = "0x2B33930", Offset = "0x2B32D30", Length = "0x36")]
	[Token(Token = "0x60007A7")]
	public static bool op_Inequality(XblAchievementsManagerResultHandle handle1, XblAchievementsManagerResultHandle handle2) { }

	[Address(RVA = "0x2B7E7E0", Offset = "0x2B7DBE0", Length = "0x24")]
	[Token(Token = "0x60007A5")]
	protected virtual bool ReleaseHandle() { }

	[Address(RVA = "0x2B7E810", Offset = "0x2B7DC10", Length = "0x94")]
	[Token(Token = "0x60007A1")]
	internal static int WrapAndReturnHResult(int hresult, XblAchievementsManagerResultHandle interopHandle, out XblAchievementsManagerResultHandle handle) { }

}

