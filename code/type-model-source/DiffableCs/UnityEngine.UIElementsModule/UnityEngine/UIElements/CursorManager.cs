namespace UnityEngine.UIElements;

[Token(Token = "0x2000189")]
internal class CursorManager : ICursorManager
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000779")]
	private bool <isCursorOverriden>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700020C")]
	public private bool isCursorOverriden
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA3")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000BA4")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000BA7")]
	public CursorManager() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA3")]
	public bool get_isCursorOverriden() { }

	[Address(RVA = "0x33AC7D0", Offset = "0x33ABBD0", Length = "0x6B")]
	[Token(Token = "0x6000BA6")]
	public override void ResetCursor() { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000BA4")]
	private void set_isCursorOverriden(bool value) { }

	[Address(RVA = "0x33AC840", Offset = "0x33ABC40", Length = "0x123")]
	[Token(Token = "0x6000BA5")]
	public override void SetCursor(Cursor cursor) { }

}

