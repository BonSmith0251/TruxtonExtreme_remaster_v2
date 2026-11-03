namespace UnityEngine.UIElements;

[Token(Token = "0x2000053")]
internal class ClickDetector
{
	[Token(Token = "0x2000054")]
	private class ButtonClickStatus
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000194")]
		public VisualElement m_Target; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000195")]
		public Vector3 m_PointerDownPosition; //Field offset: 0x18
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000196")]
		public long m_LastPointerDownTime; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000197")]
		public int m_ClickCount; //Field offset: 0x30

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600027E")]
		public ButtonClickStatus() { }

		[Address(RVA = "0x321F470", Offset = "0x321E870", Length = "0x6A")]
		[Token(Token = "0x600027D")]
		public void Reset() { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[Token(Token = "0x4000193")]
	private static int <s_DoubleClickTime>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000192")]
	private List<ButtonClickStatus> m_ClickStatus; //Field offset: 0x10

	[Token(Token = "0x17000056")]
	internal static int s_DoubleClickTime
	{
		[Address(RVA = "0x321FFD0", Offset = "0x321F3D0", Length = "0x4D")]
		[CompilerGenerated]
		[Token(Token = "0x6000273")]
		internal get { } //Length: 77
		[Address(RVA = "0x3220020", Offset = "0x321F420", Length = "0x52")]
		[CompilerGenerated]
		[Token(Token = "0x6000274")]
		internal set { } //Length: 82
	}

	[Address(RVA = "0x321FD10", Offset = "0x321F110", Length = "0x39")]
	[Token(Token = "0x600027C")]
	private static ClickDetector() { }

	[Address(RVA = "0x321FD50", Offset = "0x321F150", Length = "0x278")]
	[Token(Token = "0x6000275")]
	public ClickDetector() { }

	[Address(RVA = "0x321F4E0", Offset = "0x321E8E0", Length = "0x96")]
	[Token(Token = "0x6000278")]
	private void CancelClickTracking(EventBase evt) { }

	[Address(RVA = "0x321F580", Offset = "0x321E980", Length = "0x161")]
	[Token(Token = "0x600027B")]
	internal void Cleanup(List<VisualElement> elements) { }

	[Address(RVA = "0x321F6F0", Offset = "0x321EAF0", Length = "0x246")]
	[Token(Token = "0x600027A")]
	private static bool ContainsPointer(VisualElement element, IPointerEvent pe) { }

	[Address(RVA = "0x321FFD0", Offset = "0x321F3D0", Length = "0x4D")]
	[CompilerGenerated]
	[Token(Token = "0x6000273")]
	internal static int get_s_DoubleClickTime() { }

	[Address(RVA = "0x79D6F0", Offset = "0x79CAF0", Length = "0x27F")]
	[Token(Token = "0x6000279")]
	public void ProcessEvent(PointerEventBase<TEvent> evt) { }

	[Address(RVA = "0x321F940", Offset = "0x321ED40", Length = "0x222")]
	[Token(Token = "0x6000277")]
	private void SendClickEvent(EventBase evt) { }

	[Address(RVA = "0x3220020", Offset = "0x321F420", Length = "0x52")]
	[CompilerGenerated]
	[Token(Token = "0x6000274")]
	internal static void set_s_DoubleClickTime(int value) { }

	[Address(RVA = "0x321FB70", Offset = "0x321EF70", Length = "0x198")]
	[Token(Token = "0x6000276")]
	private void StartClickTracking(EventBase evt) { }

}

