namespace UnityEngine.InputSystem;

[DebuggerDisplay("{DebuggerDisplay(),nq}")]
[DefaultMember("Item")]
[Token(Token = "0x2000070")]
public abstract class InputControl
{
	[Flags]
	[Token(Token = "0x2000071")]
	public enum ControlFlags : int
	{
		ConfigUpToDate = 1,
		IsNoisy = 2,
		IsSynthetic = 4,
		IsButton = 8,
		DontReset = 16,
		SetupFinished = 32,
		UsesStateFromOtherControl = 64,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400027F")]
	protected private InputStateBlock m_StateBlock; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000280")]
	internal InternedString m_Name; //Field offset: 0x20
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000281")]
	internal string m_Path; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000282")]
	internal string m_DisplayName; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000283")]
	internal string m_DisplayNameFromLayout; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000284")]
	internal string m_ShortDisplayName; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000285")]
	internal string m_ShortDisplayNameFromLayout; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000286")]
	internal InternedString m_Layout; //Field offset: 0x58
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000287")]
	internal InternedString m_Variants; //Field offset: 0x68
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000288")]
	internal InputDevice m_Device; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000289")]
	internal InputControl m_Parent; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400028A")]
	internal int m_UsageCount; //Field offset: 0x88
	[FieldOffset(Offset = "0x8C")]
	[Token(Token = "0x400028B")]
	internal int m_UsageStartIndex; //Field offset: 0x8C
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400028C")]
	internal int m_AliasCount; //Field offset: 0x90
	[FieldOffset(Offset = "0x94")]
	[Token(Token = "0x400028D")]
	internal int m_AliasStartIndex; //Field offset: 0x94
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400028E")]
	internal int m_ChildCount; //Field offset: 0x98
	[FieldOffset(Offset = "0x9C")]
	[Token(Token = "0x400028F")]
	internal int m_ChildStartIndex; //Field offset: 0x9C
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000290")]
	internal ControlFlags m_ControlFlags; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA4")]
	[Token(Token = "0x4000291")]
	internal bool m_CachedValueIsStale; //Field offset: 0xA4
	[FieldOffset(Offset = "0xA5")]
	[Token(Token = "0x4000292")]
	internal bool m_UnprocessedCachedValueIsStale; //Field offset: 0xA5
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000293")]
	internal PrimitiveValue m_DefaultState; //Field offset: 0xA8
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4000294")]
	internal PrimitiveValue m_MinValue; //Field offset: 0xB8
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4000295")]
	internal PrimitiveValue m_MaxValue; //Field offset: 0xC8
	[FieldOffset(Offset = "0xD8")]
	[Token(Token = "0x4000296")]
	internal FourCC m_OptimizedControlDataType; //Field offset: 0xD8

