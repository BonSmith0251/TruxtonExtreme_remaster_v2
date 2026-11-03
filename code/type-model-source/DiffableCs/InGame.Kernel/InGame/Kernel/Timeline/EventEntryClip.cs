namespace InGame.Kernel.Timeline;

[Token(Token = "0x20000F1")]
public class EventEntryClip : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x20000F2")]
	internal enum TLEventType : int
	{
		none = 0,
		itemCarry = 1,
		displayText = 100,
		displayGauge = 101,
		playSound = 110,
		forceQuit = 10000,
	}

	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000681")]
	private TLEventType _eventType; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Token(Token = "0x4000682")]
	private Kind _itemValue; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000683")]
	private int _intValue; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000684")]
	private int _dropIndex; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000685")]
	private float _floatValue; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000686")]
	private string _strValue; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x4000687")]
	private Vector3 _vectorValue; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Token(Token = "0x4000688")]
	private Kind[] _drops; //Field offset: 0x48

	[Token(Token = "0x17000161")]
	public override ClipCaps clipCaps
	{
		[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
		[Token(Token = "0x60007B8")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000162")]
	public TLEventType EventType
	{
		[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
		[Token(Token = "0x60007B9")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000165")]
	public float FloatValue
	{
		[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
		[Token(Token = "0x60007BC")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000164")]
	public int IntValue
	{
		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[Token(Token = "0x60007BB")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000168")]
	public bool IsDrops
	{
		[Address(RVA = "0x1D376C0", Offset = "0x1D36AC0", Length = "0x49")]
		[Token(Token = "0x60007BF")]
		 get { } //Length: 73
	}

	[Token(Token = "0x17000163")]
	public Kind ItemValue
	{
		[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
		[Token(Token = "0x60007BA")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000166")]
	public string StrValue
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60007BD")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000167")]
	public Vector3 VectorValue
	{
		[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
		[Token(Token = "0x60007BE")]
		 get { } //Length: 19
	}

	[Address(RVA = "0x1D37640", Offset = "0x1D36A40", Length = "0x6F")]
	[Token(Token = "0x60007C4")]
	public EventEntryClip() { }

	[Address(RVA = "0x1D37470", Offset = "0x1D36870", Length = "0x8")]
	[Token(Token = "0x60007C1")]
	public void ClearIndex() { }

	[Address(RVA = "0x1D37480", Offset = "0x1D36880", Length = "0x122")]
	[Token(Token = "0x60007C0")]
	public virtual Playable CreatePlayable(PlayableGraph graph, GameObject owner) { }

	[Address(RVA = "0x1D37710", Offset = "0x1D36B10", Length = "0x6")]
	[Token(Token = "0x60007B8")]
	public override ClipCaps get_clipCaps() { }

	[Address(RVA = "0x5C4C00", Offset = "0x5C4000", Length = "0x4")]
	[Token(Token = "0x60007B9")]
	public TLEventType get_EventType() { }

	[Address(RVA = "0x1D376B0", Offset = "0x1D36AB0", Length = "0x6")]
	[Token(Token = "0x60007BC")]
	public float get_FloatValue() { }

	[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
	[Token(Token = "0x60007BB")]
	public int get_IntValue() { }

	[Address(RVA = "0x1D376C0", Offset = "0x1D36AC0", Length = "0x49")]
	[Token(Token = "0x60007BF")]
	public bool get_IsDrops() { }

	[Address(RVA = "0xFE29D0", Offset = "0xFE1DD0", Length = "0x4")]
	[Token(Token = "0x60007BA")]
	public Kind get_ItemValue() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60007BD")]
	public string get_StrValue() { }

	[Address(RVA = "0x1D14EC0", Offset = "0x1D142C0", Length = "0x13")]
	[Token(Token = "0x60007BE")]
	public Vector3 get_VectorValue() { }

	[Address(RVA = "0x1D375B0", Offset = "0x1D369B0", Length = "0x84")]
	[Token(Token = "0x60007C3")]
	public Kind GetDrop() { }

	[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
	[Token(Token = "0x60007C2")]
	public void SetIntValue(int tint) { }

}

