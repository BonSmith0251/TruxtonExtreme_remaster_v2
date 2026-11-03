namespace UnityEngine.UIElements;

[Token(Token = "0x200055A")]
internal class VisualElementAnimationSystem : BaseVisualTreeUpdater
{
	[Token(Token = "0x40011B6")]
	private static readonly string s_Description; //Field offset: 0x0
	[Token(Token = "0x40011B7")]
	private static readonly ProfilerMarker s_ProfilerMarker; //Field offset: 0x8
	[Token(Token = "0x40011B8")]
	private static readonly string s_StylePropertyAnimationDescription; //Field offset: 0x10
	[Token(Token = "0x40011B9")]
	private static readonly ProfilerMarker s_StylePropertyAnimationProfilerMarker; //Field offset: 0x18
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40011B2")]
	private HashSet<IValueAnimationUpdate> m_Animations; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40011B3")]
	private List<IValueAnimationUpdate> m_IterationList; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x40011B4")]
	private bool m_HasNewAnimations; //Field offset: 0x38
	[FieldOffset(Offset = "0x39")]
	[Token(Token = "0x40011B5")]
	private bool m_IterationListDirty; //Field offset: 0x39
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40011BA")]
	private double lastUpdate; //Field offset: 0x40

	[Token(Token = "0x17000A1B")]
	public virtual ProfilerMarker profilerMarker
	{
		[Address(RVA = "0x32E7BC0", Offset = "0x32E6FC0", Length = "0x4F")]
		[Token(Token = "0x6002708")]
		 get { } //Length: 79
	}

	[Token(Token = "0x17000A1C")]
	private static ProfilerMarker stylePropertyAnimationProfilerMarker
	{
		[Address(RVA = "0x32E7C10", Offset = "0x32E7010", Length = "0x4F")]
		[Token(Token = "0x6002709")]
		private get { } //Length: 79
	}

	[Address(RVA = "0x32E79D0", Offset = "0x32E6DD0", Length = "0x117")]
	[Token(Token = "0x6002711")]
	private static VisualElementAnimationSystem() { }

	[Address(RVA = "0x32E7AF0", Offset = "0x32E6EF0", Length = "0xC3")]
	[Token(Token = "0x6002710")]
	public VisualElementAnimationSystem() { }

	[Address(RVA = "0x32E7BC0", Offset = "0x32E6FC0", Length = "0x4F")]
	[Token(Token = "0x6002708")]
	public virtual ProfilerMarker get_profilerMarker() { }

	[Address(RVA = "0x32E7C10", Offset = "0x32E7010", Length = "0x4F")]
	[Token(Token = "0x6002709")]
	private static ProfilerMarker get_stylePropertyAnimationProfilerMarker() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x600270F")]
	public virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	[Address(RVA = "0x32E7290", Offset = "0x32E6690", Length = "0x5A")]
	[Token(Token = "0x600270C")]
	public void RegisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x32E72F0", Offset = "0x32E66F0", Length = "0x144")]
	[Token(Token = "0x600270D")]
	public void RegisterAnimations(List<IValueAnimationUpdate> anims) { }

	[Address(RVA = "0x32E7440", Offset = "0x32E6840", Length = "0x58")]
	[Token(Token = "0x600270A")]
	public void UnregisterAnimation(IValueAnimationUpdate anim) { }

	[Address(RVA = "0x32E74A0", Offset = "0x32E68A0", Length = "0x142")]
	[Token(Token = "0x600270B")]
	public void UnregisterAnimations(List<IValueAnimationUpdate> anims) { }

	[Address(RVA = "0x32E75F0", Offset = "0x32E69F0", Length = "0x3D8")]
	[Token(Token = "0x600270E")]
	public virtual void Update() { }

}

