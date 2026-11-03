namespace UnityEngine.InputSystem.UI;

[Token(Token = "0x200011A")]
internal class ExtendedSubmitCancelEventData : BaseEventData, INavigationEventData
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000678")]
	private InputDevice <device>k__BackingField; //Field offset: 0x20

	[Token(Token = "0x17000386")]
	public override InputDevice device
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000D5C")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000D5D")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x29D63B0", Offset = "0x29D57B0", Length = "0x8")]
	[Token(Token = "0x6000D5E")]
	public ExtendedSubmitCancelEventData(EventSystem eventSystem) { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000D5C")]
	public override InputDevice get_device() { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000D5D")]
	public void set_device(InputDevice value) { }

}

