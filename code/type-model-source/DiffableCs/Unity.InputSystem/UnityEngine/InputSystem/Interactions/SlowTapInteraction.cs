namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Long Tap")]
[Token(Token = "0x2000233")]
public class SlowTapInteraction : IInputInteraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C5A")]
	public float duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C5B")]
	public float pressPoint; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C5C")]
	private double m_SlowTapStartTime; //Field offset: 0x18

	[Token(Token = "0x170005E1")]
	private float durationOrDefault
	{
		[Address(RVA = "0x291F380", Offset = "0x291E780", Length = "0x6C")]
		[Token(Token = "0x6001498")]
		private get { } //Length: 108
	}

	[Token(Token = "0x170005E2")]
	private float pressPointOrDefault
	{
		[Address(RVA = "0x291F3F0", Offset = "0x291E7F0", Length = "0x53")]
		[Token(Token = "0x6001499")]
		private get { } //Length: 83
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x600149C")]
	public SlowTapInteraction() { }

	[Address(RVA = "0x291F380", Offset = "0x291E780", Length = "0x6C")]
	[Token(Token = "0x6001498")]
	private float get_durationOrDefault() { }

	[Address(RVA = "0x291F3F0", Offset = "0x291E7F0", Length = "0x53")]
	[Token(Token = "0x6001499")]
	private float get_pressPointOrDefault() { }

	[Address(RVA = "0x291F1D0", Offset = "0x291E5D0", Length = "0x1AC")]
	[Token(Token = "0x600149A")]
	public override void Process(ref InputInteractionContext context) { }

	[Address(RVA = "0x290FC60", Offset = "0x290F060", Length = "0x9")]
	[Token(Token = "0x600149B")]
	public override void Reset() { }

}

