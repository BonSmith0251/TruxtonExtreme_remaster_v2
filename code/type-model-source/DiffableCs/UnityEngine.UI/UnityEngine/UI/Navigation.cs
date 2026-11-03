namespace UnityEngine.UI;

[Token(Token = "0x200005C")]
public struct Navigation : IEquatable<Navigation>
{
	[Flags]
	[Token(Token = "0x200005D")]
	internal enum Mode : int
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Automatic = 3,
		Explicit = 4,
	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001A7")]
	private Mode m_Mode; //Field offset: 0x0
	[FieldOffset(Offset = "0x4")]
	[SerializeField]
	[Token(Token = "0x40001A8")]
	[Tooltip("Enables navigation to wrap around from last to first or first to last element. Does not work for automatic grid navigation")]
	private bool m_WrapAround; //Field offset: 0x4
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40001A9")]
	private Selectable m_SelectOnUp; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001AA")]
	private Selectable m_SelectOnDown; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001AB")]
	private Selectable m_SelectOnLeft; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001AC")]
	private Selectable m_SelectOnRight; //Field offset: 0x20

	[Token(Token = "0x170000E3")]
	public static Navigation defaultNavigation
	{
		[Address(RVA = "0x344B960", Offset = "0x344AD60", Length = "0x1A")]
		[Token(Token = "0x600037B")]
		 get { } //Length: 26
	}

	[Token(Token = "0x170000DD")]
	public Mode mode
	{
		[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
		[Token(Token = "0x600036F")]
		 get { } //Length: 3
		[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
		[Token(Token = "0x6000370")]
		 set { } //Length: 3
	}

	[Token(Token = "0x170000E0")]
	public Selectable selectOnDown
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000375")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000376")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E1")]
	public Selectable selectOnLeft
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000377")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x6000378")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000E2")]
	public Selectable selectOnRight
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x6000379")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x600037A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000DF")]
	public Selectable selectOnUp
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x6000373")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x6000374")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170000DE")]
	public bool wrapAround
	{
		[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
		[Token(Token = "0x6000371")]
		 get { } //Length: 5
		[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
		[Token(Token = "0x6000372")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x344B850", Offset = "0x344AC50", Length = "0x10C")]
	[Token(Token = "0x600037C")]
	public override bool Equals(Navigation other) { }

	[Address(RVA = "0x344B960", Offset = "0x344AD60", Length = "0x1A")]
	[Token(Token = "0x600037B")]
	public static Navigation get_defaultNavigation() { }

	[Address(RVA = "0x607140", Offset = "0x606540", Length = "0x3")]
	[Token(Token = "0x600036F")]
	public Mode get_mode() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000375")]
	public Selectable get_selectOnDown() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000377")]
	public Selectable get_selectOnLeft() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x6000379")]
	public Selectable get_selectOnRight() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x6000373")]
	public Selectable get_selectOnUp() { }

	[Address(RVA = "0xAEF1A0", Offset = "0xAEE5A0", Length = "0x5")]
	[Token(Token = "0x6000371")]
	public bool get_wrapAround() { }

	[Address(RVA = "0x604240", Offset = "0x603640", Length = "0x3")]
	[Token(Token = "0x6000370")]
	public void set_mode(Mode value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000376")]
	public void set_selectOnDown(Selectable value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x6000378")]
	public void set_selectOnLeft(Selectable value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x600037A")]
	public void set_selectOnRight(Selectable value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x6000374")]
	public void set_selectOnUp(Selectable value) { }

	[Address(RVA = "0x1E16980", Offset = "0x1E15D80", Length = "0x4")]
	[Token(Token = "0x6000372")]
	public void set_wrapAround(bool value) { }

}

