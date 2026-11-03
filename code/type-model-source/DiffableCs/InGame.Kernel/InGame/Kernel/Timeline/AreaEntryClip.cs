namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000C8")]
public class AreaEntryClip : PlayableAsset, ITimelineClipAsset
{
	[Flags]
	[Token(Token = "0x20000C9")]
	internal enum AreaAttribute : int
	{
		None = 0,
		Terminate = 2,
		NoRestart = 4,
		Loop = 8,
		Stop = 16,
		Ghost = 1073741824,
		BGSection = -2147483648,
	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40005D5")]
	private string _AreaName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40005D6")]
	private AreaAttribute _AreaAttribue; //Field offset: 0x20

	[Token(Token = "0x1700014A")]
	public string AreaName
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000707")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700014B")]
	public AreaAttribute Attribute
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x6000708")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000149")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
		[Token(Token = "0x6000706")]
		 get { } //Length: 3
	}

	[Token(Token = "0x17000150")]
	public bool IsGhost
	{
		[Address(RVA = "0x1D30550", Offset = "0x1D2F950", Length = "0x9")]
		[Token(Token = "0x600070D")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014C")]
	public bool IsLoop
	{
		[Address(RVA = "0x1D30560", Offset = "0x1D2F960", Length = "0x9")]
		[Token(Token = "0x6000709")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014F")]
	public bool IsNoRestart
	{
		[Address(RVA = "0x1D30570", Offset = "0x1D2F970", Length = "0x9")]
		[Token(Token = "0x600070C")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014D")]
	public bool IsStop
	{
		[Address(RVA = "0x1D30580", Offset = "0x1D2F980", Length = "0x9")]
		[Token(Token = "0x600070A")]
		 get { } //Length: 9
	}

	[Token(Token = "0x1700014E")]
	public bool IsTerminate
	{
		[Address(RVA = "0x1D30590", Offset = "0x1D2F990", Length = "0x8")]
		[Token(Token = "0x600070B")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1D30510", Offset = "0x1D2F910", Length = "0x36")]
	[Token(Token = "0x600070F")]
	public AreaEntryClip() { }

	[Address(RVA = "0x1D30420", Offset = "0x1D2F820", Length = "0xE8")]
	[Token(Token = "0x600070E")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000707")]
	public string get_AreaName() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x6000708")]
	public AreaAttribute get_Attribute() { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x6000706")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x1D30550", Offset = "0x1D2F950", Length = "0x9")]
	[Token(Token = "0x600070D")]
	public bool get_IsGhost() { }

	[Address(RVA = "0x1D30560", Offset = "0x1D2F960", Length = "0x9")]
	[Token(Token = "0x6000709")]
	public bool get_IsLoop() { }

	[Address(RVA = "0x1D30570", Offset = "0x1D2F970", Length = "0x9")]
	[Token(Token = "0x600070C")]
	public bool get_IsNoRestart() { }

	[Address(RVA = "0x1D30580", Offset = "0x1D2F980", Length = "0x9")]
	[Token(Token = "0x600070A")]
	public bool get_IsStop() { }

	[Address(RVA = "0x1D30590", Offset = "0x1D2F990", Length = "0x8")]
	[Token(Token = "0x600070B")]
	public bool get_IsTerminate() { }

}

