namespace UnityEngine.UIElements;

[Token(Token = "0x2000457")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class StylePropertyAnimationSystem : IStylePropertyAnimationSystem
{
	[Token(Token = "0x2000459")]
	private struct AnimationDataSet
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6E")]
		public VisualElement[] elements; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E6F")]
		public StylePropertyId[] properties; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E70")]
		public TTimingData[] timing; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E71")]
		public TStyleData[] style; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E72")]
		public int count; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E73")]
		private Dictionary<ElementPropertyPair, Int32> indices; //Field offset: 0x0

		[Token(Token = "0x170008F7")]
		private int capacity
		{
			[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
			[Token(Token = "0x60020D0")]
			private get { } //Length: 25
			[Address(RVA = "0x1C4EE60", Offset = "0x1C4E260", Length = "0xC7")]
			[Token(Token = "0x60020D1")]
			private set { } //Length: 199
		}

		[Address(RVA = "0x1C4E380", Offset = "0x1C4D780", Length = "0x20E")]
		[Token(Token = "0x60020D5")]
		public void Add(VisualElement owner, StylePropertyId prop, TTimingData timingData, TStyleData styleData) { }

		[Address(RVA = "0x1C4E590", Offset = "0x1C4D990", Length = "0x73")]
		[Token(Token = "0x60020D3")]
		public static AnimationDataSet<TTimingData, TStyleData> Create() { }

		[Address(RVA = "0xA8E460", Offset = "0xA8D860", Length = "0x19")]
		[Token(Token = "0x60020D0")]
		private int get_capacity() { }

		[Address(RVA = "0x1C4E610", Offset = "0x1C4DA10", Length = "0xC9")]
		[Token(Token = "0x60020DA")]
		public void GetActivePropertiesForElement(VisualElement ve, List<StylePropertyId> outProperties) { }

		[Address(RVA = "0x1C4E6E0", Offset = "0x1C4DAE0", Length = "0x9C")]
		[Token(Token = "0x60020D4")]
		public bool IndexOf(VisualElement ve, StylePropertyId prop, out int index) { }

		[Address(RVA = "0x1C4E780", Offset = "0x1C4DB80", Length = "0x1A6")]
		[Token(Token = "0x60020D2")]
		private void LocalInit() { }

		[Address(RVA = "0x1C4EAE0", Offset = "0x1C4DEE0", Length = "0x306")]
		[Token(Token = "0x60020D6")]
		public void Remove(int cancelledIndex) { }

		[Address(RVA = "0x1C4EA30", Offset = "0x1C4DE30", Length = "0xA2")]
		[Token(Token = "0x60020D8")]
		public void RemoveAll(VisualElement ve) { }

		[Address(RVA = "0x1C4E930", Offset = "0x1C4DD30", Length = "0xF5")]
		[Token(Token = "0x60020D9")]
		public void RemoveAll() { }

		[Address(RVA = "0x1C4EDF0", Offset = "0x1C4E1F0", Length = "0x6B")]
		[Token(Token = "0x60020D7")]
		public void Replace(int index, TTimingData timingData, TStyleData styleData) { }

		[Address(RVA = "0x1C4EE60", Offset = "0x1C4E260", Length = "0xC7")]
		[Token(Token = "0x60020D1")]
		private void set_capacity(int value) { }

	}

	[Token(Token = "0x200045A")]
	private struct ElementPropertyPair
	{
		[Token(Token = "0x200045B")]
		private class EqualityComparer : IEqualityComparer<ElementPropertyPair>
		{

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x60020DF")]
			public EqualityComparer() { }

			[Address(RVA = "0x3286E70", Offset = "0x3286270", Length = "0x19")]
			[Token(Token = "0x60020DD")]
			public override bool Equals(ElementPropertyPair x, ElementPropertyPair y) { }

			[Address(RVA = "0x3286E90", Offset = "0x3286290", Length = "0x38")]
			[Token(Token = "0x60020DE")]
			public override int GetHashCode(ElementPropertyPair obj) { }

		}

		[Token(Token = "0x4000E74")]
		public static readonly IEqualityComparer<ElementPropertyPair> Comparer; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E75")]
		public readonly VisualElement element; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000E76")]
		public readonly StylePropertyId property; //Field offset: 0x8

		[Address(RVA = "0x3286DF0", Offset = "0x32861F0", Length = "0x73")]
		[Token(Token = "0x60020DC")]
		private static ElementPropertyPair() { }

		[Address(RVA = "0xAEE5F0", Offset = "0xAED9F0", Length = "0x26")]
		[Token(Token = "0x60020DB")]
		public ElementPropertyPair(VisualElement element, StylePropertyId property) { }

	}

	[Flags]
	[Token(Token = "0x2000458")]
	private enum TransitionState : int
	{
		None = 0,
		Running = 1,
		Started = 2,
		Ended = 4,
		Canceled = 8,
	}

	[Token(Token = "0x200045C")]
	private abstract class Values
	{

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60020E9")]
		protected Values() { }

		[Token(Token = "0x60020E0")]
		public abstract void CancelAllAnimations() { }

		[Token(Token = "0x60020E1")]
		public abstract void CancelAllAnimations(VisualElement ve) { }

		[Token(Token = "0x60020E2")]
		public abstract void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		[Token(Token = "0x60020E4")]
		public abstract void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		[Token(Token = "0x60020E5")]
		public abstract void Update(double currentTime) { }

		[Token(Token = "0x60020E3")]
		public abstract void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		[Token(Token = "0x60020E7")]
		protected abstract void UpdateComputedStyle() { }

		[Token(Token = "0x60020E8")]
		protected abstract void UpdateComputedStyle(int i) { }

		[Token(Token = "0x60020E6")]
		protected abstract void UpdateValues() { }

	}

	[Token(Token = "0x200045D")]
	private abstract class Values : Values
	{
		[Token(Token = "0x2000462")]
		internal struct EmptyData
		{
			[Token(Token = "0x4000E8D")]
			public static EmptyData<T> Default; //Field offset: 0x0

			[Address(RVA = "0x1951170", Offset = "0x1950570", Length = "0x45")]
			[Token(Token = "0x600210E")]
			private static EmptyData() { }

		}

		[Token(Token = "0x2000461")]
		internal struct StyleData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E89")]
			public T startValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E8A")]
			public T endValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E8B")]
			public T reversingAdjustedStartValue; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E8C")]
			public T currentValue; //Field offset: 0x0

		}

		[Token(Token = "0x2000460")]
		internal struct TimingData
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E82")]
			public double startTime; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E83")]
			public float duration; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E84")]
			public Func<Single, Single> easingCurve; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E85")]
			public float easedProgress; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E86")]
			public float reversingShorteningFactor; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E87")]
			public bool isStarted; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E88")]
			public float delay; //Field offset: 0x0

		}

		[Token(Token = "0x200045E")]
		private class TransitionEventsFrameState
		{
			[CompilerGenerated]
			[Token(Token = "0x200045F")]
			private sealed class <>c
			{
				[Token(Token = "0x4000E81")]
				public static readonly <>c<T> <>9; //Field offset: 0x0

				[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
				[Token(Token = "0x600210B")]
				private static <>c() { }

				[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
				[Token(Token = "0x600210C")]
				public <>c() { }

				[Address(RVA = "0xA35B70", Offset = "0xA34F70", Length = "0x5A")]
				[Token(Token = "0x600210D")]
				internal Queue<EventBase> <.cctor>b__11_0() { }

			}

			[Token(Token = "0x4000E7C")]
			private static readonly ObjectPool<Queue`1<EventBase>> k_EventQueuePool; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E7D")]
			public readonly Dictionary<ElementPropertyPair, TransitionState> elementPropertyStateDelta; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E7E")]
			public readonly Dictionary<ElementPropertyPair, Queue`1<EventBase>> elementPropertyQueuedEvents; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E7F")]
			public IPanel panel; //Field offset: 0x0
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000E80")]
			private int m_ChangesCount; //Field offset: 0x0

			[Address(RVA = "0x1097870", Offset = "0x1096C70", Length = "0x1D4")]
			[Token(Token = "0x600210A")]
			private static TransitionEventsFrameState() { }

			[Address(RVA = "0x1099BB0", Offset = "0x1098FB0", Length = "0x113")]
			[Token(Token = "0x6002109")]
			public TransitionEventsFrameState() { }

			[Address(RVA = "0x1095DD0", Offset = "0x10951D0", Length = "0x380")]
			[Token(Token = "0x6002108")]
			public void Clear() { }

			[Address(RVA = "0x10973C0", Offset = "0x10967C0", Length = "0xBD")]
			[Token(Token = "0x6002104")]
			public static Queue<EventBase> GetPooledQueue() { }

			[Address(RVA = "0x1097480", Offset = "0x1096880", Length = "0x4")]
			[Token(Token = "0x6002105")]
			public void RegisterChange() { }

			[Address(RVA = "0x1097490", Offset = "0x1096890", Length = "0xA")]
			[Token(Token = "0x6002107")]
			public bool StateChanged() { }

			[Address(RVA = "0x10974A0", Offset = "0x10968A0", Length = "0x4")]
			[Token(Token = "0x6002106")]
			public void UnregisterChange() { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E77")]
		private double m_CurrentTime; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E78")]
		private TransitionEventsFrameState<T> m_CurrentFrameEventsState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E79")]
		private TransitionEventsFrameState<T> m_NextFrameEventsState; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E7A")]
		public AnimationDataSet<TimingData<T>, StyleData<T>> running; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E7B")]
		public AnimationDataSet<EmptyData<T>, T> completed; //Field offset: 0x0

		[Token(Token = "0x170008F8")]
		public bool isEmpty
		{
			[Address(RVA = "0x13BC040", Offset = "0x13BB440", Length = "0xA")]
			[Token(Token = "0x60020EA")]
			 get { } //Length: 10
		}

		[Token(Token = "0x170008F9")]
		public abstract Func<T, T, Boolean> SameFunc
		{
			[Token(Token = "0x60020EB")]
			 get { } //Length: 0
		}

		[Address(RVA = "0x13BBD60", Offset = "0x13BB160", Length = "0x161")]
		[Token(Token = "0x60020EE")]
		protected Values`1() { }

		[Address(RVA = "0x13AE670", Offset = "0x13ADA70", Length = "0x31E")]
		[Token(Token = "0x60020F8")]
		public virtual void CancelAllAnimations(VisualElement ve) { }

		[Address(RVA = "0x13AE990", Offset = "0x13ADD90", Length = "0x505")]
		[Token(Token = "0x60020F7")]
		public virtual void CancelAllAnimations() { }

		[Address(RVA = "0x13AFED0", Offset = "0x13AF2D0", Length = "0x1D4")]
		[Token(Token = "0x60020F9")]
		public virtual void CancelAnimation(VisualElement ve, StylePropertyId id) { }

		[Address(RVA = "0x13B0D20", Offset = "0x13B0120", Length = "0x10F")]
		[Token(Token = "0x60020F1")]
		private void ClearEventQueue(ElementPropertyPair epp) { }

		[Address(RVA = "0x13B0E30", Offset = "0x13B0230", Length = "0x10")]
		[Token(Token = "0x60020FE")]
		private float ComputeReversingDelay(float delay, float newReversingShorteningFactor) { }

		[Address(RVA = "0x13B0E40", Offset = "0x13B0240", Length = "0xA")]
		[Token(Token = "0x60020FD")]
		private float ComputeReversingDuration(float newTransitionDuration, float newReversingShorteningFactor) { }

		[Address(RVA = "0x13B0E50", Offset = "0x13B0250", Length = "0x6C")]
		[Token(Token = "0x60020FC")]
		private float ComputeReversingShorteningFactor(int oldIndex) { }

		[Address(RVA = "0x13B0EC0", Offset = "0x13B02C0", Length = "0x5")]
		[Token(Token = "0x60020EC")]
		protected override bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref T a, ref T b) { }

		[Address(RVA = "0x13B0F30", Offset = "0x13B0330", Length = "0x14")]
		[Token(Token = "0x60020ED")]
		protected override T Copy(T value) { }

		[Address(RVA = "0x13B0FF0", Offset = "0x13B03F0", Length = "0x83")]
		[Token(Token = "0x6002100")]
		private void ForceComputedStyleEndValue(int runningIndex) { }

		[Address(RVA = "0x13BC040", Offset = "0x13BB440", Length = "0xA")]
		[Token(Token = "0x60020EA")]
		public bool get_isEmpty() { }

		[Token(Token = "0x60020EB")]
		public abstract Func<T, T, Boolean> get_SameFunc() { }

		[Address(RVA = "0x13B1140", Offset = "0x13B0540", Length = "0x70")]
		[Token(Token = "0x60020FB")]
		public virtual void GetAllAnimations(VisualElement ve, List<StylePropertyId> outPropertyIds) { }

		[Address(RVA = "0x13B1660", Offset = "0x13B0A60", Length = "0x2E6")]
		[Token(Token = "0x6002102")]
		private void ProcessEventQueue() { }

		[Address(RVA = "0x13B23E0", Offset = "0x13B17E0", Length = "0x1B8")]
		[Token(Token = "0x60020F0")]
		private void QueueEvent(EventBase evt, ElementPropertyPair epp) { }

		[Address(RVA = "0x13B36E0", Offset = "0x13B2AE0", Length = "0x2F7")]
		[Token(Token = "0x60020F5")]
		private void QueueTransitionCancelEvent(VisualElement ve, int runningIndex, double panelElapsed) { }

		[Address(RVA = "0x13B40A0", Offset = "0x13B34A0", Length = "0x23B")]
		[Token(Token = "0x60020F4")]
		private void QueueTransitionEndEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x13B4A00", Offset = "0x13B3E00", Length = "0x266")]
		[Token(Token = "0x60020F2")]
		private void QueueTransitionRunEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x13B5B10", Offset = "0x13B4F10", Length = "0x266")]
		[Token(Token = "0x60020F3")]
		private void QueueTransitionStartEvent(VisualElement ve, int runningIndex) { }

		[Address(RVA = "0x13B6580", Offset = "0x13B5980", Length = "0x1FD")]
		[Token(Token = "0x60020F6")]
		private void SendTransitionCancelEvent(VisualElement ve, int runningIndex, double panelElapsed) { }

		[Address(RVA = "0x13B9180", Offset = "0x13B8580", Length = "0xCAC")]
		[Token(Token = "0x60020FF")]
		public bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, float duration, float delay, Func<Single, Single> easingCurve, double currentTime) { }

		[Address(RVA = "0x13B9E30", Offset = "0x13B9230", Length = "0x3C")]
		[Token(Token = "0x60020EF")]
		private void SwapFrameStates() { }

		[Address(RVA = "0x13BB7B0", Offset = "0x13BABB0", Length = "0xA6")]
		[Token(Token = "0x6002101")]
		public virtual void Update(double currentTime) { }

		[Address(RVA = "0x13B9F50", Offset = "0x13B9350", Length = "0x64")]
		[Token(Token = "0x60020FA")]
		public virtual void UpdateAnimation(VisualElement ve, StylePropertyId id) { }

		[Address(RVA = "0x13BAD20", Offset = "0x13BA120", Length = "0x450")]
		[Token(Token = "0x6002103")]
		private void UpdateProgress(double currentTime) { }

	}

	[Token(Token = "0x2000469")]
	private class ValuesBackground : ValuesDiscrete<Background>
	{

		[Address(RVA = "0x3297E80", Offset = "0x3297280", Length = "0x39")]
		[Token(Token = "0x6002136")]
		public ValuesBackground() { }

		[Address(RVA = "0x3297C90", Offset = "0x3297090", Length = "0xB5")]
		[Token(Token = "0x6002135")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3297D50", Offset = "0x3297150", Length = "0x129")]
		[Token(Token = "0x6002134")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000472")]
	private class ValuesBackgroundPosition : ValuesDiscrete<BackgroundPosition>
	{

		[Address(RVA = "0x3297470", Offset = "0x3296870", Length = "0x39")]
		[Token(Token = "0x600216C")]
		public ValuesBackgroundPosition() { }

		[Address(RVA = "0x32973B0", Offset = "0x32967B0", Length = "0xB8")]
		[Token(Token = "0x600216B")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3297290", Offset = "0x3296690", Length = "0x115")]
		[Token(Token = "0x600216A")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000473")]
	private class ValuesBackgroundRepeat : ValuesDiscrete<BackgroundRepeat>
	{

		[Address(RVA = "0x3297650", Offset = "0x3296A50", Length = "0x39")]
		[Token(Token = "0x600216F")]
		public ValuesBackgroundRepeat() { }

		[Address(RVA = "0x32974B0", Offset = "0x32968B0", Length = "0x99")]
		[Token(Token = "0x600216E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3297550", Offset = "0x3296950", Length = "0xF7")]
		[Token(Token = "0x600216D")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000474")]
	private class ValuesBackgroundSize : Values<BackgroundSize>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E99")]
		private readonly Func<BackgroundSize, BackgroundSize, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000905")]
		public virtual Func<BackgroundSize, BackgroundSize, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002170")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3297BF0", Offset = "0x3296FF0", Length = "0x93")]
		[Token(Token = "0x6002177")]
		public ValuesBackgroundSize() { }

		[Address(RVA = "0x3297690", Offset = "0x3296A90", Length = "0x2B")]
		[Token(Token = "0x6002172")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref BackgroundSize a, ref BackgroundSize b) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002170")]
		public virtual Func<BackgroundSize, BackgroundSize, Boolean> get_SameFunc() { }

		[Address(RVA = "0x32976C0", Offset = "0x3296AC0", Length = "0x39")]
		[Token(Token = "0x6002171")]
		private static bool IsSame(BackgroundSize a, BackgroundSize b) { }

		[Address(RVA = "0x3297700", Offset = "0x3296B00", Length = "0xFA")]
		[Token(Token = "0x6002175")]
		private static BackgroundSize Lerp(BackgroundSize a, BackgroundSize b, float t) { }

		[Address(RVA = "0x32978C0", Offset = "0x3296CC0", Length = "0x121")]
		[Token(Token = "0x6002173")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3297800", Offset = "0x3296C00", Length = "0xB6")]
		[Token(Token = "0x6002174")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x32979F0", Offset = "0x3296DF0", Length = "0x1F1")]
		[Token(Token = "0x6002176")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000466")]
	private class ValuesColor : Values<Color>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E91")]
		private readonly Func<Color, Color, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008FD")]
		public virtual Func<Color, Color, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002125")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x32982C0", Offset = "0x32976C0", Length = "0x93")]
		[Token(Token = "0x600212B")]
		public ValuesColor() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002125")]
		public virtual Func<Color, Color, Boolean> get_SameFunc() { }

		[Address(RVA = "0x3297EC0", Offset = "0x32972C0", Length = "0x79")]
		[Token(Token = "0x6002126")]
		private static bool IsSame(Color c, Color d) { }

		[Address(RVA = "0x3297F40", Offset = "0x3297340", Length = "0x93")]
		[Token(Token = "0x6002127")]
		private static Color Lerp(Color a, Color b, float t) { }

		[Address(RVA = "0x3298090", Offset = "0x3297490", Length = "0x10A")]
		[Token(Token = "0x6002129")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3297FE0", Offset = "0x32973E0", Length = "0xAB")]
		[Token(Token = "0x600212A")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x32981A0", Offset = "0x32975A0", Length = "0x117")]
		[Token(Token = "0x6002128")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000467")]
	private abstract class ValuesDiscrete : Values<T>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000E92")]
		private readonly Func<T, T, Boolean> <SameFunc>k__BackingField; //Field offset: 0x0

		[Token(Token = "0x170008FE")]
		public virtual Func<T, T, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600212C")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x13AD460", Offset = "0x13AC860", Length = "0x1D7")]
		[Token(Token = "0x6002130")]
		protected ValuesDiscrete`1() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600212C")]
		public virtual Func<T, T, Boolean> get_SameFunc() { }

		[Address(RVA = "0x13ABF10", Offset = "0x13AB310", Length = "0x190")]
		[Token(Token = "0x600212D")]
		private static bool IsSame(T a, T b) { }

		[Address(RVA = "0x13AC720", Offset = "0x13ABB20", Length = "0x30")]
		[Token(Token = "0x600212E")]
		private static T Lerp(T a, T b, float t) { }

		[Address(RVA = "0x13AC8B0", Offset = "0x13ABCB0", Length = "0xDC")]
		[Token(Token = "0x600212F")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000468")]
	private class ValuesEnum : ValuesDiscrete<Int32>
	{

		[Address(RVA = "0x3298500", Offset = "0x3297900", Length = "0x39")]
		[Token(Token = "0x6002133")]
		public ValuesEnum() { }

		[Address(RVA = "0x3298360", Offset = "0x3297760", Length = "0x98")]
		[Token(Token = "0x6002132")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3298400", Offset = "0x3297800", Length = "0xF7")]
		[Token(Token = "0x6002131")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000463")]
	private class ValuesFloat : Values<Single>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E8E")]
		private readonly Func<Single, Single, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008FA")]
		public virtual Func<Single, Single, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600210F")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x32987A0", Offset = "0x3297BA0", Length = "0x93")]
		[Token(Token = "0x6002115")]
		public ValuesFloat() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600210F")]
		public virtual Func<Single, Single, Boolean> get_SameFunc() { }

		[Address(RVA = "0x3298540", Offset = "0x3297940", Length = "0x8")]
		[Token(Token = "0x6002110")]
		private static bool IsSame(float a, float b) { }

		[Address(RVA = "0x3298550", Offset = "0x3297950", Length = "0x14")]
		[Token(Token = "0x6002111")]
		private static void Lerp(float a, float b, ref float result, float t) { }

		[Address(RVA = "0x3298570", Offset = "0x3297970", Length = "0xF8")]
		[Token(Token = "0x6002113")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3298670", Offset = "0x3297A70", Length = "0x99")]
		[Token(Token = "0x6002114")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3298710", Offset = "0x3297B10", Length = "0x88")]
		[Token(Token = "0x6002112")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200046B")]
	private class ValuesFont : ValuesDiscrete<Font>
	{

		[Address(RVA = "0x3298BE0", Offset = "0x3297FE0", Length = "0x39")]
		[Token(Token = "0x600213C")]
		public ValuesFont() { }

		[Address(RVA = "0x3298A40", Offset = "0x3297E40", Length = "0x99")]
		[Token(Token = "0x600213B")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3298AE0", Offset = "0x3297EE0", Length = "0xF7")]
		[Token(Token = "0x600213A")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x200046A")]
	private class ValuesFontDefinition : ValuesDiscrete<FontDefinition>
	{

		[Address(RVA = "0x3298A00", Offset = "0x3297E00", Length = "0x39")]
		[Token(Token = "0x6002139")]
		public ValuesFontDefinition() { }

		[Address(RVA = "0x3298840", Offset = "0x3297C40", Length = "0xAB")]
		[Token(Token = "0x6002138")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x32988F0", Offset = "0x3297CF0", Length = "0x10A")]
		[Token(Token = "0x6002137")]
		protected virtual void UpdateComputedStyle() { }

	}

	[Token(Token = "0x2000464")]
	private class ValuesInt : Values<Int32>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E8F")]
		private readonly Func<Int32, Int32, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008FB")]
		public virtual Func<Int32, Int32, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002116")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3298D10", Offset = "0x3298110", Length = "0x93")]
		[Token(Token = "0x600211C")]
		public ValuesInt() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002116")]
		public virtual Func<Int32, Int32, Boolean> get_SameFunc() { }

		[Address(RVA = "0x604250", Offset = "0x603650", Length = "0x6")]
		[Token(Token = "0x6002117")]
		private static bool IsSame(int a, int b) { }

		[Address(RVA = "0x3298C20", Offset = "0x3298020", Length = "0x21")]
		[Token(Token = "0x6002118")]
		private static int Lerp(int a, int b, float t) { }

		[Address(RVA = "0x3298400", Offset = "0x3297800", Length = "0xF7")]
		[Token(Token = "0x600211A")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3298360", Offset = "0x3297760", Length = "0x98")]
		[Token(Token = "0x600211B")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3298C50", Offset = "0x3298050", Length = "0xB9")]
		[Token(Token = "0x6002119")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000465")]
	private class ValuesLength : Values<Length>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E90")]
		private readonly Func<Length, Length, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008FC")]
		public virtual Func<Length, Length, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600211D")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x3299120", Offset = "0x3298520", Length = "0x93")]
		[Token(Token = "0x6002124")]
		public ValuesLength() { }

		[Address(RVA = "0x3298DB0", Offset = "0x32981B0", Length = "0x39")]
		[Token(Token = "0x600211F")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Length a, ref Length b) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600211D")]
		public virtual Func<Length, Length, Boolean> get_SameFunc() { }

		[Address(RVA = "0x3298DF0", Offset = "0x32981F0", Length = "0x3A")]
		[Token(Token = "0x600211E")]
		private static bool IsSame(Length a, Length b) { }

		[Address(RVA = "0x3298E30", Offset = "0x3298230", Length = "0x47")]
		[Token(Token = "0x6002120")]
		internal static Length Lerp(Length a, Length b, float t) { }

		[Address(RVA = "0x3298E80", Offset = "0x3298280", Length = "0xF7")]
		[Token(Token = "0x6002122")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3298F80", Offset = "0x3298380", Length = "0x99")]
		[Token(Token = "0x6002123")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x3299020", Offset = "0x3298420", Length = "0xF9")]
		[Token(Token = "0x6002121")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000475")]
	private class ValuesListFilterFunction : Values<List`1<FilterFunction>>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E9A")]
		private readonly Func<List`1<FilterFunction>, List`1<FilterFunction>, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000906")]
		public virtual Func<List`1<FilterFunction>, List`1<FilterFunction>, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002179")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329A1E0", Offset = "0x32995E0", Length = "0x93")]
		[Token(Token = "0x6002183")]
		public ValuesListFilterFunction() { }

		[Address(RVA = "0x32991C0", Offset = "0x32985C0", Length = "0x96")]
		[Token(Token = "0x600217C")]
		private static bool AreFilterDefinitionsCompatible(FilterFunctionDefinition filterDef1, FilterFunctionDefinition filterDef2) { }

		[Address(RVA = "0x3299260", Offset = "0x3298660", Length = "0x1BC")]
		[Token(Token = "0x600217B")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref List<FilterFunction>& a, ref List<FilterFunction>& b) { }

		[Address(RVA = "0x3299420", Offset = "0x3298820", Length = "0x64")]
		[Token(Token = "0x6002178")]
		protected virtual List<FilterFunction> Copy(List<FilterFunction> value) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002179")]
		public virtual Func<List`1<FilterFunction>, List`1<FilterFunction>, Boolean> get_SameFunc() { }

		[Address(RVA = "0x3299490", Offset = "0x3298890", Length = "0x26D")]
		[Token(Token = "0x6002181")]
		private static FilterFunction GetFunctionOrDefault(ref List<FilterFunction>& srcList, ref List<FilterFunction>& refList, int index) { }

		[Address(RVA = "0x3299700", Offset = "0x3298B00", Length = "0x166")]
		[Token(Token = "0x600217A")]
		private static bool IsSame(List<FilterFunction> a, List<FilterFunction> b) { }

		[Address(RVA = "0x32999E0", Offset = "0x3298DE0", Length = "0x58B")]
		[Token(Token = "0x6002180")]
		private static void Lerp(List<FilterFunction> a, List<FilterFunction> b, ref List<FilterFunction>& result, float t) { }

		[Address(RVA = "0x3299870", Offset = "0x3298C70", Length = "0x16A")]
		[Token(Token = "0x600217F")]
		private static FilterParameter LerpFilterParameters(FilterParameter a, FilterParameter b, float t) { }

		[Address(RVA = "0x329A010", Offset = "0x3299410", Length = "0xF7")]
		[Token(Token = "0x600217D")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x3299F70", Offset = "0x3299370", Length = "0x99")]
		[Token(Token = "0x600217E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329A110", Offset = "0x3299510", Length = "0xC0")]
		[Token(Token = "0x6002182")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000476")]
	private class ValuesMaterialDefinition : Values<MaterialDefinition>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E9B")]
		private readonly Func<MaterialDefinition, MaterialDefinition, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000907")]
		public virtual Func<MaterialDefinition, MaterialDefinition, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002185")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329B330", Offset = "0x329A730", Length = "0x93")]
		[Token(Token = "0x600218E")]
		public ValuesMaterialDefinition() { }

		[Address(RVA = "0x329A280", Offset = "0x3299680", Length = "0x2B6")]
		[Token(Token = "0x6002187")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref MaterialDefinition a, ref MaterialDefinition b) { }

		[Address(RVA = "0x329A540", Offset = "0x3299940", Length = "0x40")]
		[Token(Token = "0x6002184")]
		protected virtual MaterialDefinition Copy(MaterialDefinition value) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002185")]
		public virtual Func<MaterialDefinition, MaterialDefinition, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329A580", Offset = "0x3299980", Length = "0x18A")]
		[Token(Token = "0x600218B")]
		private static MaterialPropertyValue GetValueOrDefault(List<MaterialPropertyValue> srcList, List<MaterialPropertyValue> refList, int index) { }

		[Address(RVA = "0x329A710", Offset = "0x3299B10", Length = "0x21F")]
		[Token(Token = "0x6002186")]
		private static bool IsSame(MaterialDefinition a, MaterialDefinition b) { }

		[Address(RVA = "0x329AB20", Offset = "0x3299F20", Length = "0x553")]
		[Token(Token = "0x600218C")]
		private static void Lerp(MaterialDefinition a, MaterialDefinition b, ref MaterialDefinition result, float t) { }

		[Address(RVA = "0x329A930", Offset = "0x3299D30", Length = "0x1ED")]
		[Token(Token = "0x600218A")]
		private static MaterialPropertyValue LerpPropertyValues(MaterialPropertyValue a, MaterialPropertyValue b, float t) { }

		[Address(RVA = "0x329B080", Offset = "0x329A480", Length = "0x10A")]
		[Token(Token = "0x6002188")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329B190", Offset = "0x329A590", Length = "0xAB")]
		[Token(Token = "0x6002189")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329B240", Offset = "0x329A640", Length = "0xE4")]
		[Token(Token = "0x600218D")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200046F")]
	private class ValuesRatio : Values<Ratio>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E96")]
		private readonly Func<Ratio, Ratio, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000902")]
		public virtual Func<Ratio, Ratio, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002152")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329B800", Offset = "0x329AC00", Length = "0x93")]
		[Token(Token = "0x6002159")]
		public ValuesRatio() { }

		[Address(RVA = "0x329B3D0", Offset = "0x329A7D0", Length = "0x16F")]
		[Token(Token = "0x6002154")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Ratio a, ref Ratio b) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002152")]
		public virtual Func<Ratio, Ratio, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329B540", Offset = "0x329A940", Length = "0x8")]
		[Token(Token = "0x6002153")]
		private static bool IsSame(Ratio a, Ratio b) { }

		[Address(RVA = "0x329B550", Offset = "0x329A950", Length = "0x34")]
		[Token(Token = "0x6002157")]
		private static Ratio Lerp(Ratio a, Ratio b, float t) { }

		[Address(RVA = "0x329B590", Offset = "0x329A990", Length = "0xF7")]
		[Token(Token = "0x6002155")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329B690", Offset = "0x329AA90", Length = "0x98")]
		[Token(Token = "0x6002156")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329B730", Offset = "0x329AB30", Length = "0xC5")]
		[Token(Token = "0x6002158")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200046E")]
	private class ValuesRotate : Values<Rotate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E95")]
		private readonly Func<Rotate, Rotate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000901")]
		public virtual Func<Rotate, Rotate, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600214B")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329BDB0", Offset = "0x329B1B0", Length = "0x93")]
		[Token(Token = "0x6002151")]
		public ValuesRotate() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600214B")]
		public virtual Func<Rotate, Rotate, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329B8A0", Offset = "0x329ACA0", Length = "0x41")]
		[Token(Token = "0x600214C")]
		private static bool IsSame(Rotate a, Rotate b) { }

		[Address(RVA = "0x329B8F0", Offset = "0x329ACF0", Length = "0xE2")]
		[Token(Token = "0x600214F")]
		private static Rotate Lerp(Rotate a, Rotate b, float t) { }

		[Address(RVA = "0x329BAA0", Offset = "0x329AEA0", Length = "0x125")]
		[Token(Token = "0x600214D")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329B9E0", Offset = "0x329ADE0", Length = "0xB8")]
		[Token(Token = "0x600214E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329BBD0", Offset = "0x329AFD0", Length = "0x1D5")]
		[Token(Token = "0x6002150")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200046D")]
	private class ValuesScale : Values<Scale>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E94")]
		private readonly Func<Scale, Scale, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000900")]
		public virtual Func<Scale, Scale, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002144")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329C1F0", Offset = "0x329B5F0", Length = "0x93")]
		[Token(Token = "0x600214A")]
		public ValuesScale() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002144")]
		public virtual Func<Scale, Scale, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329BE50", Offset = "0x329B250", Length = "0x2B")]
		[Token(Token = "0x6002145")]
		private static bool IsSame(Scale a, Scale b) { }

		[Address(RVA = "0x329BE80", Offset = "0x329B280", Length = "0x7C")]
		[Token(Token = "0x6002148")]
		private static Scale Lerp(Scale a, Scale b, float t) { }

		[Address(RVA = "0x329BFB0", Offset = "0x329B3B0", Length = "0x10A")]
		[Token(Token = "0x6002146")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329BF00", Offset = "0x329B300", Length = "0xAB")]
		[Token(Token = "0x6002147")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329C0C0", Offset = "0x329B4C0", Length = "0x12B")]
		[Token(Token = "0x6002149")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x200046C")]
	private class ValuesTextShadow : Values<TextShadow>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E93")]
		private readonly Func<TextShadow, TextShadow, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x170008FF")]
		public virtual Func<TextShadow, TextShadow, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600213D")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329C6C0", Offset = "0x329BAC0", Length = "0x93")]
		[Token(Token = "0x6002143")]
		public ValuesTextShadow() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600213D")]
		public virtual Func<TextShadow, TextShadow, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329C290", Offset = "0x329B690", Length = "0x4F")]
		[Token(Token = "0x600213E")]
		private static bool IsSame(TextShadow a, TextShadow b) { }

		[Address(RVA = "0x329C2E0", Offset = "0x329B6E0", Length = "0x82")]
		[Token(Token = "0x600213F")]
		private static TextShadow Lerp(TextShadow a, TextShadow b, float t) { }

		[Address(RVA = "0x329C440", Offset = "0x329B840", Length = "0x13C")]
		[Token(Token = "0x6002141")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329C370", Offset = "0x329B770", Length = "0xCA")]
		[Token(Token = "0x6002142")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329C580", Offset = "0x329B980", Length = "0x137")]
		[Token(Token = "0x6002140")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000471")]
	private class ValuesTransformOrigin : Values<TransformOrigin>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E98")]
		private readonly Func<TransformOrigin, TransformOrigin, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000904")]
		public virtual Func<TransformOrigin, TransformOrigin, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6002162")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329CD10", Offset = "0x329C110", Length = "0x93")]
		[Token(Token = "0x6002169")]
		public ValuesTransformOrigin() { }

		[Address(RVA = "0x329C760", Offset = "0x329BB60", Length = "0x2B")]
		[Token(Token = "0x6002164")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref TransformOrigin a, ref TransformOrigin b) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6002162")]
		public virtual Func<TransformOrigin, TransformOrigin, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329C790", Offset = "0x329BB90", Length = "0x39")]
		[Token(Token = "0x6002163")]
		private static bool IsSame(TransformOrigin a, TransformOrigin b) { }

		[Address(RVA = "0x329C7D0", Offset = "0x329BBD0", Length = "0x10F")]
		[Token(Token = "0x6002167")]
		private static TransformOrigin Lerp(TransformOrigin a, TransformOrigin b, float t) { }

		[Address(RVA = "0x329C9A0", Offset = "0x329BDA0", Length = "0x121")]
		[Token(Token = "0x6002165")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329C8E0", Offset = "0x329BCE0", Length = "0xB6")]
		[Token(Token = "0x6002166")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329CAD0", Offset = "0x329BED0", Length = "0x236")]
		[Token(Token = "0x6002168")]
		protected virtual void UpdateValues() { }

	}

	[Token(Token = "0x2000470")]
	private class ValuesTranslate : Values<Translate>
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000E97")]
		private readonly Func<Translate, Translate, Boolean> <SameFunc>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000903")]
		public virtual Func<Translate, Translate, Boolean> SameFunc
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x600215A")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x329D380", Offset = "0x329C780", Length = "0x93")]
		[Token(Token = "0x6002161")]
		public ValuesTranslate() { }

		[Address(RVA = "0x329CDB0", Offset = "0x329C1B0", Length = "0x2B")]
		[Token(Token = "0x600215C")]
		protected virtual bool ConvertUnits(VisualElement owner, StylePropertyId prop, ref Translate a, ref Translate b) { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x600215A")]
		public virtual Func<Translate, Translate, Boolean> get_SameFunc() { }

		[Address(RVA = "0x329CDE0", Offset = "0x329C1E0", Length = "0x41")]
		[Token(Token = "0x600215B")]
		private static bool IsSame(Translate a, Translate b) { }

		[Address(RVA = "0x329CE30", Offset = "0x329C230", Length = "0x110")]
		[Token(Token = "0x600215F")]
		private static Translate Lerp(Translate a, Translate b, float t) { }

		[Address(RVA = "0x329D000", Offset = "0x329C400", Length = "0x125")]
		[Token(Token = "0x600215D")]
		protected virtual void UpdateComputedStyle() { }

		[Address(RVA = "0x329CF40", Offset = "0x329C340", Length = "0xB8")]
		[Token(Token = "0x600215E")]
		protected virtual void UpdateComputedStyle(int i) { }

		[Address(RVA = "0x329D130", Offset = "0x329C530", Length = "0x245")]
		[Token(Token = "0x6002160")]
		protected virtual void UpdateValues() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000E52")]
	private double m_CurrentTime; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000E53")]
	private ValuesFloat m_Floats; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000E54")]
	private ValuesInt m_Ints; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000E55")]
	private ValuesLength m_Lengths; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000E56")]
	private ValuesColor m_Colors; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000E57")]
	private ValuesEnum m_Enums; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000E58")]
	private ValuesBackground m_Backgrounds; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000E59")]
	private ValuesFontDefinition m_FontDefinitions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000E5A")]
	private ValuesFont m_Fonts; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000E5B")]
	private ValuesTextShadow m_TextShadows; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000E5C")]
	private ValuesScale m_Scale; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000E5D")]
	private ValuesRotate m_Rotate; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4000E5E")]
	private ValuesRatio m_Ratio; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000E5F")]
	private ValuesTranslate m_Translate; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000E60")]
	private ValuesTransformOrigin m_TransformOrigin; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000E61")]
	private ValuesBackgroundPosition m_BackgroundPosition; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000E62")]
	private ValuesBackgroundRepeat m_BackgroundRepeat; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000E63")]
	private ValuesBackgroundSize m_BackgroundSize; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000E64")]
	private ValuesListFilterFunction m_FilterFunctions; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000E65")]
	private ValuesMaterialDefinition m_MaterialDefinition; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000E66")]
	private readonly List<Values> m_AllValues; //Field offset: 0xB0
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000E67")]
	private readonly Dictionary<StylePropertyId, Values> m_PropertyToValues; //Field offset: 0xB8

	[Address(RVA = "0x3289DE0", Offset = "0x32891E0", Length = "0xF8")]
	[Token(Token = "0x60020B2")]
	public StylePropertyAnimationSystem(BaseVisualElementPanel p) { }

	[Address(RVA = "0x32887D0", Offset = "0x3287BD0", Length = "0x1DA")]
	[Token(Token = "0x60020C9")]
	public override void CancelAllAnimations(VisualElement owner) { }

	[Address(RVA = "0x32886B0", Offset = "0x3287AB0", Length = "0x119")]
	[Token(Token = "0x60020C8")]
	public override void CancelAllAnimations() { }

	[Address(RVA = "0x32889B0", Offset = "0x3287DB0", Length = "0x98")]
	[Token(Token = "0x60020CA")]
	public override void CancelAnimation(VisualElement owner, StylePropertyId id) { }

	[Address(RVA = "0x3288A50", Offset = "0x3287E50", Length = "0x8")]
	[Token(Token = "0x60020CE")]
	private double CurrentTimeSeconds() { }

	[Address(RVA = "0x3288A60", Offset = "0x3287E60", Length = "0x138")]
	[Token(Token = "0x60020CC")]
	public override void GetAllAnimations(VisualElement owner, List<StylePropertyId> propertyIds) { }

	[Address(RVA = "0x9187C0", Offset = "0x917BC0", Length = "0x53")]
	[Token(Token = "0x60020B3")]
	private T GetOrCreate(ref T values) { }

	[Address(RVA = "0x3288F20", Offset = "0x3288320", Length = "0xDD")]
	[Token(Token = "0x60020C7")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, MaterialDefinition startValue, MaterialDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3288C60", Offset = "0x3288060", Length = "0xC5")]
	[Token(Token = "0x60020C6")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, List<FilterFunction> startValue, List<FilterFunction> endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289450", Offset = "0x3288850", Length = "0xF4")]
	[Token(Token = "0x60020C5")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundSize startValue, BackgroundSize endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289AE0", Offset = "0x3288EE0", Length = "0xC5")]
	[Token(Token = "0x60020C4")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundRepeat startValue, BackgroundRepeat endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3288D30", Offset = "0x3288130", Length = "0xEF")]
	[Token(Token = "0x60020C3")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, BackgroundPosition startValue, BackgroundPosition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289290", Offset = "0x3288690", Length = "0xF4")]
	[Token(Token = "0x60020C2")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TransformOrigin startValue, TransformOrigin endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289BB0", Offset = "0x3288FB0", Length = "0xC8")]
	[Token(Token = "0x60020C1")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Ratio startValue, Ratio endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x32899E0", Offset = "0x3288DE0", Length = "0xF9")]
	[Token(Token = "0x60020C0")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Translate startValue, Translate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289830", Offset = "0x3288C30", Length = "0xDA")]
	[Token(Token = "0x60020BE")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Scale startValue, Scale endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289650", Offset = "0x3288A50", Length = "0x10D")]
	[Token(Token = "0x60020BD")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, TextShadow startValue, TextShadow endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289910", Offset = "0x3288D10", Length = "0xC2")]
	[Token(Token = "0x60020BC")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Font startValue, Font endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289000", Offset = "0x3288400", Length = "0xDA")]
	[Token(Token = "0x60020BB")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, FontDefinition startValue, FontDefinition endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3288E20", Offset = "0x3288220", Length = "0xF5")]
	[Token(Token = "0x60020BA")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Background startValue, Background endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x32891B0", Offset = "0x32885B0", Length = "0xDA")]
	[Token(Token = "0x60020B8")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Color startValue, Color endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x32890E0", Offset = "0x32884E0", Length = "0xC2")]
	[Token(Token = "0x60020B7")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Length startValue, Length endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289390", Offset = "0x3288790", Length = "0xC0")]
	[Token(Token = "0x60020B6")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289760", Offset = "0x3288B60", Length = "0xC4")]
	[Token(Token = "0x60020B5")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, float startValue, float endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x918D90", Offset = "0x918190", Length = "0x1E1")]
	[Token(Token = "0x60020B4")]
	private bool StartTransition(VisualElement owner, StylePropertyId prop, T startValue, T endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve, Values<T> values) { }

	[Address(RVA = "0x3289550", Offset = "0x3288950", Length = "0xF9")]
	[Token(Token = "0x60020BF")]
	public override bool StartTransition(VisualElement owner, StylePropertyId prop, Rotate startValue, Rotate endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3288BA0", Offset = "0x3287FA0", Length = "0xC0")]
	[Token(Token = "0x60020B9")]
	public override bool StartTransitionEnum(VisualElement owner, StylePropertyId prop, int startValue, int endValue, int durationMs, int delayMs, Func<Single, Single> easingCurve) { }

	[Address(RVA = "0x3289D20", Offset = "0x3289120", Length = "0xB7")]
	[Token(Token = "0x60020CF")]
	public override void Update(double updateTime) { }

	[Address(RVA = "0x3289C80", Offset = "0x3289080", Length = "0x98")]
	[Token(Token = "0x60020CB")]
	public override void UpdateAnimation(VisualElement owner, StylePropertyId id) { }

	[Address(RVA = "0x91A940", Offset = "0x919D40", Length = "0xAE")]
	[Token(Token = "0x60020CD")]
	private void UpdateTracking(Values<T> values) { }

}

