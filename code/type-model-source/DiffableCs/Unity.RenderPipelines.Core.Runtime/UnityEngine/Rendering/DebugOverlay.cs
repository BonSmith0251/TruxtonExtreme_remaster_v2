namespace UnityEngine.Rendering;

[Token(Token = "0x2000096")]
public class DebugOverlay
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000208")]
	private int <x>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000209")]
	private int <y>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400020A")]
	private int <overlaySize>k__BackingField; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x400020B")]
	private int m_InitialPositionX; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400020C")]
	private int m_ScreenWidth; //Field offset: 0x20

	[Token(Token = "0x1700006B")]
	public private int overlaySize
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000680")]
		 get { } //Length: 4
		[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000681")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000069")]
	public private int x
	{
		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600067C")]
		 get { } //Length: 85
		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600067D")]
		private set { } //Length: 4
	}

	[Token(Token = "0x1700006A")]
	public private int y
	{
		[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600067E")]
		 get { } //Length: 4
		[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600067F")]
		private set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000685")]
	public DebugOverlay() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000680")]
	public int get_overlaySize() { }

	[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
	[CompilerGenerated]
	[Token(Token = "0x600067C")]
	public int get_x() { }

	[Address(RVA = "0xAFF470", Offset = "0xAFE870", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600067E")]
	public int get_y() { }

	[Address(RVA = "0x2BDED20", Offset = "0x2BDE120", Length = "0x71")]
	[Token(Token = "0x6000683")]
	public Rect Next(float aspect = 1) { }

	[Address(RVA = "0xF4AFB0", Offset = "0xF4A3B0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000681")]
	private void set_overlaySize(int value) { }

	[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600067D")]
	private void set_x(int value) { }

	[Address(RVA = "0xFC02A0", Offset = "0xFBF6A0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600067F")]
	private void set_y(int value) { }

	[Address(RVA = "0x2BDEDA0", Offset = "0x2BDE1A0", Length = "0x5E")]
	[Token(Token = "0x6000684")]
	public void SetViewport(CommandBuffer cmd) { }

	[Address(RVA = "0x2BDEE00", Offset = "0x2BDE200", Length = "0x16")]
	[Token(Token = "0x6000682")]
	public void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth) { }

}

