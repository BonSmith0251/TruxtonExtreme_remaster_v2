namespace UnityEngine.Timeline;

[DefaultMember("Item")]
[Token(Token = "0x2000045")]
internal struct MarkerList : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x0")]
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400012A")]
	private List<ScriptableObject> m_Objects; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[HideInInspector]
	[Token(Token = "0x400012B")]
	private List<IMarker> m_Cache; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400012C")]
	private bool m_CacheDirty; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x400012D")]
	private bool m_HasNotifications; //Field offset: 0x11

	[Token(Token = "0x170000BD")]
	public int Count
	{
		[Address(RVA = "0x2F2F9E0", Offset = "0x2F2EDE0", Length = "0x46")]
		[Token(Token = "0x600028A")]
		 get { } //Length: 70
	}

	[Token(Token = "0x170000BE")]
	public IMarker Item
	{
		[Address(RVA = "0x2F2FA30", Offset = "0x2F2EE30", Length = "0x5B")]
		[Token(Token = "0x600028B")]
		 get { } //Length: 91
	}

	[Token(Token = "0x170000BC")]
	public List<IMarker> markers
	{
		[Address(RVA = "0x2F2F6B0", Offset = "0x2F2EAB0", Length = "0x1A")]
		[Token(Token = "0x6000282")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x2F2F910", Offset = "0x2F2ED10", Length = "0xC8")]
	[Token(Token = "0x6000283")]
	public MarkerList(int capacity) { }

	[Address(RVA = "0x2F2EFF0", Offset = "0x2F2E3F0", Length = "0x89")]
	[Token(Token = "0x6000284")]
	public void Add(ScriptableObject item) { }

	[Address(RVA = "0x2F2F080", Offset = "0x2F2E480", Length = "0x245")]
	[Token(Token = "0x6000291")]
	private void BuildCache() { }

	[Address(RVA = "0x2F2F2D0", Offset = "0x2F2E6D0", Length = "0x5D")]
	[Token(Token = "0x6000287")]
	public void Clear() { }

	[Address(RVA = "0x2F2F330", Offset = "0x2F2E730", Length = "0x52")]
	[Token(Token = "0x6000288")]
	public bool Contains(ScriptableObject item) { }

	[Address(RVA = "0x2F2F390", Offset = "0x2F2E790", Length = "0x31E")]
	[Token(Token = "0x600028D")]
	public IMarker CreateMarker(Type type, double time, TrackAsset owner) { }

	[Address(RVA = "0x2F2F9E0", Offset = "0x2F2EDE0", Length = "0x46")]
	[Token(Token = "0x600028A")]
	public int get_Count() { }

	[Address(RVA = "0x2F2FA30", Offset = "0x2F2EE30", Length = "0x5B")]
	[Token(Token = "0x600028B")]
	public IMarker get_Item(int idx) { }

	[Address(RVA = "0x2F2F6B0", Offset = "0x2F2EAB0", Length = "0x1A")]
	[Token(Token = "0x6000282")]
	public List<IMarker> get_markers() { }

	[Address(RVA = "0x2F2F6B0", Offset = "0x2F2EAB0", Length = "0x1A")]
	[Token(Token = "0x6000289")]
	public IEnumerable<IMarker> GetMarkers() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x600028C")]
	public List<ScriptableObject> GetRawMarkerList() { }

	[Address(RVA = "0x2F2F6D0", Offset = "0x2F2EAD0", Length = "0x1A")]
	[Token(Token = "0x600028E")]
	public bool HasNotifications() { }

	[Address(RVA = "0x2F2F6F0", Offset = "0x2F2EAF0", Length = "0x16B")]
	[Token(Token = "0x6000285")]
	public bool Remove(IMarker item) { }

	[Address(RVA = "0x2F2F860", Offset = "0x2F2EC60", Length = "0xAF")]
	[Token(Token = "0x6000286")]
	public bool Remove(ScriptableObject item, TimelineAsset timelineAsset, PlayableAsset thingToDirty) { }

	[Address(RVA = "0xE0B640", Offset = "0xE0AA40", Length = "0x5")]
	[Token(Token = "0x6000290")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600028F")]
	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}

