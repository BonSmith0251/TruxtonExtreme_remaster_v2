namespace UnityEngine.UIElements;

[Token(Token = "0x20002A4")]
public abstract class MouseManipulator : Manipulator
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000A71")]
	private List<ManipulatorActivationFilter> <activators>k__BackingField; //Field offset: 0x18

	[Token(Token = "0x17000383")]
	public private List<ManipulatorActivationFilter> activators
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001253")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6001254")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x3406CD0", Offset = "0x34060D0", Length = "0x77")]
	[Token(Token = "0x6001255")]
	protected MouseManipulator() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6001253")]
	public List<ManipulatorActivationFilter> get_activators() { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6001254")]
	private void set_activators(List<ManipulatorActivationFilter> value) { }

}

