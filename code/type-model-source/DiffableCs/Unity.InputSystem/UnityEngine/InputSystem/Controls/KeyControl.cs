namespace UnityEngine.InputSystem.Controls;

[Token(Token = "0x2000226")]
public class KeyControl : ButtonControl
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000C28")]
	private Key <keyCode>k__BackingField; //Field offset: 0x148
	[FieldOffset(Offset = "0x14C")]
	[Token(Token = "0x4000C29")]
	private int m_ScanCode; //Field offset: 0x14C

	[Token(Token = "0x170005BC")]
	public Key keyCode
	{
		[Address(RVA = "0x291D4B0", Offset = "0x291C8B0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x600142F")]
		 get { } //Length: 7
		[Address(RVA = "0x291D4E0", Offset = "0x291C8E0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001430")]
		 set { } //Length: 7
	}

	[Token(Token = "0x170005BD")]
	public int scanCode
	{
		[Address(RVA = "0x291D4C0", Offset = "0x291C8C0", Length = "0x1C")]
		[Token(Token = "0x6001431")]
		 get { } //Length: 28
	}

	[Address(RVA = "0x290E9C0", Offset = "0x290DDC0", Length = "0x7")]
	[Token(Token = "0x6001433")]
	public KeyControl() { }

	[Address(RVA = "0x291D4B0", Offset = "0x291C8B0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x600142F")]
	public Key get_keyCode() { }

	[Address(RVA = "0x291D4C0", Offset = "0x291C8C0", Length = "0x1C")]
	[Token(Token = "0x6001431")]
	public int get_scanCode() { }

	[Address(RVA = "0x291D2C0", Offset = "0x291C6C0", Length = "0x1E7")]
	[Token(Token = "0x6001432")]
	protected virtual void RefreshConfiguration() { }

	[Address(RVA = "0x291D4E0", Offset = "0x291C8E0", Length = "0x7")]
	[CompilerGenerated]
	[Token(Token = "0x6001430")]
	public void set_keyCode(Key value) { }

}