	[Token(Token = "0x1700017C")]
	public ReadOnlyArray<InternedString> aliases
	{
		[Address(RVA = "0x2937C80", Offset = "0x2937080", Length = "0x77")]
		[Token(Token = "0x6000519")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700017A")]
	public ReadOnlyArray<InputControl> children
	{
		[Address(RVA = "0x2937D00", Offset = "0x2937100", Length = "0x77")]
		[Token(Token = "0x6000517")]
		 get { } //Length: 119
	}

	[Token(Token = "0x17000184")]
	protected private Void* currentStatePtr
	{
		[Address(RVA = "0x2937D80", Offset = "0x2937180", Length = "0x18")]
		[Token(Token = "0x6000535")]
		private get { } //Length: 24
	}

	[Token(Token = "0x17000186")]
	protected private Void* defaultStatePtr
	{
		[Address(RVA = "0x2937DA0", Offset = "0x29371A0", Length = "0x36")]
		[Token(Token = "0x6000537")]
		private get { } //Length: 54
	}

	[Token(Token = "0x17000178")]
	public InputDevice device
	{
		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x6000515")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000173")]
	public string displayName
	{
		[Address(RVA = "0x2937DE0", Offset = "0x29371E0", Length = "0x69")]
		[Token(Token = "0x600050E")]
		 get { } //Length: 105
		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[Token(Token = "0x600050F")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700018D")]
	internal bool dontReset
	{
		[Address(RVA = "0x2937E50", Offset = "0x2937250", Length = "0xC")]
		[Token(Token = "0x6000546")]
		internal get { } //Length: 12
		[Address(RVA = "0x29381F0", Offset = "0x29375F0", Length = "0x1F")]
		[Token(Token = "0x6000547")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700018F")]
	internal bool hasDefaultState
	{
		[Address(RVA = "0x2937E60", Offset = "0x2937260", Length = "0x19")]
		[Token(Token = "0x600054A")]
		internal get { } //Length: 25
	}

	[Token(Token = "0x1700018B")]
	internal bool isButton
	{
		[Address(RVA = "0x2937E80", Offset = "0x2937280", Length = "0xC")]
		[Token(Token = "0x6000542")]
		internal get { } //Length: 12
		[Address(RVA = "0x2938210", Offset = "0x2937610", Length = "0x1F")]
		[Token(Token = "0x6000543")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700018C")]
	internal bool isConfigUpToDate
	{
		[Address(RVA = "0x2937E90", Offset = "0x2937290", Length = "0xA")]
		[Token(Token = "0x6000544")]
		internal get { } //Length: 10
		[Address(RVA = "0x2938230", Offset = "0x2937630", Length = "0x1F")]
		[Token(Token = "0x6000545")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700018A")]
	internal bool isSetupFinished
	{
		[Address(RVA = "0x2937EA0", Offset = "0x29372A0", Length = "0xC")]
		[Token(Token = "0x6000540")]
		internal get { } //Length: 12
		[Address(RVA = "0x2938250", Offset = "0x2937650", Length = "0x1F")]
		[Token(Token = "0x6000541")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x17000180")]
	public InputControl Item
	{
		[Address(RVA = "0x2937BD0", Offset = "0x2936FD0", Length = "0xAD")]
		[Token(Token = "0x600051F")]
		 get { } //Length: 173
	}

	[Token(Token = "0x17000176")]
	public string layout
	{
		[Address(RVA = "0x2937EB0", Offset = "0x29372B0", Length = "0x1E")]
		[Token(Token = "0x6000513")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000183")]
	public float magnitude
	{
		[Address(RVA = "0x2936FC0", Offset = "0x29363C0", Length = "0x38")]
		[Token(Token = "0x6000522")]
		 get { } //Length: 56
	}

	[Token(Token = "0x17000172")]
	public string name
	{
		[Address(RVA = "0x2937ED0", Offset = "0x29372D0", Length = "0x1E")]
		[Token(Token = "0x600050D")]
		 get { } //Length: 30
	}

	[Token(Token = "0x17000187")]
	protected private Void* noiseMaskPtr
	{
		[Address(RVA = "0x2937EF0", Offset = "0x29372F0", Length = "0x37")]
		[Token(Token = "0x6000538")]
		private get { } //Length: 55
	}

	[Token(Token = "0x1700017E")]
	public internal bool noisy
	{
		[Address(RVA = "0x2937F30", Offset = "0x2937330", Length = "0xB")]
		[Token(Token = "0x600051B")]
		 get { } //Length: 11
		[Address(RVA = "0x2938270", Offset = "0x2937670", Length = "0x14B")]
		[Token(Token = "0x600051C")]
		internal set { } //Length: 331
	}

	[Token(Token = "0x17000189")]
	public FourCC optimizedControlDataType
	{
		[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
		[Token(Token = "0x600053A")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000179")]
	public InputControl parent
	{
		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x6000516")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000175")]
	public string path
	{
		[Address(RVA = "0x2937F40", Offset = "0x2937340", Length = "0x106")]
		[Token(Token = "0x6000512")]
		 get { } //Length: 262
	}

	[Token(Token = "0x17000185")]
	protected private Void* previousFrameStatePtr
	{
		[Address(RVA = "0x2938050", Offset = "0x2937450", Length = "0x18")]
		[Token(Token = "0x6000536")]
		private get { } //Length: 24
	}

	[Token(Token = "0x17000174")]
	public string shortDisplayName
	{
		[Address(RVA = "0x2938070", Offset = "0x2937470", Length = "0x56")]
		[Token(Token = "0x6000510")]
		 get { } //Length: 86
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x6000511")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700017D")]
	public InputStateBlock stateBlock
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x600051A")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000188")]
	protected private uint stateOffsetRelativeToDeviceRoot
	{
		[Address(RVA = "0x29380D0", Offset = "0x29374D0", Length = "0x5D")]
		[Token(Token = "0x6000539")]
		private get { } //Length: 93
	}

	[Token(Token = "0x1700017F")]
	public internal bool synthetic
	{
		[Address(RVA = "0x2938130", Offset = "0x2937530", Length = "0xB")]
		[Token(Token = "0x600051D")]
		 get { } //Length: 11
		[Address(RVA = "0x29383C0", Offset = "0x29377C0", Length = "0x1F")]
		[Token(Token = "0x600051E")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700017B")]
	public ReadOnlyArray<InternedString> usages
	{
		[Address(RVA = "0x2938140", Offset = "0x2937540", Length = "0x77")]
		[Token(Token = "0x6000518")]
		 get { } //Length: 119
	}

	[Token(Token = "0x1700018E")]
	internal bool usesStateFromOtherControl
	{
		[Address(RVA = "0x29381C0", Offset = "0x29375C0", Length = "0xC")]
		[Token(Token = "0x6000548")]
		internal get { } //Length: 12
		[Address(RVA = "0x29383E0", Offset = "0x29377E0", Length = "0x1F")]
		[Token(Token = "0x6000549")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x17000182")]
	public abstract int valueSizeInBytes
	{
		[Token(Token = "0x6000521")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000181")]
	public abstract Type valueType
	{
		[Token(Token = "0x6000520")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000177")]
	public string variants
	{
		[Address(RVA = "0x29381D0", Offset = "0x29375D0", Length = "0x1E")]
		[Token(Token = "0x6000514")]
		 get { } //Length: 30
	}

	[Address(RVA = "0x2937B70", Offset = "0x2936F70", Length = "0x5A")]
	[Token(Token = "0x6000531")]
	protected InputControl() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000550")]
	internal override void AddProcessor(object first) { }

	[Address(RVA = "0x2936770", Offset = "0x2935B70", Length = "0xBD")]
	[Token(Token = "0x600053C")]
	public void ApplyParameterChanges() { }

	[Address(RVA = "0x2936830", Offset = "0x2935C30", Length = "0x123")]
	[Token(Token = "0x600054D")]
	internal void BakeOffsetIntoStateBlockRecursive(uint offset) { }

	[Address(RVA = "0x79B610", Offset = "0x79AA10", Length = "0x3")]
	[Token(Token = "0x600053B")]
	protected override FourCC CalculateOptimizedControlDataType() { }

	[Address(RVA = "0x2936960", Offset = "0x2935D60", Length = "0x120")]
	[Token(Token = "0x600054B")]
	internal void CallFinishSetupRecursive() { }

	[Token(Token = "0x600052C")]
	public abstract bool CompareValue(Void* firstStatePtr, Void* secondStatePtr) { }

	[Address(RVA = "0x2936A90", Offset = "0x2935E90", Length = "0x113")]
	[Token(Token = "0x6000524")]
	private string DebuggerDisplay() { }

	[Address(RVA = "0x2936BB0", Offset = "0x2935FB0", Length = "0x406")]
	[Conditional("UNITY_EDITOR")]
	[Token(Token = "0x600053F")]
	internal void EnsureOptimizationTypeHasNotChanged() { }

	[Address(RVA = "0x292E360", Offset = "0x292D760", Length = "0x9")]
	[Token(Token = "0x6000526")]
	public override float EvaluateMagnitude(Void* statePtr) { }

	[Address(RVA = "0x2936FC0", Offset = "0x29363C0", Length = "0x38")]
	[Token(Token = "0x6000525")]
	public float EvaluateMagnitude() { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000532")]
	protected override void FinishSetup() { }

	[Address(RVA = "0x2937C80", Offset = "0x2937080", Length = "0x77")]
	[Token(Token = "0x6000519")]
	public ReadOnlyArray<InternedString> get_aliases() { }

	[Address(RVA = "0x2937D00", Offset = "0x2937100", Length = "0x77")]
	[Token(Token = "0x6000517")]
	public ReadOnlyArray<InputControl> get_children() { }

	[Address(RVA = "0x2937D80", Offset = "0x2937180", Length = "0x18")]
	[Token(Token = "0x6000535")]
	protected private Void* get_currentStatePtr() { }

	[Address(RVA = "0x2937DA0", Offset = "0x29371A0", Length = "0x36")]
	[Token(Token = "0x6000537")]
	protected private Void* get_defaultStatePtr() { }

	[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
	[Token(Token = "0x6000515")]
	public InputDevice get_device() { }

	[Address(RVA = "0x2937DE0", Offset = "0x29371E0", Length = "0x69")]
	[Token(Token = "0x600050E")]
	public string get_displayName() { }

	[Address(RVA = "0x2937E50", Offset = "0x2937250", Length = "0xC")]
	[Token(Token = "0x6000546")]
	internal bool get_dontReset() { }

	[Address(RVA = "0x2937E60", Offset = "0x2937260", Length = "0x19")]
	[Token(Token = "0x600054A")]
	internal bool get_hasDefaultState() { }

	[Address(RVA = "0x2937E80", Offset = "0x2937280", Length = "0xC")]
	[Token(Token = "0x6000542")]
	internal bool get_isButton() { }

	[Address(RVA = "0x2937E90", Offset = "0x2937290", Length = "0xA")]
	[Token(Token = "0x6000544")]
	internal bool get_isConfigUpToDate() { }

	[Address(RVA = "0x2937EA0", Offset = "0x29372A0", Length = "0xC")]
	[Token(Token = "0x6000540")]
	internal bool get_isSetupFinished() { }

	[Address(RVA = "0x2937BD0", Offset = "0x2936FD0", Length = "0xAD")]
	[Token(Token = "0x600051F")]
	public InputControl get_Item(string path) { }

	[Address(RVA = "0x2937EB0", Offset = "0x29372B0", Length = "0x1E")]
	[Token(Token = "0x6000513")]
	public string get_layout() { }

	[Address(RVA = "0x2936FC0", Offset = "0x29363C0", Length = "0x38")]
	[Token(Token = "0x6000522")]
	public float get_magnitude() { }

	[Address(RVA = "0x2937ED0", Offset = "0x29372D0", Length = "0x1E")]
	[Token(Token = "0x600050D")]
	public string get_name() { }

	[Address(RVA = "0x2937EF0", Offset = "0x29372F0", Length = "0x37")]
	[Token(Token = "0x6000538")]
	protected private Void* get_noiseMaskPtr() { }

	[Address(RVA = "0x2937F30", Offset = "0x2937330", Length = "0xB")]
	[Token(Token = "0x600051B")]
	public bool get_noisy() { }

	[Address(RVA = "0x1D16D10", Offset = "0x1D16110", Length = "0x7")]
	[Token(Token = "0x600053A")]
	public FourCC get_optimizedControlDataType() { }

	[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
	[Token(Token = "0x6000516")]
	public InputControl get_parent() { }

	[Address(RVA = "0x2937F40", Offset = "0x2937340", Length = "0x106")]
	[Token(Token = "0x6000512")]
	public string get_path() { }

	[Address(RVA = "0x2938050", Offset = "0x2937450", Length = "0x18")]
	[Token(Token = "0x6000536")]
	protected private Void* get_previousFrameStatePtr() { }

	[Address(RVA = "0x2938070", Offset = "0x2937470", Length = "0x56")]
	[Token(Token = "0x6000510")]
	public string get_shortDisplayName() { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x600051A")]
	public InputStateBlock get_stateBlock() { }

	[Address(RVA = "0x29380D0", Offset = "0x29374D0", Length = "0x5D")]
	[Token(Token = "0x6000539")]
	protected private uint get_stateOffsetRelativeToDeviceRoot() { }

	[Address(RVA = "0x2938130", Offset = "0x2937530", Length = "0xB")]
	[Token(Token = "0x600051D")]
	public bool get_synthetic() { }

	[Address(RVA = "0x2938140", Offset = "0x2937540", Length = "0x77")]
	[Token(Token = "0x6000518")]
	public ReadOnlyArray<InternedString> get_usages() { }

	[Address(RVA = "0x29381C0", Offset = "0x29375C0", Length = "0xC")]
	[Token(Token = "0x6000548")]
	internal bool get_usesStateFromOtherControl() { }

	[Token(Token = "0x6000521")]
	public abstract int get_valueSizeInBytes() { }

	[Token(Token = "0x6000520")]
	public abstract Type get_valueType() { }

	[Address(RVA = "0x29381D0", Offset = "0x29375D0", Length = "0x1E")]
	[Token(Token = "0x6000514")]
	public string get_variants() { }

	[Address(RVA = "0x2937000", Offset = "0x2936400", Length = "0x191")]
	[Token(Token = "0x600052F")]
	public InputControl GetChildControl(string path) { }

	[Address(RVA = "0x841A40", Offset = "0x840E40", Length = "0x226")]
	[Token(Token = "0x6000530")]
	public TControl GetChildControl(string path) { }

	[Address(RVA = "0x29371A0", Offset = "0x29365A0", Length = "0x16D")]
	[Token(Token = "0x600054E")]
	internal int GetDeviceIndex() { }

	[Address(RVA = "0x2937310", Offset = "0x2936710", Length = "0xA3")]
	[Token(Token = "0x600054F")]
	internal bool IsValueConsideredPressed(float value) { }

	[Address(RVA = "0x29373C0", Offset = "0x29367C0", Length = "0x9F")]
	[Token(Token = "0x600054C")]
	internal string MakeChildPath(string path) { }

	[Address(RVA = "0x2937640", Offset = "0x2936A40", Length = "0xA")]
	[Token(Token = "0x6000551")]
	internal void MarkAsStale() { }

	[Address(RVA = "0x2937460", Offset = "0x2936860", Length = "0x1D2")]
	[Token(Token = "0x6000552")]
	internal void MarkAsStaleRecursively() { }

	[Token(Token = "0x6000527")]
	public abstract object ReadValueFromBufferAsObject(Void* buffer, int bufferSize) { }

	[Token(Token = "0x6000528")]
	public abstract object ReadValueFromStateAsObject(Void* statePtr) { }

	[Token(Token = "0x6000529")]
	public abstract void ReadValueFromStateIntoBuffer(Void* statePtr, Void* bufferPtr, int bufferSize) { }

	[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
	[Token(Token = "0x6000534")]
	protected override void RefreshConfiguration() { }

	[Address(RVA = "0x2937650", Offset = "0x2936A50", Length = "0x32")]
	[Token(Token = "0x6000533")]
	protected void RefreshConfigurationIfNeeded() { }

	[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
	[Token(Token = "0x600050F")]
	protected void set_displayName(string value) { }

	[Address(RVA = "0x29381F0", Offset = "0x29375F0", Length = "0x1F")]
	[Token(Token = "0x6000547")]
	internal void set_dontReset(bool value) { }

	[Address(RVA = "0x2938210", Offset = "0x2937610", Length = "0x1F")]
	[Token(Token = "0x6000543")]
	internal void set_isButton(bool value) { }

	[Address(RVA = "0x2938230", Offset = "0x2937630", Length = "0x1F")]
	[Token(Token = "0x6000545")]
	internal void set_isConfigUpToDate(bool value) { }

	[Address(RVA = "0x2938250", Offset = "0x2937650", Length = "0x1F")]
	[Token(Token = "0x6000541")]
	internal void set_isSetupFinished(bool value) { }

	[Address(RVA = "0x2938270", Offset = "0x2937670", Length = "0x14B")]
	[Token(Token = "0x600051C")]
	internal void set_noisy(bool value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x6000511")]
	protected void set_shortDisplayName(string value) { }

	[Address(RVA = "0x29383C0", Offset = "0x29377C0", Length = "0x1F")]
	[Token(Token = "0x600051E")]
	internal void set_synthetic(bool value) { }

	[Address(RVA = "0x29383E0", Offset = "0x29377E0", Length = "0x1F")]
	[Token(Token = "0x6000549")]
	internal void set_usesStateFromOtherControl(bool value) { }

	[Address(RVA = "0x29378E0", Offset = "0x2936CE0", Length = "0x8D")]
	[Token(Token = "0x600053D")]
	private void SetOptimizedControlDataType() { }

	[Address(RVA = "0x2937690", Offset = "0x2936A90", Length = "0x24F")]
	[Token(Token = "0x600053E")]
	internal void SetOptimizedControlDataTypeRecursively() { }

	[Address(RVA = "0x2937970", Offset = "0x2936D70", Length = "0x6A")]
	[Token(Token = "0x6000523")]
	public virtual string ToString() { }

	[Address(RVA = "0x29379E0", Offset = "0x2936DE0", Length = "0xA0")]
	[Token(Token = "0x600052D")]
	public InputControl TryGetChildControl(string path) { }

	[Address(RVA = "0x841C70", Offset = "0x841070", Length = "0x978")]
	[Token(Token = "0x600052E")]
	public TControl TryGetChildControl(string path) { }

	[Address(RVA = "0x2937A90", Offset = "0x2936E90", Length = "0x66")]
	[Token(Token = "0x600052A")]
	public override void WriteValueFromBufferIntoState(Void* bufferPtr, int bufferSize, Void* statePtr) { }

	[Address(RVA = "0x2937B00", Offset = "0x2936F00", Length = "0x66")]
	[Token(Token = "0x600052B")]
	public override void WriteValueFromObjectIntoState(object value, Void* statePtr) { }

}

