namespace UnityEngine.InputSystem;

[DefaultMember("Item")]
[InputControlLayout(stateType = typeof(PenState), isGenericTypeOfDevice = True)]
[Token(Token = "0x2000093")]
public class Pen : Pointer
{
	[CompilerGenerated]
	[Token(Token = "0x40003FC")]
	private static Pen <current>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C0")]
	[Token(Token = "0x40003F3")]
	private ButtonControl <tip>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1C8")]
	[Token(Token = "0x40003F4")]
	private ButtonControl <eraser>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D0")]
	[Token(Token = "0x40003F5")]
	private ButtonControl <firstBarrelButton>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1D8")]
	[Token(Token = "0x40003F6")]
	private ButtonControl <secondBarrelButton>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E0")]
	[Token(Token = "0x40003F7")]
	private ButtonControl <thirdBarrelButton>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1E8")]
	[Token(Token = "0x40003F8")]
	private ButtonControl <fourthBarrelButton>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F0")]
	[Token(Token = "0x40003F9")]
	private ButtonControl <inRange>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x1F8")]
	[Token(Token = "0x40003FA")]
	private Vector2Control <tilt>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	[FieldOffset(Offset = "0x200")]
	[Token(Token = "0x40003FB")]
	private AxisControl <twist>k__BackingField; //Field offset: 0x200

	[Token(Token = "0x17000281")]
	public internal static Pen current
	{
		[Address(RVA = "0x29B0330", Offset = "0x29AF730", Length = "0x36")]
		[CompilerGenerated]
		[Token(Token = "0x600078C")]
		 get { } //Length: 54
		[Address(RVA = "0x29B0370", Offset = "0x29AF770", Length = "0x51")]
		[CompilerGenerated]
		[Token(Token = "0x600078D")]
		internal set { } //Length: 81
	}

	[Token(Token = "0x17000279")]
	public ButtonControl eraser
	{
		[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600077C")]
		 get { } //Length: 8
		[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600077D")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700027A")]
	public ButtonControl firstBarrelButton
	{
		[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600077E")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600077F")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700027D")]
	public ButtonControl fourthBarrelButton
	{
		[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000784")]
		 get { } //Length: 8
		[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000785")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700027E")]
	public ButtonControl inRange
	{
		[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000786")]
		 get { } //Length: 8
		[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000787")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000282")]
	public ButtonControl Item
	{
		[Address(RVA = "0x29B0200", Offset = "0x29AF600", Length = "0x110")]
		[Token(Token = "0x600078E")]
		 get { } //Length: 272
	}

	[Token(Token = "0x1700027B")]
	public ButtonControl secondBarrelButton
	{
		[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000780")]
		 get { } //Length: 8
		[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000781")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700027C")]
	public ButtonControl thirdBarrelButton
	{
		[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000782")]
		 get { } //Length: 8
		[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000783")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700027F")]
	public Vector2Control tilt
	{
		[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000788")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000789")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000278")]
	public ButtonControl tip
	{
		[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600077A")]
		 get { } //Length: 8
		[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600077B")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000280")]
	public AxisControl twist
	{
		[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600078A")]
		 get { } //Length: 8
		[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x600078B")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000792")]
	public Pen() { }

	[Address(RVA = "0x29AFE40", Offset = "0x29AF240", Length = "0x28C")]
	[Token(Token = "0x6000791")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29B0330", Offset = "0x29AF730", Length = "0x36")]
	[CompilerGenerated]
	[Token(Token = "0x600078C")]
	public static Pen get_current() { }

	[Address(RVA = "0x1CDD540", Offset = "0x1CDC940", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600077C")]
	public ButtonControl get_eraser() { }

	[Address(RVA = "0x1CF2830", Offset = "0x1CF1C30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600077E")]
	public ButtonControl get_firstBarrelButton() { }

	[Address(RVA = "0x28D9930", Offset = "0x28D8D30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000784")]
	public ButtonControl get_fourthBarrelButton() { }

	[Address(RVA = "0x28D9940", Offset = "0x28D8D40", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000786")]
	public ButtonControl get_inRange() { }

	[Address(RVA = "0x29B0200", Offset = "0x29AF600", Length = "0x110")]
	[Token(Token = "0x600078E")]
	public ButtonControl get_Item(PenButton button) { }

	[Address(RVA = "0x28D98F0", Offset = "0x28D8CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000780")]
	public ButtonControl get_secondBarrelButton() { }

	[Address(RVA = "0x28D9910", Offset = "0x28D8D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000782")]
	public ButtonControl get_thirdBarrelButton() { }

	[Address(RVA = "0x28D9900", Offset = "0x28D8D00", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000788")]
	public Vector2Control get_tilt() { }

	[Address(RVA = "0x28D9920", Offset = "0x28D8D20", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600077A")]
	public ButtonControl get_tip() { }

	[Address(RVA = "0x22DD9A0", Offset = "0x22DCDA0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x600078A")]
	public AxisControl get_twist() { }

	[Address(RVA = "0x29B00D0", Offset = "0x29AF4D0", Length = "0x9B")]
	[Token(Token = "0x600078F")]
	public virtual void MakeCurrent() { }

	[Address(RVA = "0x29B0170", Offset = "0x29AF570", Length = "0x90")]
	[Token(Token = "0x6000790")]
	protected virtual void OnRemoved() { }

	[Address(RVA = "0x29B0370", Offset = "0x29AF770", Length = "0x51")]
	[CompilerGenerated]
	[Token(Token = "0x600078D")]
	internal static void set_current(Pen value) { }

	[Address(RVA = "0x280F250", Offset = "0x280E650", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600077D")]
	protected void set_eraser(ButtonControl value) { }

	[Address(RVA = "0x1CEA770", Offset = "0x1CE9B70", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600077F")]
	protected void set_firstBarrelButton(ButtonControl value) { }

	[Address(RVA = "0x1D59410", Offset = "0x1D58810", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000785")]
	protected void set_fourthBarrelButton(ButtonControl value) { }

	[Address(RVA = "0x28D99A0", Offset = "0x28D8DA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000787")]
	protected void set_inRange(ButtonControl value) { }

	[Address(RVA = "0x1CEB220", Offset = "0x1CEA620", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000781")]
	protected void set_secondBarrelButton(ButtonControl value) { }

	[Address(RVA = "0x1CDAE80", Offset = "0x1CDA280", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000783")]
	protected void set_thirdBarrelButton(ButtonControl value) { }

	[Address(RVA = "0x28D9980", Offset = "0x28D8D80", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000789")]
	protected void set_tilt(Vector2Control value) { }

	[Address(RVA = "0x1DC6EE0", Offset = "0x1DC62E0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600077B")]
	protected void set_tip(ButtonControl value) { }

	[Address(RVA = "0x28D9960", Offset = "0x28D8D60", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x600078B")]
	protected void set_twist(AxisControl value) { }

}

