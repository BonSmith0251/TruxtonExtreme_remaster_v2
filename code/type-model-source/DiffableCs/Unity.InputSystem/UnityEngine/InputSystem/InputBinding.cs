namespace UnityEngine.InputSystem;

[Token(Token = "0x2000051")]
public struct InputBinding : IEquatable<InputBinding>
{
	[CompilerGenerated]
	[Token(Token = "0x2000055")]
	private sealed class <>c
	{
		[Token(Token = "0x400020D")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x400020E")]
		public static Func<String, Boolean> <>9__45_0; //Field offset: 0x8

		[Address(RVA = "0x29441F0", Offset = "0x29435F0", Length = "0x67")]
		[Token(Token = "0x6000407")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000408")]
		public <>c() { }

		[Address(RVA = "0x2944190", Offset = "0x2943590", Length = "0x15")]
		[Token(Token = "0x6000409")]
		internal bool <MaskByGroups>b__45_0(string x) { }

	}

	[Flags]
	[Token(Token = "0x2000052")]
	internal enum DisplayStringOptions : int
	{
		DontUseShortDisplayNames = 1,
		DontOmitDevice = 2,
		DontIncludeInteractions = 4,
		IgnoreBindingOverrides = 8,
	}

	[Flags]
	[Token(Token = "0x2000054")]
	public enum Flags : int
	{
		None = 0,
		Composite = 4,
		PartOfComposite = 8,
	}

	[Flags]
	[Token(Token = "0x2000053")]
	public enum MatchOptions : int
	{
		EmptyGroupMatchesAny = 1,
	}

	[Token(Token = "0x40001F5")]
	public const char Separator = '\u3B'; //Field offset: 0x0
	[Token(Token = "0x40001F6")]
	internal const string kSeparatorString = ";"; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x40001F7")]
	private string m_Name; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x40001F8")]
	internal string m_Id; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x40001F9")]
	[Tooltip("Path of the control to bind to. Matched at runtime to controls from InputDevices present at the time.\n\nCan either be graphically from the control picker dropdown UI or edited manually in text mode by clicking the 'T' button. Internally, both methods result in control path strings that look like, for example, \"<Gamepad>/buttonSouth\".")]
	private string m_Path; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x40001FA")]
	private string m_Interactions; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x40001FB")]
	private string m_Processors; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x40001FC")]
	internal string m_Groups; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x40001FD")]
	private string m_Action; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[Token(Token = "0x40001FE")]
	internal Flags m_Flags; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40001FF")]
	private string m_OverridePath; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000200")]
	private string m_OverrideInteractions; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000201")]
	private string m_OverrideProcessors; //Field offset: 0x50

	[Token(Token = "0x1700012E")]
	public string action
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60003EB")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60003EC")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000133")]
	public string effectiveInteractions
	{
		[Address(RVA = "0x290AE80", Offset = "0x290A280", Length = "0xE")]
		[Token(Token = "0x60003F9")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000132")]
	public string effectivePath
	{
		[Address(RVA = "0x290AE90", Offset = "0x290A290", Length = "0xE")]
		[Token(Token = "0x60003F8")]
		 get { } //Length: 14
	}

	[Token(Token = "0x17000134")]
	public string effectiveProcessors
	{
		[Address(RVA = "0x290AEA0", Offset = "0x290A2A0", Length = "0xE")]
		[Token(Token = "0x60003FA")]
		 get { } //Length: 14
	}

	[Token(Token = "0x1700012D")]
	public string groups
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60003E9")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60003EA")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000131")]
	public bool hasOverrides
	{
		[Address(RVA = "0x290AEB0", Offset = "0x290A2B0", Length = "0x1A")]
		[Token(Token = "0x60003F1")]
		 get { } //Length: 26
	}

	[Token(Token = "0x17000126")]
	public Guid id
	{
		[Address(RVA = "0x290AED0", Offset = "0x290A2D0", Length = "0x4E")]
		[Token(Token = "0x60003DB")]
		 get { } //Length: 78
		[Address(RVA = "0x290B100", Offset = "0x290A500", Length = "0x2C")]
		[Token(Token = "0x60003DC")]
		 set { } //Length: 44
	}

	[Token(Token = "0x17000129")]
	public string interactions
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60003E1")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60003E2")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700012F")]
	public bool isComposite
	{
		[Address(RVA = "0x290AF20", Offset = "0x290A320", Length = "0x9")]
		[Token(Token = "0x60003ED")]
		 get { } //Length: 9
		[Address(RVA = "0x290B130", Offset = "0x290A530", Length = "0x19")]
		[Token(Token = "0x60003EE")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000135")]
	internal bool isEmpty
	{
		[Address(RVA = "0x290AF30", Offset = "0x290A330", Length = "0x48")]
		[Token(Token = "0x60003FB")]
		internal get { } //Length: 72
	}

	[Token(Token = "0x17000130")]
	public bool isPartOfComposite
	{
		[Address(RVA = "0x290AF80", Offset = "0x290A380", Length = "0x9")]
		[Token(Token = "0x60003EF")]
		 get { } //Length: 9
		[Address(RVA = "0x290B150", Offset = "0x290A550", Length = "0x19")]
		[Token(Token = "0x60003F0")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000125")]
	public string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60003D9")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60003DA")]
		 set { } //Length: 8
	}

	[Token(Token = "0x1700012A")]
	public string overrideInteractions
	{
		[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
		[Token(Token = "0x60003E3")]
		 get { } //Length: 5
		[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
		[Token(Token = "0x60003E4")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000128")]
	public string overridePath
	{
		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[Token(Token = "0x60003DF")]
		 get { } //Length: 5
		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[Token(Token = "0x60003E0")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700012C")]
	public string overrideProcessors
	{
		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[Token(Token = "0x60003E7")]
		 get { } //Length: 5
		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[Token(Token = "0x60003E8")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000127")]
	public string path
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60003DD")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60003DE")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700012B")]
	public string processors
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60003E5")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60003E6")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x290ADB0", Offset = "0x290A1B0", Length = "0xC9")]
	[Token(Token = "0x60003F2")]
	public InputBinding(string path, string action = null, string groups = null, string processors = null, string interactions = null, string name = null) { }

	[Address(RVA = "0x290A040", Offset = "0x2909440", Length = "0xD2")]
	[Token(Token = "0x60003FD")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x290A120", Offset = "0x2909520", Length = "0xDF")]
	[Token(Token = "0x60003FC")]
	public override bool Equals(InputBinding other) { }

	[Address(RVA = "0x290A200", Offset = "0x2909600", Length = "0x47")]
	[Token(Token = "0x60003F4")]
	internal void GenerateId() { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60003EB")]
	public string get_action() { }

	[Address(RVA = "0x290AE80", Offset = "0x290A280", Length = "0xE")]
	[Token(Token = "0x60003F9")]
	public string get_effectiveInteractions() { }

	[Address(RVA = "0x290AE90", Offset = "0x290A290", Length = "0xE")]
	[Token(Token = "0x60003F8")]
	public string get_effectivePath() { }

	[Address(RVA = "0x290AEA0", Offset = "0x290A2A0", Length = "0xE")]
	[Token(Token = "0x60003FA")]
	public string get_effectiveProcessors() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60003E9")]
	public string get_groups() { }

	[Address(RVA = "0x290AEB0", Offset = "0x290A2B0", Length = "0x1A")]
	[Token(Token = "0x60003F1")]
	public bool get_hasOverrides() { }

	[Address(RVA = "0x290AED0", Offset = "0x290A2D0", Length = "0x4E")]
	[Token(Token = "0x60003DB")]
	public Guid get_id() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60003E1")]
	public string get_interactions() { }

	[Address(RVA = "0x290AF20", Offset = "0x290A320", Length = "0x9")]
	[Token(Token = "0x60003ED")]
	public bool get_isComposite() { }

	[Address(RVA = "0x290AF30", Offset = "0x290A330", Length = "0x48")]
	[Token(Token = "0x60003FB")]
	internal bool get_isEmpty() { }

	[Address(RVA = "0x290AF80", Offset = "0x290A380", Length = "0x9")]
	[Token(Token = "0x60003EF")]
	public bool get_isPartOfComposite() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60003D9")]
	public string get_name() { }

	[Address(RVA = "0x5ACF40", Offset = "0x5AC340", Length = "0x5")]
	[Token(Token = "0x60003E3")]
	public string get_overrideInteractions() { }

	[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
	[Token(Token = "0x60003DF")]
	public string get_overridePath() { }

	[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
	[Token(Token = "0x60003E7")]
	public string get_overrideProcessors() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60003DD")]
	public string get_path() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60003E5")]
	public string get_processors() { }

	[Address(RVA = "0x290A250", Offset = "0x2909650", Length = "0x12B")]
	[Token(Token = "0x6000400")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x290A380", Offset = "0x2909780", Length = "0x3C")]
	[Token(Token = "0x60003F3")]
	public string GetNameOfComposite() { }

	[Address(RVA = "0x290A3C0", Offset = "0x29097C0", Length = "0x3B")]
	[Token(Token = "0x60003F6")]
	public static InputBinding MaskByGroup(string group) { }

	[Address(RVA = "0x290A400", Offset = "0x2909800", Length = "0x176")]
	[Token(Token = "0x60003F7")]
	public static InputBinding MaskByGroups(String[] groups) { }

	[Address(RVA = "0x290A5A0", Offset = "0x29099A0", Length = "0x1B0")]
	[Token(Token = "0x6000406")]
	internal bool Matches(ref InputBinding binding, MatchOptions options = 0) { }

	[Address(RVA = "0x290A580", Offset = "0x2909980", Length = "0x14")]
	[Token(Token = "0x6000405")]
	public bool Matches(InputBinding binding) { }

	[Address(RVA = "0x290AF90", Offset = "0x290A390", Length = "0x4F")]
	[Token(Token = "0x60003FE")]
	public static bool op_Equality(InputBinding left, InputBinding right) { }

	[Address(RVA = "0x290AFE0", Offset = "0x290A3E0", Length = "0x11D")]
	[Token(Token = "0x60003FF")]
	public static bool op_Inequality(InputBinding left, InputBinding right) { }

	[Address(RVA = "0x290A750", Offset = "0x2909B50", Length = "0x47")]
	[Token(Token = "0x60003F5")]
	internal void RemoveOverrides() { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60003EC")]
	public void set_action(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60003EA")]
	public void set_groups(string value) { }

	[Address(RVA = "0x290B100", Offset = "0x290A500", Length = "0x2C")]
	[Token(Token = "0x60003DC")]
	public void set_id(Guid value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60003E2")]
	public void set_interactions(string value) { }

	[Address(RVA = "0x290B130", Offset = "0x290A530", Length = "0x19")]
	[Token(Token = "0x60003EE")]
	public void set_isComposite(bool value) { }

	[Address(RVA = "0x290B150", Offset = "0x290A550", Length = "0x19")]
	[Token(Token = "0x60003F0")]
	public void set_isPartOfComposite(bool value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60003DA")]
	public void set_name(string value) { }

	[Address(RVA = "0x115C990", Offset = "0x115BD90", Length = "0xD")]
	[Token(Token = "0x60003E4")]
	public void set_overrideInteractions(string value) { }

	[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
	[Token(Token = "0x60003E0")]
	public void set_overridePath(string value) { }

	[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
	[Token(Token = "0x60003E8")]
	public void set_overrideProcessors(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60003DE")]
	public void set_path(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60003E6")]
	public void set_processors(string value) { }

	[Address(RVA = "0x290ABE0", Offset = "0x2909FE0", Length = "0x31")]
	[Token(Token = "0x6000402")]
	public string ToDisplayString(DisplayStringOptions options = 0, InputControl control = null) { }

	[Address(RVA = "0x290A7A0", Offset = "0x2909BA0", Length = "0x43F")]
	[Token(Token = "0x6000403")]
	public string ToDisplayString(out string deviceLayoutName, out string controlPath, DisplayStringOptions options = 0, InputControl control = null) { }

	[Address(RVA = "0x290AC20", Offset = "0x290A020", Length = "0x12B")]
	[Token(Token = "0x6000401")]
	public virtual string ToString() { }

	[Address(RVA = "0x290AD50", Offset = "0x290A150", Length = "0x5B")]
	[Token(Token = "0x6000404")]
	internal bool TriggersAction(InputAction action) { }

}

