namespace UnityEngine.Rendering;

[Token(Token = "0x20000D0")]
public interface IDebugDisplaySettingsData : IDebugDisplaySettingsQuery
{

	[Token(Token = "0x600078B")]
	public IDebugDisplaySettingsPanelDisposable CreatePanel() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600078C")]
	public void Reset() { }

}

