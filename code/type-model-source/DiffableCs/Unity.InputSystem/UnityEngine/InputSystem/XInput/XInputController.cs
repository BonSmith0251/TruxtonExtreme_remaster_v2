namespace UnityEngine.InputSystem.XInput;

[InputControlLayout(displayName = "Xbox Controller")]
[Token(Token = "0x2000100")]
public class XInputController : Gamepad
{
	[Token(Token = "0x2000104")]
	public struct Capabilities
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40005FD")]
		public DeviceType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40005FE")]
		public DeviceSubType subType; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x40005FF")]
		public DeviceFlags flags; //Field offset: 0x8

	}

	[Flags]
	[Token(Token = "0x2000103")]
	internal enum DeviceFlags : int
	{
		ForceFeedbackSupported = 1,
		Wireless = 2,
		VoiceSupported = 4,
		PluginModulesSupported = 8,
		NoNavigation = 16,
	}

	[Token(Token = "0x2000102")]
	internal enum DeviceSubType : int
	{
		Unknown = 0,
		Gamepad = 1,
		Wheel = 2,
		ArcadeStick = 3,
		FlightStick = 4,
		DancePad = 5,
		Guitar = 6,
		GuitarAlternate = 7,
		DrumKit = 8,
		GuitarBass = 11,
		ArcadePad = 19,
	}

	[Token(Token = "0x2000101")]
	public enum DeviceType : int
	{
		Gamepad = 0,
	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40005E4")]
	private ButtonControl <menu>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40005E5")]
	private ButtonControl <view>k__BackingField; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40005E6")]
	private bool m_HaveParsedCapabilities; //Field offset: 0x220
	[FieldOffset(Offset = "0x224")]
	[Token(Token = "0x40005E7")]
	private DeviceSubType m_SubType; //Field offset: 0x224
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40005E8")]
	private DeviceFlags m_Flags; //Field offset: 0x228

	[Token(Token = "0x1700035F")]
	public DeviceFlags flags
	{
		[Address(RVA = "0x29D16A0", Offset = "0x29D0AA0", Length = "0x31")]
		[Token(Token = "0x6000CC9")]
		 get { } //Length: 49
	}

	[InputControl(name = "buttonSouth", displayName = "A")]
	[InputControl(name = "buttonEast", displayName = "B")]
	[InputControl(name = "buttonWest", displayName = "X")]
	[InputControl(name = "buttonNorth", displayName = "Y")]
	[InputControl(name = "leftShoulder", displayName = "Left Bumper", shortDisplayName = "LB")]
	[InputControl(name = "rightShoulder", displayName = "Right Bumper", shortDisplayName = "RB")]
	[InputControl(name = "leftTrigger", shortDisplayName = "LT")]
	[InputControl(name = "rightTrigger", shortDisplayName = "RT")]
	[InputControl(name = "start", displayName = "Menu", alias = "menu")]
	[InputControl(name = "select", displayName = "View", alias = "view")]
	[Token(Token = "0x1700035C")]
	public ButtonControl menu
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC4")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC5")]
		 set { } //Length: 19
	}

	[Token(Token = "0x1700035E")]
	public DeviceSubType subType
	{
		[Address(RVA = "0x29D16E0", Offset = "0x29D0AE0", Length = "0x31")]
		[Token(Token = "0x6000CC8")]
		 get { } //Length: 49
	}

	[Token(Token = "0x1700035D")]
	public ButtonControl view
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC6")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000CC7")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000CCC")]
	public XInputController() { }

	[Address(RVA = "0x29D15C0", Offset = "0x29D09C0", Length = "0x49")]
	[Token(Token = "0x6000CCA")]
	protected virtual void FinishSetup() { }

	[Address(RVA = "0x29D16A0", Offset = "0x29D0AA0", Length = "0x31")]
	[Token(Token = "0x6000CC9")]
	public DeviceFlags get_flags() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC4")]
	public ButtonControl get_menu() { }

	[Address(RVA = "0x29D16E0", Offset = "0x29D0AE0", Length = "0x31")]
	[Token(Token = "0x6000CC8")]
	public DeviceSubType get_subType() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC6")]
	public ButtonControl get_view() { }

	[Address(RVA = "0x29D1610", Offset = "0x29D0A10", Length = "0x8D")]
	[Token(Token = "0x6000CCB")]
	private void ParseCapabilities() { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC5")]
	protected void set_menu(ButtonControl value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000CC7")]
	protected void set_view(ButtonControl value) { }

}

