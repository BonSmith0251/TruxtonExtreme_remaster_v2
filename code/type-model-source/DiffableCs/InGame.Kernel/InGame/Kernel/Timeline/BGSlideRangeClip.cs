namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000D6")]
public class BGSlideRangeClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005F4")]
	private float _slideRange; //Field offset: 0x18

	[Token(Token = "0x17000155")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x6000738")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x600073A")]
	public BGSlideRangeClip() { }

	[Address(RVA = "0x1D31980", Offset = "0x1D30D80", Length = "0x10A")]
	[Token(Token = "0x6000739")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6000738")]
	public override ClipCaps get_clipCaps() { }

}

