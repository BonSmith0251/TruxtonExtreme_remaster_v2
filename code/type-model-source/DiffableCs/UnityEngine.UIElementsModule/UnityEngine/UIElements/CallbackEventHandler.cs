namespace UnityEngine.UIElements;

[Token(Token = "0x20001D7")]
public abstract class CallbackEventHandler : IEventHandler
{
	[Token(Token = "0x4000852")]
	internal const string HandleEventBubbleUpName = "HandleEventBubbleUp"; //Field offset: 0x0
	[Token(Token = "0x4000853")]
	internal const string HandleEventTrickleDownName = "HandleEventTrickleDown"; //Field offset: 0x0
	[Token(Token = "0x4000854")]
	internal const string ExecuteDefaultActionName = "ExecuteDefaultAction"; //Field offset: 0x0
	[Token(Token = "0x4000855")]
	internal const string ExecuteDefaultActionAtTargetName = "ExecuteDefaultActionAtTarget"; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000850")]
	internal bool isIMGUIContainer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000851")]
	internal EventCallbackRegistry m_CallbackRegistry; //Field offset: 0x18

	[Address(RVA = "0x33C66F0", Offset = "0x33C5AF0", Length = "0xB")]
	[Token(Token = "0x6000D68")]
	protected CallbackEventHandler() { }

	[Address(RVA = "0x79C080", Offset = "0x79B480", Length = "0xDF")]
	[Token(Token = "0x6000D52")]
	private void AddEventCategories(TrickleDown useTrickleDown) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	[Token(Token = "0x6000D60")]
	protected override void ExecuteDefaultAction(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUp. Before proceeding, make sure you understand the latest changes to UIToolkit event propagation rules by visiting Unity's manual page https://docs.unity3d.com/Manual/UIE-Events-Dispatching.html")]
	[Token(Token = "0x6000D59")]
	protected override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	[Address(RVA = "0x31ED5D0", Offset = "0x31EC9D0", Length = "0x14")]
	[Token(Token = "0x6000D65")]
	internal void ExecuteDefaultActionAtTargetInternal(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[Token(Token = "0x6000D62")]
	internal override void ExecuteDefaultActionDisabled(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("Use HandleEventBubbleUpDisabled.")]
	[Token(Token = "0x6000D61")]
	internal override void ExecuteDefaultActionDisabledAtTarget(EventBase evt) { }

	[Address(RVA = "0x217E200", Offset = "0x217D600", Length = "0x14")]
	[Token(Token = "0x6000D66")]
	internal void ExecuteDefaultActionDisabledAtTargetInternal(EventBase evt) { }

	[Address(RVA = "0x33C6510", Offset = "0x33C5910", Length = "0x14")]
	[Token(Token = "0x6000D64")]
	internal void ExecuteDefaultActionDisabledInternal(EventBase evt) { }

	[Address(RVA = "0x1E06DA0", Offset = "0x1E061A0", Length = "0x14")]
	[Token(Token = "0x6000D63")]
	internal void ExecuteDefaultActionInternal(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D5A")]
	protected override void HandleEventBubbleUp(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D5B")]
	internal override void HandleEventBubbleUpDisabled(EventBase evt) { }

	[Address(RVA = "0x240CAA0", Offset = "0x240BEA0", Length = "0x14")]
	[Token(Token = "0x6000D5C")]
	internal void HandleEventBubbleUpInternal(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D5D")]
	protected override void HandleEventTrickleDown(EventBase evt) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[EventInterest(EventInterestOptions::Inherit (0))]
	[Token(Token = "0x6000D5E")]
	internal override void HandleEventTrickleDownDisabled(EventBase evt) { }

	[Address(RVA = "0x29217F0", Offset = "0x2920BF0", Length = "0x14")]
	[Token(Token = "0x6000D5F")]
	internal void HandleEventTrickleDownInternal(EventBase evt) { }

	[Address(RVA = "0x33C6530", Offset = "0x33C5930", Length = "0x1B0")]
	[Token(Token = "0x6000D67")]
	protected void NotifyPropertyChanged(in BindingId property) { }

	[Address(RVA = "0x79C580", Offset = "0x79B980", Length = "0xCF")]
	[Token(Token = "0x6000D54")]
	internal void RegisterCallback(EventCallback<TEventType> callback, InvokePolicy invokePolicy, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x79C450", Offset = "0x79B850", Length = "0x122")]
	[Token(Token = "0x6000D53")]
	public void RegisterCallback(EventCallback<TEventType, TUserArgsType> callback, TUserArgsType userArgs, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x79C650", Offset = "0x79BA50", Length = "0x119")]
	[Token(Token = "0x6000D50")]
	public void RegisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x79C160", Offset = "0x79B560", Length = "0x11C")]
	[Token(Token = "0x6000D51")]
	public void RegisterCallbackOnce(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

	[Token(Token = "0x6000D58")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.HierarchyModule"})]
	internal abstract void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	[Token(Token = "0x6000D57")]
	public abstract void SendEvent(EventBase e) { }

	[Address(RVA = "0x79C820", Offset = "0x79BC20", Length = "0xA1")]
	[Token(Token = "0x6000D56")]
	public void UnregisterCallback(EventCallback<TEventType, TUserArgsType> callback, TrickleDown useTrickleDown = 0) { }

	[Address(RVA = "0x79C820", Offset = "0x79BC20", Length = "0xA1")]
	[Token(Token = "0x6000D55")]
	public void UnregisterCallback(EventCallback<TEventType> callback, TrickleDown useTrickleDown = 0) { }

}

