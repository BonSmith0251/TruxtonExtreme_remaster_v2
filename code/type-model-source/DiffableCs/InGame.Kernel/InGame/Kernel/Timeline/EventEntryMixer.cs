namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F3")]
public class EventEntryMixer : PlayableBehaviour
{

	[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
	[Token(Token = "0x60007C6")]
	public EventEntryMixer() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x60007C5")]
	public virtual void OnGraphStart(Playable playable) { }

}

