namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x20001D1")]
internal class EventCallbackList
{
	[Token(Token = "0x400083D")]
	public static readonly EventCallbackList EmptyList; //Field offset: 0x0
	[Token(Token = "0x400083E")]
	private static readonly EventCallbackFunctorBase[] EmptyArray; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400083F")]
	private EventCallbackFunctorBase[] m_Array; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000840")]
	private int m_Count; //Field offset: 0x18

	[Token(Token = "0x1700025C")]
	public Span<EventCallbackFunctorBase> Span
	{
		[Address(RVA = "0x33CAD80", Offset = "0x33CA180", Length = "0x103")]
		[Token(Token = "0x6000D26")]
		 get { } //Length: 259
	}

	[Address(RVA = "0x33CAB80", Offset = "0x33C9F80", Length = "0x100")]
	[Token(Token = "0x6000D28")]
	private static EventCallbackList() { }

	[Address(RVA = "0x33CAC80", Offset = "0x33CA080", Length = "0x6B")]
	[Token(Token = "0x6000D20")]
	public EventCallbackList() { }

	[Address(RVA = "0x33CACF0", Offset = "0x33CA0F0", Length = "0x80")]
	[Token(Token = "0x6000D21")]
	public EventCallbackList(EventCallbackList source) { }

	[Address(RVA = "0x33CA8A0", Offset = "0x33C9CA0", Length = "0xFA")]
	[Token(Token = "0x6000D24")]
	public void Add(EventCallbackFunctorBase item) { }

	[Address(RVA = "0x33CA7D0", Offset = "0x33C9BD0", Length = "0xC7")]
	[Token(Token = "0x6000D25")]
	public void AddRange(EventCallbackList list) { }

	[Address(RVA = "0x2081C10", Offset = "0x2081010", Length = "0x28")]
	[Token(Token = "0x6000D27")]
	public void Clear() { }

	[Address(RVA = "0x33CA9A0", Offset = "0x33C9DA0", Length = "0xAE")]
	[Token(Token = "0x6000D22")]
	public EventCallbackFunctorBase Find(long eventTypeId, Delegate callback) { }

	[Address(RVA = "0x33CAD80", Offset = "0x33CA180", Length = "0x103")]
	[Token(Token = "0x6000D26")]
	public Span<EventCallbackFunctorBase> get_Span() { }

	[Address(RVA = "0x33CAA50", Offset = "0x33C9E50", Length = "0x129")]
	[Token(Token = "0x6000D23")]
	public bool Remove(long eventTypeId, Delegate callback, out EventCallbackFunctorBase removedFunctor) { }

}

