namespace UnityEngine.InputSystem.Interactions;

[DisplayName("Tap")]
[Token(Token = "0x2000234")]
public class TapInteraction : IInputInteraction
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C5D")]
	public float duration; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4000C5E")]
	public float pressPoint; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000C5F")]
	private double m_TapStartTime; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000C60")]
	private bool canceledFromTimerExpired; //Field offset: 0x20

	[Token(Token = "0x170005E3")]
	private float durationOrDefault
	{
		[Address(RVA = "0x291F6F0", Offset = "0x291EAF0", Length = "0x6C")]
		[Token(Token = "0x600149D")]
		private get { } //Length: 108
	}

	[Token(Token = "0x170005E4")]
	private float pressPointOrDefault
	{
		[Address(RVA = "0x291F760", Offset = "0x291EB60", Length = "0x53")]
		[Token(Token = "0x600149E")]
		private get { } //Length: 83
	}

	[Token(Token = "0x170005E5")]
	private float releasePointOrDefault
	{
		[Address(RVA = "0x291F7C0", Offset = "0x291EBC0", Length = "0x76")]
		[Token(Token = "0x600149F")]
		private get { } //Length: 118
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60014A2")]
	public TapInteraction() { }

	[Address(RVA = "0x291F6F0", Offset = "0x291EAF0", Length = "0x6C")]
	[Token(Token = "0x600149D")]
	private float get_durationOrDefault() { }

	[Address(RVA = "0x291F760", Offset = "0x291EB60", Length = "0x53")]
	[Token(Token = "0x600149E")]
	private float get_pressPointOrDefault() { }

	[Address(RVA = "0x291F7C0", Offset = "0x291EBC0", Length = "0x76")]
	[Token(Token = "0x600149F")]
	private float get_releasePointOrDefault() { }

	[Address(RVA = "0x291F570", Offset = "0x291E970", Length = "0x17B")]
	[Token(Token = "0x60014A0")]
	public override void Process(ref InputInteractionContext context) { }

	[Address(RVA = "0x290FC60", Offset = "0x290F060", Length = "0x9")]
	[Token(Token = "0x60014A1")]
	public override void Reset() { }

}

