namespace UnityEngine.Rendering;

[Token(Token = "0x20000D1")]
public interface IDebugDisplaySettingsPanel
{

	[Token(Token = "0x170000AE")]
	public Flags Flags
	{
		[Token(Token = "0x600078F")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000AC")]
	public string PanelName
	{
		[Token(Token = "0x600078D")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170000AD")]
	public Widget[] Widgets
	{
		[Token(Token = "0x600078E")]
		 get { } //Length: 0
	}

	[Token(Token = "0x600078F")]
	public Flags get_Flags() { }

	[Token(Token = "0x600078D")]
	public string get_PanelName() { }

	[Token(Token = "0x600078E")]
	public Widget[] get_Widgets() { }

}

