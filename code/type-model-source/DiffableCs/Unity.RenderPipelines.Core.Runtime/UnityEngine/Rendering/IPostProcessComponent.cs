namespace UnityEngine.Rendering;

[Token(Token = "0x200014E")]
public interface IPostProcessComponent
{

	[Token(Token = "0x6000AF1")]
	public bool IsActive() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Obsolete("Unused #from(2023.1)")]
	[Token(Token = "0x6000AF2")]
	public bool IsTileCompatible() { }

}

