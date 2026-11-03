namespace UnityEngine.InputSystem.UI;

[Token(Token = "0x2000116")]
internal class ExtendedAxisEventData : AxisEventData, INavigationEventData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000667")]
	private InputDevice <device>k__BackingField; //Field offset: 0x30

	[Token(Token = "0x1700037E")]
	public override InputDevice device
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D43")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D44")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x29D5620", Offset = "0x29D4A20", Length = "0x8")]
	[Token(Token = "0x6000D45")]
	public ExtendedAxisEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D43")]
	public override InputDevice get_device() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D44")]
	public void set_device(InputDevice value) { }

	[Address(RVA = "0x29D5580", Offset = "0x29D4980", Length = "0x98")]
	[Token(Token = "0x6000D46")]
	public virtual string ToString() { }

}

