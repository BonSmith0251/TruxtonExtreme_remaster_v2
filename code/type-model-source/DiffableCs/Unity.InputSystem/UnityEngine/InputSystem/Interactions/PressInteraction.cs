namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Press")]
[Token(Token = "0x2000231")]
public class PressInteraction : IInputInteraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C53")]
	[Tooltip("The amount of actuation a control requires before being considered pressed. If not set, default to 'Default Press Point' in the global input settings.")]
	public float pressPoint; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C54")]
	[Tooltip("Determines how button presses trigger the action. By default (PressOnly), the action is performed on press. With ReleaseOnly, the action is performed on release. With PressAndRelease, the action is performed on press and release.")]
	public PressBehavior behavior; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C55")]
	private bool m_WaitingForRelease; //Field offset: 0x18

	[Token(Token = "0x170005DF")]
	private float pressPointOrDefault
	{
		[Address(RVA = "0x291E940", Offset = "0x291DD40", Length = "0x53")]
		[Token(Token = "0x6001493")]
		private get { } //Length: 83
	}

	[Token(Token = "0x170005E0")]
	private float releasePointOrDefault
	{
		[Address(RVA = "0x291E9A0", Offset = "0x291DDA0", Length = "0x76")]
		[Token(Token = "0x6001494")]
		private get { } //Length: 118
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6001497")]
	public PressInteraction() { }

	[Address(RVA = "0x291E940", Offset = "0x291DD40", Length = "0x53")]
	[Token(Token = "0x6001493")]
	private float get_pressPointOrDefault() { }

	[Address(RVA = "0x291E9A0", Offset = "0x291DDA0", Length = "0x76")]
	[Token(Token = "0x6001494")]
	private float get_releasePointOrDefault() { }

	[Address(RVA = "0x291E770", Offset = "0x291DB70", Length = "0x1B7")]
	[Token(Token = "0x6001495")]
	public override void Process(ref InputInteractionContext context) { }

	[Address(RVA = "0x291E930", Offset = "0x291DD30", Length = "0x5")]
	[Token(Token = "0x6001496")]
	public override void Reset() { }

}

