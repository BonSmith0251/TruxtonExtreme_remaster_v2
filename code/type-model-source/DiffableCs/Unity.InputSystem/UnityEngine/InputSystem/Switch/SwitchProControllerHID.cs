namespace UnityEngine.InputSystem.Switch;

[InputControlLayout(stateType = typeof(SwitchProControllerHIDInputState), displayName = "Switch Pro Controller")]
[Token(Token = "0x2000129")]
public class SwitchProControllerHID : Gamepad, IInputStateCallbackReceiver, IEventPreProcessor
{
	[Token(Token = "0x200012C")]
	private struct SwitchFullInputReport
	{
		[Token(Token = "0x400070C")]
		public const int kSize = 25; //Field offset: 0x0
		[Token(Token = "0x400070D")]
		public const byte ExpectedReportId = 48; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400070E")]
		public byte reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x400070F")]
		public byte buttons0; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000710")]
		public byte buttons1; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000711")]
		public byte buttons2; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000712")]
		public byte left0; //Field offset: 0x6
		[FieldOffset(Offset = "0x7")]
		[Token(Token = "0x4000713")]
		public byte left1; //Field offset: 0x7
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000714")]
		public byte left2; //Field offset: 0x8
		[FieldOffset(Offset = "0x9")]
		[Token(Token = "0x4000715")]
		public byte right0; //Field offset: 0x9
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x4000716")]
		public byte right1; //Field offset: 0xA
		[FieldOffset(Offset = "0xB")]
		[Token(Token = "0x4000717")]
		public byte right2; //Field offset: 0xB

		[Address(RVA = "0x29E4EB0", Offset = "0x29E42B0", Length = "0x2C2")]
		[Token(Token = "0x6000E48")]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	[Token(Token = "0x200012D")]
	private struct SwitchHIDGenericInputReport
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000718")]
		public byte reportId; //Field offset: 0x0

		[Token(Token = "0x170003CD")]
		public static FourCC Format
		{
			[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
			[Token(Token = "0x6000E49")]
			 get { } //Length: 58
		}

		[Address(RVA = "0x29E5180", Offset = "0x29E4580", Length = "0x3A")]
		[Token(Token = "0x6000E49")]
		public static FourCC get_Format() { }

	}

	[Token(Token = "0x200012A")]
	private struct SwitchInputOnlyReport
	{
		[Token(Token = "0x40006FA")]
		public const int kSize = 7; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40006FB")]
		public byte buttons0; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x40006FC")]
		public byte buttons1; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x40006FD")]
		public byte hat; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x40006FE")]
		public byte leftX; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x40006FF")]
		public byte leftY; //Field offset: 0x4
		[FieldOffset(Offset = "0x5")]
		[Token(Token = "0x4000700")]
		public byte rightX; //Field offset: 0x5
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000701")]
		public byte rightY; //Field offset: 0x6

		[Address(RVA = "0x29E51C0", Offset = "0x29E45C0", Length = "0x2B0")]
		[Token(Token = "0x6000E46")]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	[Token(Token = "0x2000131")]
	public struct SwitchMagicOutputHIDBluetooth : IInputDeviceCommandInfo
	{
		[Token(Token = "0x4000724")]
		public const int kSize = 57; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000725")]
		public InputDeviceCommand baseCommand; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000726")]
		public SwitchMagicOutputReport report; //Field offset: 0x8

