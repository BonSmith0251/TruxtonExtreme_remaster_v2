namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Hold")]
[Token(Token = "0x200022E")]
public class HoldInteraction : IInputInteraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C44")]
	public float duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C45")]
	public float pressPoint; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C46")]
	private double m_TimePressed; //Field offset: 0x18

	[Token(Token = "0x170005D9")]
	private float durationOrDefault
	{
		[Address(RVA = "0x290FC70", Offset = "0x290F070", Length = "0x6C")]
		[Token(Token = "0x6001487")]
		private get { } //Length: 108
	}

	[Token(Token = "0x170005DA")]
	private float pressPointOrDefault
	{
		[Address(RVA = "0x290FCE0", Offset = "0x290F0E0", Length = "0x53")]
		[Token(Token = "0x6001488")]
		private get { } //Length: 83
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600148B")]
	public HoldInteraction() { }

	[Address(RVA = "0x290FC70", Offset = "0x290F070", Length = "0x6C")]
	[Token(Token = "0x6001487")]
	private float get_durationOrDefault() { }

	[Address(RVA = "0x290FCE0", Offset = "0x290F0E0", Length = "0x53")]
	[Token(Token = "0x6001488")]
	private float get_pressPointOrDefault() { }

	[Address(RVA = "0x290FB20", Offset = "0x290EF20", Length = "0x134")]
	[Token(Token = "0x6001489")]
	public override void Process(ref InputInteractionContext context) { }

	[Address(RVA = "0x290FC60", Offset = "0x290F060", Length = "0x9")]
	[Token(Token = "0x600148A")]
	public override void Reset() { }

}

