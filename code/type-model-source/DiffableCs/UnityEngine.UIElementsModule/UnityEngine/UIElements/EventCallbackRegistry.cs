namespace UnityEngine.UIElements;

[Token(Token = "0x20001D2")]
internal class EventCallbackRegistry
{
	[Token(Token = "0x20001D3")]
	public struct DynamicCallbackList
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000844")]
		private TrickleDown m_UseTrickleDown; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[NotNull]
		[Token(Token = "0x4000845")]
		private EventCallbackList m_Callbacks; //Field offset: 0x8
		[CanBeNull]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000846")]
		private EventCallbackList m_TemporaryCallbacks; //Field offset: 0x10
		[CanBeNull]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000847")]
		private List<EventCallbackFunctorBase> m_UnregisteredCallbacksDuringInvoke; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000848")]
		private int m_IsInvoking; //Field offset: 0x20

		[Address(RVA = "0x1E20010", Offset = "0x1E1F410", Length = "0x4")]
		[Token(Token = "0x6000D37")]
		private void BeginInvoke() { }

		[Address(RVA = "0x33C8380", Offset = "0x33C7780", Length = "0xD8")]
		[Token(Token = "0x6000D32")]
		public static DynamicCallbackList Create(TrickleDown useTrickleDown) { }

		[Address(RVA = "0x33C8460", Offset = "0x33C7860", Length = "0x24B")]
		[Token(Token = "0x6000D38")]
		private void EndInvoke() { }

		[Address(RVA = "0x33C86B0", Offset = "0x33C7AB0", Length = "0xE")]
		[IsReadOnly]
		[NotNull]
		[Token(Token = "0x6000D34")]
		public EventCallbackList GetCallbackListForReading() { }

		[Address(RVA = "0x33C86C0", Offset = "0x33C7AC0", Length = "0xF2")]
		[NotNull]
		[Token(Token = "0x6000D33")]
		public EventCallbackList GetCallbackListForWriting() { }

		[Address(RVA = "0x33C87C0", Offset = "0x33C7BC0", Length = "0x2B6")]
		[Token(Token = "0x6000D36")]
		public void Invoke(EventBase evt, BaseVisualElementPanel panel, VisualElement target) { }

		[Address(RVA = "0x33C8A80", Offset = "0x33C7E80", Length = "0x25C")]
		[Token(Token = "0x6000D35")]
		public bool UnregisterCallback(long eventTypeId, Delegate callback) { }

	}

	[Token(Token = "0x4000841")]
	private static readonly EventCallbackListPool s_ListPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000842")]
	internal DynamicCallbackList m_TrickleDownCallbacks; //Field offset: 0x10
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000843")]
	internal DynamicCallbackList m_BubbleUpCallbacks; //Field offset: 0x38

	[Address(RVA = "0x33CAFE0", Offset = "0x33CA3E0", Length = "0xD2")]
	[Token(Token = "0x6000D31")]
	private static EventCallbackRegistry() { }

	[Address(RVA = "0x33CB0C0", Offset = "0x33CA4C0", Length = "0x81")]
	[Token(Token = "0x6000D30")]
	public EventCallbackRegistry() { }

	[Address(RVA = "0x33CAE90", Offset = "0x33CA290", Length = "0x68")]
	[Token(Token = "0x6000D29")]
	private static EventCallbackList GetCallbackList(EventCallbackList initializer = null) { }

	[Address(RVA = "0x33CAF00", Offset = "0x33CA300", Length = "0x18")]
	[Token(Token = "0x6000D2B")]
	private DynamicCallbackList GetDynamicCallbackList(TrickleDown useTrickleDown) { }

	[Address(RVA = "0x7E9370", Offset = "0x7E8770", Length = "0x143")]
	[Token(Token = "0x6000D2C")]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x7E9200", Offset = "0x7E8600", Length = "0x161")]
	[Token(Token = "0x6000D2D")]
	public void RegisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, TrickleDown useTrickleDown = 0, InvokePolicy invokePolicy = 0) { }

	[Address(RVA = "0x33CAF20", Offset = "0x33CA320", Length = "0xB8")]
	[Token(Token = "0x6000D2A")]
	private static void ReleaseCallbackList(EventCallbackList toRelease) { }

	[Address(RVA = "0x7E94C0", Offset = "0x7E88C0", Length = "0x9A")]
	[Token(Token = "0x6000D2E")]
	public bool UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x7E94C0", Offset = "0x7E88C0", Length = "0x9A")]
	[Token(Token = "0x6000D2F")]
	public bool UnregisterCallback(EventCallback<TEventType, TCallbackArgs> callback, TrickleDown useTrickleDown = 0) { }

}

