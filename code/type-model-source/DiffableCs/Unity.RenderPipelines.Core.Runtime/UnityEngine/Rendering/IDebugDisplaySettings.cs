namespace UnityEngine.Rendering;

[Token(Token = "0x20000CF")]
public interface IDebugDisplaySettings
{

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600078A")]
	public IDebugDisplaySettingsData Add(IDebugDisplaySettingsData newData) { }

	[Token(Token = "0x6000789")]
	public void ForEach(Action<IDebugDisplaySettingsData> onExecute) { }

	[Token(Token = "0x6000788")]
	public void Reset() { }

}

