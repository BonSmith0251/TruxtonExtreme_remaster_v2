namespace UnityEngine.UIElements.Experimental;

[Token(Token = "0x2000662")]
public sealed class ValueAnimation : IValueAnimationUpdate
{
	[CompilerGenerated]
	[Token(Token = "0x2000663")]
	private sealed class <>c
	{
		[Token(Token = "0x40017F1")]
		public static readonly <>c<T> <>9; //Field offset: 0x0

		[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
		[Token(Token = "0x6002D68")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6002D69")]
		public <>c() { }

		[Address(RVA = "0xA36CC0", Offset = "0xA360C0", Length = "0x5D")]
		[Token(Token = "0x6002D6A")]
		internal ValueAnimation<T> <.cctor>b__67_0() { }

	}

	[Token(Token = "0x40017E9")]
	private static ObjectPool<ValueAnimation`1<T>> sObjectPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E2")]
	private long m_StartTimeMs; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E3")]
	private int m_DurationMs; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E4")]
	private Func<Single, Single> <easingCurve>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E5")]
	private bool <isRunning>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E6")]
	private Action <onAnimationCompleted>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E7")]
	private bool <autoRecycle>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017E8")]
	private bool <recycled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017EA")]
	private VisualElement <owner>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017EB")]
	private Action<VisualElement, T> <valueUpdated>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017EC")]
	private Func<VisualElement, T> <initialValue>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017ED")]
	private Func<T, T, Single, T> <interpolator>k__BackingField; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017EE")]
	private T _from; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017EF")]
	private bool fromValueSet; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40017F0")]
	private T <to>k__BackingField; //Field offset: 0x0

	[Token(Token = "0x17000B8A")]
	public bool autoRecycle
	{
		[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4B")]
		 get { } //Length: 5
		[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000B86")]
	public override int durationMs
	{
		[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
		[Token(Token = "0x6002D43")]
		 get { } //Length: 6
		[Address(RVA = "0x11ED960", Offset = "0x11ECD60", Length = "0x10")]
		[Token(Token = "0x6002D44")]
		 set { } //Length: 16
	}

	[Token(Token = "0x17000B87")]
	public Func<Single, Single> easingCurve
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D45")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D46")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B90")]
	public T from
	{
		[Address(RVA = "0x11ED430", Offset = "0x11EC830", Length = "0x53")]
		[Token(Token = "0x6002D57")]
		 get { } //Length: 83
		[Address(RVA = "0x11EDA80", Offset = "0x11ECE80", Length = "0x13")]
		[Token(Token = "0x6002D58")]
		 set { } //Length: 19
	}

	[Token(Token = "0x17000B8E")]
	public Func<VisualElement, T> initialValue
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D53")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D54")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B8F")]
	public Func<T, T, Single, T> interpolator
	{
		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D55")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D56")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B88")]
	public private override bool isRunning
	{
		[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D47")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002D48")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B89")]
	public Action onAnimationCompleted
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D49")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4A")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000B8C")]
	private VisualElement owner
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4F")]
		private get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D50")]
		private set { } //Length: 13
	}

	[Token(Token = "0x17000B8B")]
	private bool recycled
	{
		[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4D")]
		private get { } //Length: 5
		[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6002D4E")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000B91")]
	public T to
	{
		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D59")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDD60", Offset = "0x11ED160", Length = "0xF")]
		[CompilerGenerated]
		[Token(Token = "0x6002D5A")]
		 set { } //Length: 15
	}

	[Token(Token = "0x17000B8D")]
	public Action<VisualElement, T> valueUpdated
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6002D51")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6002D52")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x11ECE50", Offset = "0x11EC250", Length = "0x235")]
	[Token(Token = "0x6002D67")]
	private static ValueAnimation`1() { }

	[Address(RVA = "0x11ED3B0", Offset = "0x11EC7B0", Length = "0x3C")]
	[Token(Token = "0x6002D5B")]
	public ValueAnimation`1() { }

	[Address(RVA = "0x11EB6D0", Offset = "0x11EAAD0", Length = "0x5B")]
	[Token(Token = "0x6002D64")]
	private void CheckNotRecycled() { }

	[Address(RVA = "0x11EB730", Offset = "0x11EAB30", Length = "0x18F")]
	[Token(Token = "0x6002D65")]
	public static ValueAnimation<T> Create(VisualElement e, Func<T, T, Single, T> interpolator) { }

	[Address(RVA = "0x11ED420", Offset = "0x11EC820", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4B")]
	public bool get_autoRecycle() { }

	[Address(RVA = "0xE0D7C0", Offset = "0xE0CBC0", Length = "0x6")]
	[Token(Token = "0x6002D43")]
	public override int get_durationMs() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D45")]
	public Func<Single, Single> get_easingCurve() { }

	[Address(RVA = "0x11ED430", Offset = "0x11EC830", Length = "0x53")]
	[Token(Token = "0x6002D57")]
	public T get_from() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D53")]
	public Func<VisualElement, T> get_initialValue() { }

	[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D55")]
	public Func<T, T, Single, T> get_interpolator() { }

	[Address(RVA = "0x5BB290", Offset = "0x5BA690", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D47")]
	public override bool get_isRunning() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D49")]
	public Action get_onAnimationCompleted() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4F")]
	private VisualElement get_owner() { }

	[Address(RVA = "0x11ED750", Offset = "0x11ECB50", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4D")]
	private bool get_recycled() { }

	[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D59")]
	public T get_to() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6002D51")]
	public Action<VisualElement, T> get_valueUpdated() { }

	[Address(RVA = "0x11EBB20", Offset = "0x11EAF20", Length = "0x8")]
	[Token(Token = "0x6002D66")]
	public ValueAnimation<T> KeepAlive() { }

	[Address(RVA = "0x11EBB30", Offset = "0x11EAF30", Length = "0x147")]
	[Token(Token = "0x6002D5E")]
	public override void Recycle() { }

	[Address(RVA = "0x11EBDF0", Offset = "0x11EB1F0", Length = "0x17")]
	[Token(Token = "0x6002D62")]
	private void Register() { }

	[Address(RVA = "0x11ED8E0", Offset = "0x11ECCE0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4C")]
	public void set_autoRecycle(bool value) { }

	[Address(RVA = "0x11ED960", Offset = "0x11ECD60", Length = "0x10")]
	[Token(Token = "0x6002D44")]
	public override void set_durationMs(int value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D46")]
	public void set_easingCurve(Func<Single, Single> value) { }

	[Address(RVA = "0x11EDA80", Offset = "0x11ECE80", Length = "0x13")]
	[Token(Token = "0x6002D58")]
	public void set_from(T value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D54")]
	public void set_initialValue(Func<VisualElement, T> value) { }

	[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D56")]
	public void set_interpolator(Func<T, T, Single, T> value) { }

	[Address(RVA = "0x11EDB90", Offset = "0x11ECF90", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002D48")]
	private void set_isRunning(bool value) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4A")]
	public void set_onAnimationCompleted(Action value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D50")]
	private void set_owner(VisualElement value) { }

	[Address(RVA = "0x11EDC90", Offset = "0x11ED090", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6002D4E")]
	private void set_recycled(bool value) { }

	[Address(RVA = "0x11EDD60", Offset = "0x11ED160", Length = "0xF")]
	[CompilerGenerated]
	[Token(Token = "0x6002D5A")]
	public void set_to(T value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[CompilerGenerated]
	[Token(Token = "0x6002D52")]
	public void set_valueUpdated(Action<VisualElement, T> value) { }

	[Address(RVA = "0x11EC1F0", Offset = "0x11EB5F0", Length = "0xF3")]
	[Token(Token = "0x6002D60")]
	private void SetDefaultValues() { }

	[Address(RVA = "0x11EC2F0", Offset = "0x11EB6F0", Length = "0x63")]
	[Token(Token = "0x6002D63")]
	internal void SetOwner(VisualElement e) { }

	[Address(RVA = "0x11EC410", Offset = "0x11EB810", Length = "0x99")]
	[Token(Token = "0x6002D5C")]
	public override void Start() { }

	[Address(RVA = "0x11EC6D0", Offset = "0x11EBAD0", Length = "0x192")]
	[Token(Token = "0x6002D5D")]
	public override void Stop() { }

	[Address(RVA = "0x11ECC30", Offset = "0x11EC030", Length = "0x181")]
	[Token(Token = "0x6002D5F")]
	private override void UnityEngine.UIElements.Experimental.IValueAnimationUpdate.Tick(long currentTimeMs) { }

	[Address(RVA = "0x11ECDC0", Offset = "0x11EC1C0", Length = "0x17")]
	[Token(Token = "0x6002D61")]
	private void Unregister() { }

}

