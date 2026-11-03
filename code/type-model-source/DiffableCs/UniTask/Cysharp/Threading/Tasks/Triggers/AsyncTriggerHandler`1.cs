namespace Cysharp.Threading.Tasks.Triggers;

[Token(Token = "0x2000173")]
public sealed class AsyncTriggerHandler : IAsyncOneShotTrigger, IUniTaskSource<T>, IUniTaskSource, ITriggerHandler<T>, IDisposable, IAsyncFixedUpdateHandler, IAsyncLateUpdateHandler, IAsyncOnAnimatorIKHandler, IAsyncOnAnimatorMoveHandler, IAsyncOnApplicationFocusHandler, IAsyncOnApplicationPauseHandler, IAsyncOnApplicationQuitHandler, IAsyncOnAudioFilterReadHandler, IAsyncOnBecameInvisibleHandler, IAsyncOnBecameVisibleHandler, IAsyncOnBeforeTransformParentChangedHandler, IAsyncOnCanvasGroupChangedHandler, IAsyncOnCollisionEnterHandler, IAsyncOnCollisionEnter2DHandler, IAsyncOnCollisionExitHandler, IAsyncOnCollisionExit2DHandler, IAsyncOnCollisionStayHandler, IAsyncOnCollisionStay2DHandler, IAsyncOnControllerColliderHitHandler, IAsyncOnDisableHandler, IAsyncOnDrawGizmosHandler, IAsyncOnDrawGizmosSelectedHandler, IAsyncOnEnableHandler, IAsyncOnGUIHandler, IAsyncOnJointBreakHandler, IAsyncOnJointBreak2DHandler, IAsyncOnMouseDownHandler, IAsyncOnMouseDragHandler, IAsyncOnMouseEnterHandler, IAsyncOnMouseExitHandler, IAsyncOnMouseOverHandler, IAsyncOnMouseUpHandler, IAsyncOnMouseUpAsButtonHandler, IAsyncOnParticleCollisionHandler, IAsyncOnParticleSystemStoppedHandler, IAsyncOnParticleTriggerHandler, IAsyncOnParticleUpdateJobScheduledHandler, IAsyncOnPostRenderHandler, IAsyncOnPreCullHandler, IAsyncOnPreRenderHandler, IAsyncOnRectTransformDimensionsChangeHandler, IAsyncOnRectTransformRemovedHandler, IAsyncOnRenderImageHandler, IAsyncOnRenderObjectHandler, IAsyncOnServerInitializedHandler, IAsyncOnTransformChildrenChangedHandler, IAsyncOnTransformParentChangedHandler, IAsyncOnTriggerEnterHandler, IAsyncOnTriggerEnter2DHandler, IAsyncOnTriggerExitHandler, IAsyncOnTriggerExit2DHandler, IAsyncOnTriggerStayHandler, IAsyncOnTriggerStay2DHandler, IAsyncOnValidateHandler, IAsyncOnWillRenderObjectHandler, IAsyncResetHandler, IAsyncUpdateHandler, IAsyncOnBeginDragHandler, IAsyncOnCancelHandler, IAsyncOnDeselectHandler, IAsyncOnDragHandler, IAsyncOnDropHandler, IAsyncOnEndDragHandler, IAsyncOnInitializePotentialDragHandler, IAsyncOnMoveHandler, IAsyncOnPointerClickHandler, IAsyncOnPointerDownHandler, IAsyncOnPointerEnterHandler, IAsyncOnPointerExitHandler, IAsyncOnPointerUpHandler, IAsyncOnScrollHandler, IAsyncOnSelectHandler, IAsyncOnSubmitHandler, IAsyncOnUpdateSelectedHandler
{
	[Token(Token = "0x4000597")]
	private static Action<Object> cancellationCallback; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000598")]
	private readonly AsyncTriggerBase<T> trigger; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000599")]
	private CancellationToken cancellationToken; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059A")]
	private CancellationTokenRegistration registration; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059B")]
	private bool isDisposed; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059C")]
	private bool callOnce; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059D")]
	private UniTaskCompletionSourceCore<T> core; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059E")]
	private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400059F")]
	private ITriggerHandler<T> <Cysharp.Threading.Tasks.ITriggerHandler<T>.Next>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x1700006B")]
	internal CancellationToken CancellationToken
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000967")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700006D")]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Next
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600096A")]
		private get { } //Length: 5
		[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600096B")]
		private set { } //Length: 13
	}

	[Token(Token = "0x1700006C")]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.Prev
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000968")]
		private get { } //Length: 5
		[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000969")]
		private set { } //Length: 13
	}

	[Address(RVA = "0x1235580", Offset = "0x1234980", Length = "0xED")]
	[Token(Token = "0x60009C3")]
	private static AsyncTriggerHandler`1() { }

	[Address(RVA = "0x1236030", Offset = "0x1235430", Length = "0x1CB")]
	[Token(Token = "0x600096D")]
	internal AsyncTriggerHandler`1(AsyncTriggerBase<T> trigger, CancellationToken cancellationToken, bool callOnce) { }

	[Address(RVA = "0x1235850", Offset = "0x1234C50", Length = "0xCF")]
	[Token(Token = "0x600096C")]
	internal AsyncTriggerHandler`1(AsyncTriggerBase<T> trigger, bool callOnce) { }

	[Address(RVA = "0x121EB40", Offset = "0x121DF40", Length = "0x105")]
	[Token(Token = "0x600096E")]
	private static void CancellationCallback(object state) { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600096A")]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Next() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000968")]
	private override ITriggerHandler<T> Cysharp.Threading.Tasks.ITriggerHandler<T>.get_Prev() { }

	[Address(RVA = "0x121ED80", Offset = "0x121E180", Length = "0x18")]
	[Token(Token = "0x6000972")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCanceled(CancellationToken cancellationToken) { }

	[Address(RVA = "0x121EFE0", Offset = "0x121E3E0", Length = "0x6D")]
	[Token(Token = "0x6000973")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnCompleted() { }

	[Address(RVA = "0x121F100", Offset = "0x121E500", Length = "0x18")]
	[Token(Token = "0x6000974")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnError(Exception ex) { }

	[Address(RVA = "0x121F180", Offset = "0x121E580", Length = "0x2E")]
	[Token(Token = "0x6000971")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.OnNext(T value) { }

	[Address(RVA = "0x121B3B0", Offset = "0x121A7B0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x600096B")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Next(ITriggerHandler<T> value) { }

	[Address(RVA = "0xE13120", Offset = "0xE12520", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6000969")]
	private override void Cysharp.Threading.Tasks.ITriggerHandler<T>.set_Prev(ITriggerHandler<T> value) { }

	[Address(RVA = "0x121F6A0", Offset = "0x121EAA0", Length = "0xC0")]
	[Token(Token = "0x6000975")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.GetResult(short token) { }

	[Address(RVA = "0x121FC70", Offset = "0x121F070", Length = "0x13D")]
	[Token(Token = "0x6000976")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.GetStatus(short token) { }

	[Address(RVA = "0x12200C0", Offset = "0x121F4C0", Length = "0x1C7")]
	[Token(Token = "0x6000978")]
	private override void Cysharp.Threading.Tasks.IUniTaskSource.OnCompleted(Action<Object> continuation, object state, short token) { }

	[Address(RVA = "0x1220CF0", Offset = "0x12200F0", Length = "0x91")]
	[Token(Token = "0x6000977")]
	private override UniTaskStatus Cysharp.Threading.Tasks.IUniTaskSource.UnsafeGetStatus() { }

	[Address(RVA = "0x121F540", Offset = "0x121E940", Length = "0x94")]
	[Token(Token = "0x6000970")]
	private override T Cysharp.Threading.Tasks.IUniTaskSource<T>.GetResult(short token) { }

	[Address(RVA = "0x1220FA0", Offset = "0x12203A0", Length = "0xA7")]
	[Token(Token = "0x6000979")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncFixedUpdateHandler.FixedUpdateAsync() { }

	[Address(RVA = "0x12211B0", Offset = "0x12205B0", Length = "0xA7")]
	[Token(Token = "0x600097A")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncLateUpdateHandler.LateUpdateAsync() { }

	[Address(RVA = "0x12218D0", Offset = "0x1220CD0", Length = "0xB8")]
	[Token(Token = "0x600097B")]
	private override UniTask<Int32> Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorIKHandler.OnAnimatorIKAsync() { }

	[Address(RVA = "0x1221D10", Offset = "0x1221110", Length = "0xA7")]
	[Token(Token = "0x600097C")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnAnimatorMoveHandler.OnAnimatorMoveAsync() { }

	[Address(RVA = "0x1221F30", Offset = "0x1221330", Length = "0xB8")]
	[Token(Token = "0x600097D")]
	private override UniTask<Boolean> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationFocusHandler.OnApplicationFocusAsync() { }

	[Address(RVA = "0x1222530", Offset = "0x1221930", Length = "0xB8")]
	[Token(Token = "0x600097E")]
	private override UniTask<Boolean> Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationPauseHandler.OnApplicationPauseAsync() { }

	[Address(RVA = "0x1222A30", Offset = "0x1221E30", Length = "0xA7")]
	[Token(Token = "0x600097F")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnApplicationQuitHandler.OnApplicationQuitAsync() { }

	[Address(RVA = "0x1222B90", Offset = "0x1221F90", Length = "0xBE")]
	[Token(Token = "0x6000980")]
	private override UniTask<ValueTuple`2<Single[], Int32>> Cysharp.Threading.Tasks.Triggers.IAsyncOnAudioFilterReadHandler.OnAudioFilterReadAsync() { }

	[Address(RVA = "0x12232D0", Offset = "0x12226D0", Length = "0xA7")]
	[Token(Token = "0x6000981")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameInvisibleHandler.OnBecameInvisibleAsync() { }

	[Address(RVA = "0x1223430", Offset = "0x1222830", Length = "0xA7")]
	[Token(Token = "0x6000982")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBecameVisibleHandler.OnBecameVisibleAsync() { }

	[Address(RVA = "0x1223850", Offset = "0x1222C50", Length = "0xA7")]
	[Token(Token = "0x6000983")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnBeforeTransformParentChangedHandler.OnBeforeTransformParentChangedAsync() { }

	[Address(RVA = "0x1223C70", Offset = "0x1223070", Length = "0xBF")]
	[Token(Token = "0x60009B2")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnBeginDragHandler.OnBeginDragAsync() { }

	[Address(RVA = "0x12244B0", Offset = "0x12238B0", Length = "0xBF")]
	[Token(Token = "0x60009B3")]
	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnCancelHandler.OnCancelAsync() { }

	[Address(RVA = "0x12246D0", Offset = "0x1223AD0", Length = "0xA7")]
	[Token(Token = "0x6000984")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnCanvasGroupChangedHandler.OnCanvasGroupChangedAsync() { }

	[Address(RVA = "0x1224B10", Offset = "0x1223F10", Length = "0xBF")]
	[Token(Token = "0x6000986")]
	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnter2DHandler.OnCollisionEnter2DAsync() { }

	[Address(RVA = "0x12251D0", Offset = "0x12245D0", Length = "0xBF")]
	[Token(Token = "0x6000985")]
	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionEnterHandler.OnCollisionEnterAsync() { }

	[Address(RVA = "0x1225350", Offset = "0x1224750", Length = "0xBF")]
	[Token(Token = "0x6000988")]
	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExit2DHandler.OnCollisionExit2DAsync() { }

	[Address(RVA = "0x1225710", Offset = "0x1224B10", Length = "0xBF")]
	[Token(Token = "0x6000987")]
	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionExitHandler.OnCollisionExitAsync() { }

	[Address(RVA = "0x1225E90", Offset = "0x1225290", Length = "0xBF")]
	[Token(Token = "0x600098A")]
	private override UniTask<Collision2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStay2DHandler.OnCollisionStay2DAsync() { }

	[Address(RVA = "0x12260D0", Offset = "0x12254D0", Length = "0xBF")]
	[Token(Token = "0x6000989")]
	private override UniTask<Collision> Cysharp.Threading.Tasks.Triggers.IAsyncOnCollisionStayHandler.OnCollisionStayAsync() { }

	[Address(RVA = "0x1226790", Offset = "0x1225B90", Length = "0xBF")]
	[Token(Token = "0x600098B")]
	private override UniTask<ControllerColliderHit> Cysharp.Threading.Tasks.Triggers.IAsyncOnControllerColliderHitHandler.OnControllerColliderHitAsync() { }

	[Address(RVA = "0x1226C10", Offset = "0x1226010", Length = "0xBF")]
	[Token(Token = "0x60009B4")]
	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDeselectHandler.OnDeselectAsync() { }

	[Address(RVA = "0x1226D90", Offset = "0x1226190", Length = "0xA7")]
	[Token(Token = "0x600098C")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDisableHandler.OnDisableAsync() { }

	[Address(RVA = "0x1227570", Offset = "0x1226970", Length = "0xBF")]
	[Token(Token = "0x60009B5")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDragHandler.OnDragAsync() { }

	[Address(RVA = "0x12279A0", Offset = "0x1226DA0", Length = "0xA7")]
	[Token(Token = "0x600098D")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosHandler.OnDrawGizmosAsync() { }

	[Address(RVA = "0x1227DC0", Offset = "0x12271C0", Length = "0xA7")]
	[Token(Token = "0x600098E")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnDrawGizmosSelectedHandler.OnDrawGizmosSelectedAsync() { }

	[Address(RVA = "0x1227F30", Offset = "0x1227330", Length = "0xBF")]
	[Token(Token = "0x60009B6")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnDropHandler.OnDropAsync() { }

	[Address(RVA = "0x1228660", Offset = "0x1227A60", Length = "0xA7")]
	[Token(Token = "0x600098F")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnEnableHandler.OnEnableAsync() { }

	[Address(RVA = "0x12287D0", Offset = "0x1227BD0", Length = "0xBF")]
	[Token(Token = "0x60009B7")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnEndDragHandler.OnEndDragAsync() { }

	[Address(RVA = "0x1234710", Offset = "0x1233B10", Length = "0x5E")]
	[Token(Token = "0x6000966")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOneShotTrigger.OneShotAsync() { }

	[Address(RVA = "0x1228C40", Offset = "0x1228040", Length = "0xA7")]
	[Token(Token = "0x6000990")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnGUIHandler.OnGUIAsync() { }

	[Address(RVA = "0x1229070", Offset = "0x1228470", Length = "0xBF")]
	[Token(Token = "0x60009B8")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnInitializePotentialDragHandler.OnInitializePotentialDragAsync() { }

	[Address(RVA = "0x12297F0", Offset = "0x1228BF0", Length = "0xBF")]
	[Token(Token = "0x6000992")]
	private override UniTask<Joint2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreak2DHandler.OnJointBreak2DAsync() { }

	[Address(RVA = "0x1229A30", Offset = "0x1228E30", Length = "0xB8")]
	[Token(Token = "0x6000991")]
	private override UniTask<Single> Cysharp.Threading.Tasks.Triggers.IAsyncOnJointBreakHandler.OnJointBreakAsync() { }

	[Address(RVA = "0x1229E90", Offset = "0x1229290", Length = "0xA7")]
	[Token(Token = "0x6000993")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDownHandler.OnMouseDownAsync() { }

	[Address(RVA = "0x122A410", Offset = "0x1229810", Length = "0xA7")]
	[Token(Token = "0x6000994")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseDragHandler.OnMouseDragAsync() { }

	[Address(RVA = "0x122A620", Offset = "0x1229A20", Length = "0xA7")]
	[Token(Token = "0x6000995")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseEnterHandler.OnMouseEnterAsync() { }

	[Address(RVA = "0x122AC50", Offset = "0x122A050", Length = "0xA7")]
	[Token(Token = "0x6000996")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseExitHandler.OnMouseExitAsync() { }

	[Address(RVA = "0x122AF10", Offset = "0x122A310", Length = "0xA7")]
	[Token(Token = "0x6000997")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseOverHandler.OnMouseOverAsync() { }

	[Address(RVA = "0x122B540", Offset = "0x122A940", Length = "0xA7")]
	[Token(Token = "0x6000999")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpAsButtonHandler.OnMouseUpAsButtonAsync() { }

	[Address(RVA = "0x122B750", Offset = "0x122AB50", Length = "0xA7")]
	[Token(Token = "0x6000998")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnMouseUpHandler.OnMouseUpAsync() { }

	[Address(RVA = "0x122BD10", Offset = "0x122B110", Length = "0xBF")]
	[Token(Token = "0x60009B9")]
	private override UniTask<AxisEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnMoveHandler.OnMoveAsync() { }

	[Address(RVA = "0x122BE90", Offset = "0x122B290", Length = "0xBF")]
	[Token(Token = "0x600099A")]
	private override UniTask<GameObject> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleCollisionHandler.OnParticleCollisionAsync() { }

	[Address(RVA = "0x122C3C0", Offset = "0x122B7C0", Length = "0xA7")]
	[Token(Token = "0x600099B")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleSystemStoppedHandler.OnParticleSystemStoppedAsync() { }

	[Address(RVA = "0x122C7E0", Offset = "0x122BBE0", Length = "0xA7")]
	[Token(Token = "0x600099C")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleTriggerHandler.OnParticleTriggerAsync() { }

	[Address(RVA = "0x122CDF0", Offset = "0x122C1F0", Length = "0xD1")]
	[Token(Token = "0x600099D")]
	private override UniTask<ParticleSystemJobData> Cysharp.Threading.Tasks.Triggers.IAsyncOnParticleUpdateJobScheduledHandler.OnParticleUpdateJobScheduledAsync() { }

	[Address(RVA = "0x122D2D0", Offset = "0x122C6D0", Length = "0xBF")]
	[Token(Token = "0x60009BA")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerClickHandler.OnPointerClickAsync() { }

	[Address(RVA = "0x122D810", Offset = "0x122CC10", Length = "0xBF")]
	[Token(Token = "0x60009BB")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerDownHandler.OnPointerDownAsync() { }

	[Address(RVA = "0x122DB10", Offset = "0x122CF10", Length = "0xBF")]
	[Token(Token = "0x60009BC")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerEnterHandler.OnPointerEnterAsync() { }

	[Address(RVA = "0x122DF90", Offset = "0x122D390", Length = "0xBF")]
	[Token(Token = "0x60009BD")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerExitHandler.OnPointerExitAsync() { }

	[Address(RVA = "0x122E590", Offset = "0x122D990", Length = "0xBF")]
	[Token(Token = "0x60009BE")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnPointerUpHandler.OnPointerUpAsync() { }

	[Address(RVA = "0x122E7C0", Offset = "0x122DBC0", Length = "0xA7")]
	[Token(Token = "0x600099E")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPostRenderHandler.OnPostRenderAsync() { }

	[Address(RVA = "0x122ED40", Offset = "0x122E140", Length = "0xA7")]
	[Token(Token = "0x600099F")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreCullHandler.OnPreCullAsync() { }

	[Address(RVA = "0x122EF50", Offset = "0x122E350", Length = "0xA7")]
	[Token(Token = "0x60009A0")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnPreRenderHandler.OnPreRenderAsync() { }

	[Address(RVA = "0x122F630", Offset = "0x122EA30", Length = "0xA7")]
	[Token(Token = "0x60009A1")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformDimensionsChangeHandler.OnRectTransformDimensionsChangeAsync() { }

	[Address(RVA = "0x122F9A0", Offset = "0x122EDA0", Length = "0xA7")]
	[Token(Token = "0x60009A2")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRectTransformRemovedHandler.OnRectTransformRemovedAsync() { }

	[Address(RVA = "0x122FDF0", Offset = "0x122F1F0", Length = "0xBE")]
	[Token(Token = "0x60009A3")]
	private override UniTask<ValueTuple`2<RenderTexture, RenderTexture>> Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderImageHandler.OnRenderImageAsync() { }

	[Address(RVA = "0x1230240", Offset = "0x122F640", Length = "0xA7")]
	[Token(Token = "0x60009A4")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnRenderObjectHandler.OnRenderObjectAsync() { }

	[Address(RVA = "0x1230690", Offset = "0x122FA90", Length = "0xBF")]
	[Token(Token = "0x60009BF")]
	private override UniTask<PointerEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnScrollHandler.OnScrollAsync() { }

	[Address(RVA = "0x12308D0", Offset = "0x122FCD0", Length = "0xBF")]
	[Token(Token = "0x60009C0")]
	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSelectHandler.OnSelectAsync() { }

	[Address(RVA = "0x12310C0", Offset = "0x12304C0", Length = "0xA7")]
	[Token(Token = "0x60009A5")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnServerInitializedHandler.OnServerInitializedAsync() { }

	[Address(RVA = "0x12312F0", Offset = "0x12306F0", Length = "0xBF")]
	[Token(Token = "0x60009C1")]
	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnSubmitHandler.OnSubmitAsync() { }

	[Address(RVA = "0x12315F0", Offset = "0x12309F0", Length = "0xA7")]
	[Token(Token = "0x60009A6")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformChildrenChangedHandler.OnTransformChildrenChangedAsync() { }

	[Address(RVA = "0x1231D80", Offset = "0x1231180", Length = "0xA7")]
	[Token(Token = "0x60009A7")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnTransformParentChangedHandler.OnTransformParentChangedAsync() { }

	[Address(RVA = "0x1231EF0", Offset = "0x12312F0", Length = "0xBF")]
	[Token(Token = "0x60009A9")]
	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnter2DHandler.OnTriggerEnter2DAsync() { }

	[Address(RVA = "0x1232370", Offset = "0x1231770", Length = "0xBF")]
	[Token(Token = "0x60009A8")]
	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerEnterHandler.OnTriggerEnterAsync() { }

	[Address(RVA = "0x12328B0", Offset = "0x1231CB0", Length = "0xBF")]
	[Token(Token = "0x60009AB")]
	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExit2DHandler.OnTriggerExit2DAsync() { }

	[Address(RVA = "0x1232D30", Offset = "0x1232130", Length = "0xBF")]
	[Token(Token = "0x60009AA")]
	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerExitHandler.OnTriggerExitAsync() { }

	[Address(RVA = "0x12331B0", Offset = "0x12325B0", Length = "0xBF")]
	[Token(Token = "0x60009AD")]
	private override UniTask<Collider2D> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStay2DHandler.OnTriggerStay2DAsync() { }

	[Address(RVA = "0x12336F0", Offset = "0x1232AF0", Length = "0xBF")]
	[Token(Token = "0x60009AC")]
	private override UniTask<Collider> Cysharp.Threading.Tasks.Triggers.IAsyncOnTriggerStayHandler.OnTriggerStayAsync() { }

	[Address(RVA = "0x1233AB0", Offset = "0x1232EB0", Length = "0xBF")]
	[Token(Token = "0x60009C2")]
	private override UniTask<BaseEventData> Cysharp.Threading.Tasks.Triggers.IAsyncOnUpdateSelectedHandler.OnUpdateSelectedAsync() { }

	[Address(RVA = "0x1234070", Offset = "0x1233470", Length = "0xA7")]
	[Token(Token = "0x60009AE")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnValidateHandler.OnValidateAsync() { }

	[Address(RVA = "0x12343E0", Offset = "0x12337E0", Length = "0xA7")]
	[Token(Token = "0x60009AF")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncOnWillRenderObjectHandler.OnWillRenderObjectAsync() { }

	[Address(RVA = "0x1234990", Offset = "0x1233D90", Length = "0xA7")]
	[Token(Token = "0x60009B0")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncResetHandler.ResetAsync() { }

	[Address(RVA = "0x1234C50", Offset = "0x1234050", Length = "0xA7")]
	[Token(Token = "0x60009B1")]
	private override UniTask Cysharp.Threading.Tasks.Triggers.IAsyncUpdateHandler.UpdateAsync() { }

	[Address(RVA = "0x12350D0", Offset = "0x12344D0", Length = "0x55")]
	[Token(Token = "0x600096F")]
	public override void Dispose() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x6000967")]
	internal CancellationToken get_CancellationToken() { }

}

