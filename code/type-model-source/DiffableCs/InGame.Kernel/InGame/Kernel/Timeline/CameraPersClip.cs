namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000DA")]
public class CameraPersClip : PlayableAsset, ITimelineClipAsset
{
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005F6")]
	private float _camPers; //Field offset: 0x18

	[Token(Token = "0x17000157")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
		[Token(Token = "0x6000743")]
		 get { } //Length: 6
	}

	[Address(RVA = "0x1D308B0", Offset = "0x1D2FCB0", Length = "0x7")]
	[Token(Token = "0x6000745")]
	public CameraPersClip() { }

	[Address(RVA = "0x1D31DB0", Offset = "0x1D311B0", Length = "0x10A")]
	[Token(Token = "0x6000744")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x9DCB30", Offset = "0x9DBF30", Length = "0x6")]
	[Token(Token = "0x6000743")]
	public override ClipCaps get_clipCaps() { }

}

