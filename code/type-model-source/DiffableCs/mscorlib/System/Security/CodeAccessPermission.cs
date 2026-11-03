namespace System.Security;

[ComVisible(True)]
[MonoTODO("CAS support is experimental (and unsupported).")]
[Token(Token = "0x20002CD")]
public abstract class CodeAccessPermission : IPermission, ISecurityEncodable
{

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600178A")]
	protected CodeAccessPermission() { }

	[Address(RVA = "0x1E9DF30", Offset = "0x1E9D330", Length = "0xB1")]
	[Token(Token = "0x6001791")]
	internal static PermissionState CheckPermissionState(PermissionState state, bool allowUnrestricted) { }

	[Address(RVA = "0x1E9DFF0", Offset = "0x1E9D3F0", Length = "0x25")]
	[Conditional("MONO_FEATURE_CAS")]
	[Token(Token = "0x600178B")]
	public override void Demand() { }

	[Address(RVA = "0x1E9E020", Offset = "0x1E9D420", Length = "0x125")]
	[ComVisible(False)]
	[Token(Token = "0x600178C")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[ComVisible(False)]
	[Token(Token = "0x600178D")]
	public virtual int GetHashCode() { }

	[Token(Token = "0x600178E")]
	public abstract bool IsSubsetOf(IPermission target) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6001792")]
	private override void System.Security.IPermission.Demand() { }

	[Address(RVA = "0x1E9E160", Offset = "0x1E9D560", Length = "0x3C")]
	[Token(Token = "0x600178F")]
	public virtual string ToString() { }

	[Token(Token = "0x6001790")]
	public abstract SecurityElement ToXml() { }

}

