namespace UnityEngine.Rendering;

[Token(Token = "0x20000D3")]
public interface IDebugDisplaySettingsQuery
{

	[Token(Token = "0x170000AF")]
	public bool AreAnySettingsActive
	{
		[Token(Token = "0x6000790")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000B1")]
	public bool IsLightingActive
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000792")]
		 get { } //Length: 3
	}

	[Token(Token = "0x170000B0")]
	public bool IsPostProcessingAllowed
	{
		[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
		[Token(Token = "0x6000791")]
		 get { } //Length: 3
	}

	[Token(Token = "0x6000790")]
	public bool get_AreAnySettingsActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000792")]
	public bool get_IsLightingActive() { }

	[Address(RVA = "0x60A0D0", Offset = "0x6094D0", Length = "0x3")]
	[Token(Token = "0x6000791")]
	public bool get_IsPostProcessingAllowed() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000793")]
	public bool TryGetScreenClearColor(ref Color color) { }

}