		[Token(Token = "0x170003CE")]
		public static FourCC Type
		{
			[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
			[Token(Token = "0x6000E4A")]
			 get { } //Length: 58
		}

		[Token(Token = "0x170003CF")]
		public override FourCC typeStatic
		{
			[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
			[Token(Token = "0x6000E4B")]
			 get { } //Length: 58
		}

		[Address(RVA = "0x29E5490", Offset = "0x29E4890", Length = "0xBD")]
		[Token(Token = "0x6000E4C")]
		public static SwitchMagicOutputHIDBluetooth Create(CommandIdType type) { }

		[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
		[Token(Token = "0x6000E4A")]
		public static FourCC get_Type() { }

		[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
		[Token(Token = "0x6000E4B")]
		public override FourCC get_typeStatic() { }

	}

	[Token(Token = "0x2000132")]
	public struct SwitchMagicOutputHIDUSB : IInputDeviceCommandInfo
	{
		[Token(Token = "0x4000727")]
		public const int kSize = 72; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000728")]
		public InputDeviceCommand baseCommand; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000729")]
		public SwitchMagicOutputReport report; //Field offset: 0x8

		[Token(Token = "0x170003D0")]
		public static FourCC Type
		{
			[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
			[Token(Token = "0x6000E4D")]
			 get { } //Length: 58
		}

		[Token(Token = "0x170003D1")]
		public override FourCC typeStatic
		{
			[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
			[Token(Token = "0x6000E4E")]
			 get { } //Length: 58
		}

		[Address(RVA = "0x29E55D0", Offset = "0x29E49D0", Length = "0xBE")]
		[Token(Token = "0x6000E4F")]
		public static SwitchMagicOutputHIDUSB Create(CommandIdType type) { }

		[Address(RVA = "0x29E5550", Offset = "0x29E4950", Length = "0x3A")]
		[Token(Token = "0x6000E4D")]
		public static FourCC get_Type() { }

		[Address(RVA = "0x29E5590", Offset = "0x29E4990", Length = "0x3A")]
		[Token(Token = "0x6000E4E")]
		public override FourCC get_typeStatic() { }

	}

	[Token(Token = "0x200012E")]
	public struct SwitchMagicOutputReport
	{
		[Token(Token = "0x2000130")]
		internal enum CommandIdType : int
		{
			Status = 1,
			Handshake = 2,
			Highspeed = 3,
			ForceUSB = 4,
		}

		[Token(Token = "0x200012F")]
		public enum ReportType : int
		{
			Magic = 128,
		}

		[Token(Token = "0x4000719")]
		public const int kSize = 49; //Field offset: 0x0
		[Token(Token = "0x400071A")]
		public const byte ExpectedReplyInputReportId = 129; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400071B")]
		public byte reportType; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x400071C")]
		public byte commandId; //Field offset: 0x1

	}

	[Token(Token = "0x200012B")]
	private struct SwitchSimpleInputReport
	{
		[Token(Token = "0x4000702")]
		public const int kSize = 12; //Field offset: 0x0
		[Token(Token = "0x4000703")]
		public const byte ExpectedReportId = 63; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000704")]
		public byte reportId; //Field offset: 0x0
		[FieldOffset(Offset = "0x1")]
		[Token(Token = "0x4000705")]
		public byte buttons0; //Field offset: 0x1
		[FieldOffset(Offset = "0x2")]
		[Token(Token = "0x4000706")]
		public byte buttons1; //Field offset: 0x2
		[FieldOffset(Offset = "0x3")]
		[Token(Token = "0x4000707")]
		public byte hat; //Field offset: 0x3
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000708")]
		public ushort leftX; //Field offset: 0x4
		[FieldOffset(Offset = "0x6")]
		[Token(Token = "0x4000709")]
		public ushort leftY; //Field offset: 0x6
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x400070A")]
		public ushort rightX; //Field offset: 0x8
		[FieldOffset(Offset = "0xA")]
		[Token(Token = "0x400070B")]
		public ushort rightY; //Field offset: 0xA

		[Address(RVA = "0x29E6350", Offset = "0x29E5750", Length = "0x308")]
		[Token(Token = "0x6000E47")]
		public SwitchProControllerHIDInputState ToHIDInputReport() { }

	}

	[Token(Token = "0x40006F5")]
	private static readonly CommandIdType[] s_HandshakeSequence; //Field offset: 0x0
	[Token(Token = "0x40006F8")]
	internal const byte JitterMaskLow = 120; //Field offset: 0x0
	[Token(Token = "0x40006F9")]
	internal const byte JitterMaskHigh = 135; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x210")]
	[Token(Token = "0x40006F3")]
	private ButtonControl <captureButton>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x40006F4")]
	private ButtonControl <homeButton>k__BackingField; //Field offset: 0x218
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x40006F6")]
	private int m_HandshakeStepIndex; //Field offset: 0x220
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x40006F7")]
	private double m_HandshakeTimer; //Field offset: 0x228

	[InputControl(name = "capture", displayName = "Capture")]
	[Token(Token = "0x170003CB")]
	public ButtonControl captureButton
	{
		[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000E39")]
		 get { } //Length: 8
		[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000E3A")]
		 set { } //Length: 19
	}

	[InputControl(name = "home", displayName = "Home")]
	[Token(Token = "0x170003CC")]
	public ButtonControl homeButton
	{
		[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000E3B")]
		 get { } //Length: 8
		[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000E3C")]
		 set { } //Length: 19
	}

	[Address(RVA = "0x29E62C0", Offset = "0x29E56C0", Length = "0x8C")]
	[Token(Token = "0x6000E45")]
	private static SwitchProControllerHID() { }

	[Address(RVA = "0x28EAAD0", Offset = "0x28E9ED0", Length = "0x7")]
	[Token(Token = "0x6000E44")]
	public SwitchProControllerHID() { }

	[Address(RVA = "0x1D4E420", Offset = "0x1D4D820", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000E39")]
	public ButtonControl get_captureButton() { }

	[Address(RVA = "0x28EA910", Offset = "0x28E9D10", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x6000E3B")]
	public ButtonControl get_homeButton() { }

	[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
	[Token(Token = "0x6000E42")]
	public override bool GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	[Address(RVA = "0x29E59A0", Offset = "0x29E4DA0", Length = "0x75")]
	[Token(Token = "0x6000E3E")]
	private void HandshakeRestart() { }

	[Address(RVA = "0x29E5A20", Offset = "0x29E4E20", Length = "0x398")]
	[Token(Token = "0x6000E3F")]
	private void HandshakeTick() { }

	[Address(RVA = "0x29E5DC0", Offset = "0x29E51C0", Length = "0x10B")]
	[Token(Token = "0x6000E3D")]
	protected virtual void OnAdded() { }

	[Address(RVA = "0x29E5ED0", Offset = "0x29E52D0", Length = "0x7")]
	[Token(Token = "0x6000E40")]
	public override void OnNextUpdate() { }

	[Address(RVA = "0x29E5EE0", Offset = "0x29E52E0", Length = "0x18C")]
	[Token(Token = "0x6000E41")]
	public override void OnStateEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x29E6070", Offset = "0x29E5470", Length = "0x243")]
	[Token(Token = "0x6000E43")]
	public override bool PreProcessEvent(InputEventPtr eventPtr) { }

	[Address(RVA = "0x1D4E6A0", Offset = "0x1D4DAA0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000E3A")]
	protected void set_captureButton(ButtonControl value) { }

	[Address(RVA = "0x28EA9C0", Offset = "0x28E9DC0", Length = "0x13")]
	[CompilerGenerated]
	[Token(Token = "0x6000E3C")]
	protected void set_homeButton(ButtonControl value) { }

}

