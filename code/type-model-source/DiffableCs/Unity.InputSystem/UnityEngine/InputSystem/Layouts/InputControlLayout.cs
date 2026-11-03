namespace UnityEngine.InputSystem.Layouts;

[DefaultMember("Item")]
[Token(Token = "0x20001FC")]
public class InputControlLayout
{
	[CompilerGenerated]
	[Token(Token = "0x200020F")]
	private sealed class <>c
	{
		[Token(Token = "0x4000BB6")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000BB7")]
		public static Func<String, InternedString> <>9__52_0; //Field offset: 0x8
		[Token(Token = "0x4000BB8")]
		public static Func<String, InternedString> <>9__75_0; //Field offset: 0x10
		[Token(Token = "0x4000BB9")]
		public static Func<String, InternedString> <>9__75_1; //Field offset: 0x18

		[Address(RVA = "0x29204D0", Offset = "0x291F8D0", Length = "0x67")]
		[Token(Token = "0x600137C")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600137D")]
		public <>c() { }

		[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
		[Token(Token = "0x600137F")]
		internal InternedString <CreateControlItemFromMember>b__75_0(string x) { }

		[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
		[Token(Token = "0x6001380")]
		internal InternedString <CreateControlItemFromMember>b__75_1(string x) { }

		[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
		[Token(Token = "0x600137E")]
		internal InternedString <FromType>b__52_0(string x) { }

	}

	[Token(Token = "0x20001FF")]
	internal class Builder
	{
		[Token(Token = "0x2000200")]
		internal struct ControlBuilder
		{
			[CompilerGenerated]
			[Token(Token = "0x2000201")]
			private sealed class <>c
			{
				[Token(Token = "0x4000B60")]
				public static readonly <>c <>9; //Field offset: 0x0
				[Token(Token = "0x4000B61")]
				public static Func<String, InternedString> <>9__14_0; //Field offset: 0x8

				[Address(RVA = "0x2A17510", Offset = "0x2A16910", Length = "0x67")]
				[Token(Token = "0x6001346")]
				private static <>c() { }

				[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
				[Token(Token = "0x6001347")]
				public <>c() { }

				[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
				[Token(Token = "0x6001348")]
				internal InternedString <WithUsages>b__14_0(string x) { }

			}

			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000B5E")]
			internal Builder builder; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000B5F")]
			internal int index; //Field offset: 0x8

			[Address(RVA = "0x2A03700", Offset = "0x2A02B00", Length = "0x4B")]
			[Token(Token = "0x6001345")]
			public ControlBuilder AsArrayOfControlsWithSize(int arraySize) { }

			[Address(RVA = "0x2A03750", Offset = "0x2A02B50", Length = "0x65")]
			[Token(Token = "0x600133B")]
			public ControlBuilder DontReset(bool value) { }

			[Address(RVA = "0x2A037C0", Offset = "0x2A02BC0", Length = "0x65")]
			[Token(Token = "0x600133A")]
			public ControlBuilder IsNoisy(bool value) { }

			[Address(RVA = "0x2A03830", Offset = "0x2A02C30", Length = "0x65")]
			[Token(Token = "0x6001339")]
			public ControlBuilder IsSynthetic(bool value) { }

			[Address(RVA = "0x2A038A0", Offset = "0x2A02CA0", Length = "0x7F")]
			[Token(Token = "0x6001344")]
			public ControlBuilder UsingStateFrom(string path) { }

			[Address(RVA = "0x2A03920", Offset = "0x2A02D20", Length = "0x4B")]
			[Token(Token = "0x6001338")]
			public ControlBuilder WithBitOffset(uint bit) { }

			[Address(RVA = "0x2A03970", Offset = "0x2A02D70", Length = "0x4B")]
			[Token(Token = "0x6001337")]
			public ControlBuilder WithByteOffset(uint offset) { }

			[Address(RVA = "0x2A039C0", Offset = "0x2A02DC0", Length = "0x50")]
			[Token(Token = "0x6001343")]
			public ControlBuilder WithDefaultState(PrimitiveValue value) { }

			[Address(RVA = "0x2A03A20", Offset = "0x2A02E20", Length = "0x65")]
			[Token(Token = "0x6001333")]
			public ControlBuilder WithDisplayName(string displayName) { }

			[Address(RVA = "0x2A03B10", Offset = "0x2A02F10", Length = "0x4B")]
			[Token(Token = "0x6001335")]
			public ControlBuilder WithFormat(FourCC format) { }

			[Address(RVA = "0x2A03A90", Offset = "0x2A02E90", Length = "0x78")]
			[Token(Token = "0x6001336")]
			public ControlBuilder WithFormat(string format) { }

			[Address(RVA = "0x2A03B60", Offset = "0x2A02F60", Length = "0x11D")]
			[Token(Token = "0x6001334")]
			public ControlBuilder WithLayout(string layout) { }

			[Address(RVA = "0x2A03C80", Offset = "0x2A03080", Length = "0xFA")]
			[Token(Token = "0x6001341")]
			public ControlBuilder WithParameters(string parameters) { }

			[Address(RVA = "0x2A03D80", Offset = "0x2A03180", Length = "0x115")]
			[Token(Token = "0x6001342")]
			public ControlBuilder WithProcessors(string processors) { }

			[Address(RVA = "0x2A03EA0", Offset = "0x2A032A0", Length = "0xD1")]
			[Token(Token = "0x600133D")]
			public ControlBuilder WithRange(float minValue, float maxValue) { }

			[Address(RVA = "0x2A03F80", Offset = "0x2A03380", Length = "0x4B")]
			[Token(Token = "0x600133C")]
			public ControlBuilder WithSizeInBits(uint sizeInBits) { }

			[Address(RVA = "0x2A03FD0", Offset = "0x2A033D0", Length = "0x22D")]
			[Token(Token = "0x600133E")]
			public ControlBuilder WithUsages(InternedString[] usages) { }

			[Address(RVA = "0x2A04200", Offset = "0x2A03600", Length = "0x161")]
			[Token(Token = "0x600133F")]
			public ControlBuilder WithUsages(IEnumerable<String> usages) { }

			[Address(RVA = "0x2A04370", Offset = "0x2A03770", Length = "0x25")]
			[Token(Token = "0x6001340")]
			public ControlBuilder WithUsages(String[] usages) { }

		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B55")]
		private string <name>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B56")]
		private string <displayName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B57")]
		private Type <type>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B58")]
		private FourCC <stateFormat>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x2C")]
		[Token(Token = "0x4000B59")]
		private int <stateSizeInBytes>k__BackingField; //Field offset: 0x2C
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B5A")]
		private string m_ExtendsLayout; //Field offset: 0x30
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B5B")]
		private Nullable<Boolean> <updateBeforeRender>k__BackingField; //Field offset: 0x38
		[FieldOffset(Offset = "0x3C")]
		[Token(Token = "0x4000B5C")]
		private int m_ControlCount; //Field offset: 0x3C
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B5D")]
		private ControlItem[] m_Controls; //Field offset: 0x40

		[Token(Token = "0x17000592")]
		public ReadOnlyArray<ControlItem> controls
		{
			[Address(RVA = "0x2A016A0", Offset = "0x2A00AA0", Length = "0x5F")]
			[Token(Token = "0x6001328")]
			 get { } //Length: 95
		}

		[Token(Token = "0x1700058C")]
		public string displayName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600131C")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600131D")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000590")]
		public string extendsLayout
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[Token(Token = "0x6001324")]
			 get { } //Length: 5
			[Address(RVA = "0x2A01710", Offset = "0x2A00B10", Length = "0x40")]
			[Token(Token = "0x6001325")]
			 set { } //Length: 64
		}

		[Token(Token = "0x1700058B")]
		public string name
		{
			[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600131A")]
			 get { } //Length: 5
			[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600131B")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700058E")]
		public FourCC stateFormat
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001320")]
			 get { } //Length: 4
			[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001321")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700058F")]
		public int stateSizeInBytes
		{
			[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001322")]
			 get { } //Length: 4
			[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6001323")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700058D")]
		public Type type
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600131E")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600131F")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000591")]
		public Nullable<Boolean> updateBeforeRender
		{
			[Address(RVA = "0x2A01700", Offset = "0x2A00B00", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001326")]
			 get { } //Length: 5
			[Address(RVA = "0x2A01750", Offset = "0x2A00B50", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6001327")]
			 set { } //Length: 5
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6001332")]
		public Builder() { }

		[Address(RVA = "0x2A01190", Offset = "0x2A00590", Length = "0x212")]
		[Token(Token = "0x6001329")]
		public ControlBuilder AddControl(string name) { }

		[Address(RVA = "0x2A013B0", Offset = "0x2A007B0", Length = "0x250")]
		[Token(Token = "0x6001331")]
		public InputControlLayout Build() { }

		[Address(RVA = "0x2A01600", Offset = "0x2A00A00", Length = "0x44")]
		[Token(Token = "0x6001330")]
		public Builder Extend(string baseLayoutName) { }

		[Address(RVA = "0x2A016A0", Offset = "0x2A00AA0", Length = "0x5F")]
		[Token(Token = "0x6001328")]
		public ReadOnlyArray<ControlItem> get_controls() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600131C")]
		public string get_displayName() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x6001324")]
		public string get_extendsLayout() { }

		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600131A")]
		public string get_name() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001320")]
		public FourCC get_stateFormat() { }

		[Address(RVA = "0xE0D780", Offset = "0xE0CB80", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001322")]
		public int get_stateSizeInBytes() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600131E")]
		public Type get_type() { }

		[Address(RVA = "0x2A01700", Offset = "0x2A00B00", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001326")]
		public Nullable<Boolean> get_updateBeforeRender() { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600131D")]
		public void set_displayName(string value) { }

		[Address(RVA = "0x2A01710", Offset = "0x2A00B10", Length = "0x40")]
		[Token(Token = "0x6001325")]
		public void set_extendsLayout(string value) { }

		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600131B")]
		public void set_name(string value) { }

		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001321")]
		public void set_stateFormat(FourCC value) { }

		[Address(RVA = "0xE0D7E0", Offset = "0xE0CBE0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6001323")]
		public void set_stateSizeInBytes(int value) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600131F")]
		public void set_type(Type value) { }

		[Address(RVA = "0x2A01750", Offset = "0x2A00B50", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6001327")]
		public void set_updateBeforeRender(Nullable<Boolean> value) { }

		[Address(RVA = "0x65F570", Offset = "0x65E970", Length = "0x1F")]
		[Token(Token = "0x600132B")]
		public Builder WithDisplayName(string displayName) { }

		[Address(RVA = "0x2A01650", Offset = "0x2A00A50", Length = "0x7")]
		[Token(Token = "0x600132D")]
		public Builder WithFormat(FourCC format) { }

		[Address(RVA = "0x2A01660", Offset = "0x2A00A60", Length = "0x2E")]
		[Token(Token = "0x600132E")]
		public Builder WithFormat(string format) { }

		[Address(RVA = "0x65F4A0", Offset = "0x65E8A0", Length = "0x1F")]
		[Token(Token = "0x600132A")]
		public Builder WithName(string name) { }

		[Address(RVA = "0x2A01690", Offset = "0x2A00A90", Length = "0x7")]
		[Token(Token = "0x600132F")]
		public Builder WithSizeInBytes(int sizeInBytes) { }

		[Address(RVA = "0x9F0A60", Offset = "0x9EFE60", Length = "0x63")]
		[Token(Token = "0x600132C")]
		public Builder WithType() { }

	}

	[Token(Token = "0x200020D")]
	public struct Cache
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB4")]
		public Dictionary<InternedString, InputControlLayout> table; //Field offset: 0x0

		[Address(RVA = "0x2373D70", Offset = "0x2373170", Length = "0xE")]
		[Token(Token = "0x6001379")]
		public void Clear() { }

		[Address(RVA = "0x290E0D0", Offset = "0x290D4D0", Length = "0x1DF")]
		[Token(Token = "0x600137A")]
		public InputControlLayout FindOrLoadLayout(string name, bool throwIfNotFound = true) { }

	}

	[Token(Token = "0x200020E")]
	public struct CacheRefInstance : IDisposable
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BB5")]
		public bool valid; //Field offset: 0x0

		[Address(RVA = "0x290E020", Offset = "0x290D420", Length = "0xAC")]
		[Token(Token = "0x600137B")]
		public override void Dispose() { }

	}

	[Token(Token = "0x2000208")]
	public struct Collection
	{
		[CompilerGenerated]
		[Token(Token = "0x200020B")]
		private sealed class <GetBaseLayouts>d__24 : IEnumerable<InternedString>, IEnumerable, IEnumerator<InternedString>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000BAA")]
			private int <>1__state; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000BAB")]
			private InternedString <>2__current; //Field offset: 0x18
			[FieldOffset(Offset = "0x28")]
			[Token(Token = "0x4000BAC")]
			private int <>l__initialThreadId; //Field offset: 0x28
			[FieldOffset(Offset = "0x2C")]
			[Token(Token = "0x4000BAD")]
			private bool includeSelf; //Field offset: 0x2C
			[FieldOffset(Offset = "0x2D")]
			[Token(Token = "0x4000BAE")]
			public bool <>3__includeSelf; //Field offset: 0x2D
			[FieldOffset(Offset = "0x30")]
			[Token(Token = "0x4000BAF")]
			private InternedString layout; //Field offset: 0x30
			[FieldOffset(Offset = "0x40")]
			[Token(Token = "0x4000BB0")]
			public InternedString <>3__layout; //Field offset: 0x40
			[FieldOffset(Offset = "0x50")]
			[Token(Token = "0x4000BB1")]
			public Collection <>4__this; //Field offset: 0x50
			[FieldOffset(Offset = "0x90")]
			[Token(Token = "0x4000BB2")]
			public Collection <>3__<>4__this; //Field offset: 0x90

			[Token(Token = "0x17000593")]
			private override InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.Current
			{
				[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
				[DebuggerHidden]
				[Token(Token = "0x600136E")]
				private get { } //Length: 11
			}

			[Token(Token = "0x17000594")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x2920380", Offset = "0x291F780", Length = "0x45")]
				[DebuggerHidden]
				[Token(Token = "0x6001370")]
				private get { } //Length: 69
			}

			[Address(RVA = "0x113FA10", Offset = "0x113EE10", Length = "0x2E")]
			[DebuggerHidden]
			[Token(Token = "0x600136B")]
			public <GetBaseLayouts>d__24(int <>1__state) { }

			[Address(RVA = "0x2920190", Offset = "0x291F590", Length = "0xC8")]
			[Token(Token = "0x600136D")]
			private override bool MoveNext() { }

			[Address(RVA = "0x2920260", Offset = "0x291F660", Length = "0xDF")]
			[DebuggerHidden]
			[Token(Token = "0x6001371")]
			private override IEnumerator<InternedString> System.Collections.Generic.IEnumerable<UnityEngine.InputSystem.Utilities.InternedString>.GetEnumerator() { }

			[Address(RVA = "0xABEC70", Offset = "0xABE070", Length = "0xB")]
			[DebuggerHidden]
			[Token(Token = "0x600136E")]
			private override InternedString System.Collections.Generic.IEnumerator<UnityEngine.InputSystem.Utilities.InternedString>.get_Current() { }

			[Address(RVA = "0x2920260", Offset = "0x291F660", Length = "0xDF")]
			[DebuggerHidden]
			[Token(Token = "0x6001372")]
			private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

			[Address(RVA = "0x2920380", Offset = "0x291F780", Length = "0x45")]
			[DebuggerHidden]
			[Token(Token = "0x6001370")]
			private override object System.Collections.IEnumerator.get_Current() { }

			[Address(RVA = "0x2920340", Offset = "0x291F740", Length = "0x3E")]
			[DebuggerHidden]
			[Token(Token = "0x600136F")]
			private override void System.Collections.IEnumerator.Reset() { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[DebuggerHidden]
			[Token(Token = "0x600136C")]
			private override void System.IDisposable.Dispose() { }

		}

		[Token(Token = "0x2000209")]
		internal struct LayoutMatcher
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000BA6")]
			public InternedString layoutName; //Field offset: 0x0
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000BA7")]
			public InputDeviceMatcher deviceMatcher; //Field offset: 0x10

		}

		[Token(Token = "0x200020A")]
		internal struct PrecompiledLayout
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x4000BA8")]
			public Func<InputDevice> factoryMethod; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000BA9")]
			public string metadata; //Field offset: 0x8

		}

		[Token(Token = "0x4000B9D")]
		public const float kBaseScoreForNonGeneratedLayouts = 1; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B9E")]
		public Dictionary<InternedString, Type> layoutTypes; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B9F")]
		public Dictionary<InternedString, String> layoutStrings; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BA0")]
		public Dictionary<InternedString, Func`1<InputControlLayout>> layoutBuilders; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BA1")]
		public Dictionary<InternedString, InternedString> baseLayoutTable; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BA2")]
		public Dictionary<InternedString, InternedString[]> layoutOverrides; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BA3")]
		public HashSet<InternedString> layoutOverrideNames; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BA4")]
		public Dictionary<InternedString, PrecompiledLayout> precompiledLayouts; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000BA5")]
		public List<LayoutMatcher> layoutMatchers; //Field offset: 0x38

		[Address(RVA = "0x2A01850", Offset = "0x2A00C50", Length = "0x1C6")]
		[Token(Token = "0x600136A")]
		public void AddMatcher(InternedString layout, InputDeviceMatcher matcher) { }

		[Address(RVA = "0x2A01A20", Offset = "0x2A00E20", Length = "0x259")]
		[Token(Token = "0x600135B")]
		public void Allocate() { }

		[Address(RVA = "0x2A01C80", Offset = "0x2A01080", Length = "0x240")]
		[Token(Token = "0x6001363")]
		public bool ComputeDistanceInInheritanceHierarchy(InternedString firstLayout, InternedString secondLayout, out int distance) { }

		[Address(RVA = "0x2A01ED0", Offset = "0x2A012D0", Length = "0x203")]
		[Token(Token = "0x6001364")]
		public InternedString FindLayoutThatIntroducesControl(InputControl control, Cache cache) { }

		[Address(RVA = "0x2A020E0", Offset = "0x2A014E0", Length = "0x9D")]
		[Token(Token = "0x6001361")]
		public InternedString GetBaseLayoutName(InternedString layoutName) { }

		[Address(RVA = "0x2A02180", Offset = "0x2A01580", Length = "0xCB")]
		[IteratorStateMachine(typeof(<GetBaseLayouts>d__24))]
		[Token(Token = "0x6001368")]
		public IEnumerable<InternedString> GetBaseLayouts(InternedString layout, bool includeSelf = true) { }

		[Address(RVA = "0x2A02250", Offset = "0x2A01650", Length = "0x13E")]
		[Token(Token = "0x6001365")]
		public Type GetControlTypeForLayout(InternedString layoutName) { }

		[Address(RVA = "0x2A02390", Offset = "0x2A01790", Length = "0xA6")]
		[Token(Token = "0x6001362")]
		public InternedString GetRootLayoutName(InternedString layoutName) { }

		[Address(RVA = "0x2A02440", Offset = "0x2A01840", Length = "0xCE")]
		[Token(Token = "0x600135E")]
		public bool HasLayout(InternedString name) { }

		[Address(RVA = "0x2A02510", Offset = "0x2A01910", Length = "0xC2")]
		[Token(Token = "0x6001369")]
		public bool IsBasedOn(InternedString parentLayout, InternedString childLayout) { }

		[Address(RVA = "0x2A025E0", Offset = "0x2A019E0", Length = "0x5E")]
		[Token(Token = "0x6001367")]
		public bool IsGeneratedLayout(InternedString layout) { }

		[Address(RVA = "0x2A02640", Offset = "0x2A01A40", Length = "0x1A7")]
		[Token(Token = "0x600135C")]
		public InternedString TryFindLayoutForType(Type layoutType) { }

		[Address(RVA = "0x2A027F0", Offset = "0x2A01BF0", Length = "0x21F")]
		[Token(Token = "0x600135D")]
		public InternedString TryFindMatchingLayout(InputDeviceDescription deviceDescription) { }

		[Address(RVA = "0x2A02CA0", Offset = "0x2A020A0", Length = "0x448")]
		[Token(Token = "0x6001360")]
		public InputControlLayout TryLoadLayout(InternedString name, Dictionary<InternedString, InputControlLayout> table = null) { }

		[Address(RVA = "0x2A02A10", Offset = "0x2A01E10", Length = "0x28E")]
		[Token(Token = "0x600135F")]
		private InputControlLayout TryLoadLayoutInternal(InternedString name) { }

		[Address(RVA = "0x2A030F0", Offset = "0x2A024F0", Length = "0x105")]
		[Token(Token = "0x6001366")]
		public bool ValueTypeIsAssignableFrom(InternedString layoutName, Type valueType) { }

	}

	[Token(Token = "0x20001FD")]
	internal struct ControlItem
	{
		[Flags]
		[Token(Token = "0x20001FE")]
		private enum Flags : int
		{
			isModifyingExistingControl = 1,
			IsNoisy = 2,
			IsSynthetic = 4,
			IsFirstDefinedInThisLayout = 8,
			DontReset = 16,
		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B3C")]
		private InternedString <name>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B3D")]
		private InternedString <layout>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B3E")]
		private InternedString <variants>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B3F")]
		private string <useStateFrom>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B40")]
		private string <displayName>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B41")]
		private string <shortDisplayName>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B42")]
		private ReadOnlyArray<InternedString> <usages>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B43")]
		private ReadOnlyArray<InternedString> <aliases>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000B44")]
		private ReadOnlyArray<NamedValue> <parameters>k__BackingField; //Field offset: 0x68
		[CompilerGenerated]
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000B45")]
		private ReadOnlyArray<NameAndParameters> <processors>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000B46")]
		private uint <offset>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		[FieldOffset(Offset = "0x8C")]
		[Token(Token = "0x4000B47")]
		private uint <bit>k__BackingField; //Field offset: 0x8C
		[CompilerGenerated]
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000B48")]
		private uint <sizeInBits>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		[FieldOffset(Offset = "0x94")]
		[Token(Token = "0x4000B49")]
		private FourCC <format>k__BackingField; //Field offset: 0x94
		[CompilerGenerated]
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000B4A")]
		private Flags <flags>k__BackingField; //Field offset: 0x98
		[CompilerGenerated]
		[FieldOffset(Offset = "0x9C")]
		[Token(Token = "0x4000B4B")]
		private int <arraySize>k__BackingField; //Field offset: 0x9C
		[CompilerGenerated]
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000B4C")]
		private PrimitiveValue <defaultState>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000B4D")]
		private PrimitiveValue <minValue>k__BackingField; //Field offset: 0xB0
		[CompilerGenerated]
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000B4E")]
		private PrimitiveValue <maxValue>k__BackingField; //Field offset: 0xC0

		[Token(Token = "0x17000579")]
		public internal ReadOnlyArray<InternedString> aliases
		{
			[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012F6")]
			 get { } //Length: 11
			[Address(RVA = "0x2A057D0", Offset = "0x2A04BD0", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012F7")]
			internal set { } //Length: 18
		}

		[Token(Token = "0x17000581")]
		public internal int arraySize
		{
			[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001306")]
			 get { } //Length: 7
			[Address(RVA = "0x2A057F0", Offset = "0x2A04BF0", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001307")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x1700057D")]
		public internal uint bit
		{
			[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012FE")]
			 get { } //Length: 7
			[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60012FF")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x17000582")]
		public internal PrimitiveValue defaultState
		{
			[Address(RVA = "0x2A05740", Offset = "0x2A04B40", Length = "0xE")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001308")]
			 get { } //Length: 14
			[Address(RVA = "0x2A05800", Offset = "0x2A04C00", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x6001309")]
			internal set { } //Length: 11
		}

		[Token(Token = "0x17000576")]
		public internal string displayName
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012F0")]
			 get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60012F1")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x17000588")]
		public internal bool dontReset
		{
			[Address(RVA = "0x2A05750", Offset = "0x2A04B50", Length = "0xC")]
			[Token(Token = "0x6001314")]
			 get { } //Length: 12
			[Address(RVA = "0x2A05810", Offset = "0x2A04C10", Length = "0x1F")]
			[Token(Token = "0x6001315")]
			internal set { } //Length: 31
		}

		[Token(Token = "0x17000580")]
		private Flags flags
		{
			[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001304")]
			private get { } //Length: 7
			[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001305")]
			private set { } //Length: 7
		}

		[Token(Token = "0x1700057F")]
		public internal FourCC format
		{
			[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001302")]
			 get { } //Length: 7
			[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001303")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x1700058A")]
		public bool isArray
		{
			[Address(RVA = "0x2A05760", Offset = "0x2A04B60", Length = "0xB")]
			[Token(Token = "0x6001318")]
			 get { } //Length: 11
		}

		[Token(Token = "0x17000589")]
		public internal bool isFirstDefinedInThisLayout
		{
			[Address(RVA = "0x2A05770", Offset = "0x2A04B70", Length = "0xB")]
			[Token(Token = "0x6001316")]
			 get { } //Length: 11
			[Address(RVA = "0x2A05830", Offset = "0x2A04C30", Length = "0x1F")]
			[Token(Token = "0x6001317")]
			internal set { } //Length: 31
		}

		[Token(Token = "0x17000585")]
		public internal bool isModifyingExistingControl
		{
			[Address(RVA = "0x2A05780", Offset = "0x2A04B80", Length = "0xA")]
			[Token(Token = "0x600130E")]
			 get { } //Length: 10
			[Address(RVA = "0x2A05850", Offset = "0x2A04C50", Length = "0x1F")]
			[Token(Token = "0x600130F")]
			internal set { } //Length: 31
		}

		[Token(Token = "0x17000586")]
		public internal bool isNoisy
		{
			[Address(RVA = "0x2A05790", Offset = "0x2A04B90", Length = "0xB")]
			[Token(Token = "0x6001310")]
			 get { } //Length: 11
			[Address(RVA = "0x2A05870", Offset = "0x2A04C70", Length = "0x1F")]
			[Token(Token = "0x6001311")]
			internal set { } //Length: 31
		}

		[Token(Token = "0x17000587")]
		public internal bool isSynthetic
		{
			[Address(RVA = "0x2A057A0", Offset = "0x2A04BA0", Length = "0xC")]
			[Token(Token = "0x6001312")]
			 get { } //Length: 12
			[Address(RVA = "0x2A05890", Offset = "0x2A04C90", Length = "0x1F")]
			[Token(Token = "0x6001313")]
			internal set { } //Length: 31
		}

		[Token(Token = "0x17000573")]
		public internal InternedString layout
		{
			[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012EA")]
			 get { } //Length: 11
			[Address(RVA = "0xD99E80", Offset = "0xD99280", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012EB")]
			internal set { } //Length: 18
		}

		[Token(Token = "0x17000584")]
		public internal PrimitiveValue maxValue
		{
			[Address(RVA = "0x2A057B0", Offset = "0x2A04BB0", Length = "0xE")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600130C")]
			 get { } //Length: 14
			[Address(RVA = "0x2A058B0", Offset = "0x2A04CB0", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x600130D")]
			internal set { } //Length: 11
		}

		[Token(Token = "0x17000583")]
		public internal PrimitiveValue minValue
		{
			[Address(RVA = "0x2A057C0", Offset = "0x2A04BC0", Length = "0xE")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x600130A")]
			 get { } //Length: 14
			[Address(RVA = "0x2A058C0", Offset = "0x2A04CC0", Length = "0xB")]
			[CompilerGenerated]
			[Token(Token = "0x600130B")]
			internal set { } //Length: 11
		}

		[Token(Token = "0x17000572")]
		public internal InternedString name
		{
			[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012E8")]
			 get { } //Length: 10
			[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60012E9")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x1700057C")]
		public internal uint offset
		{
			[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012FC")]
			 get { } //Length: 7
			[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x60012FD")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x1700057A")]
		public internal ReadOnlyArray<NamedValue> parameters
		{
			[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012F8")]
			 get { } //Length: 11
			[Address(RVA = "0x121E6C0", Offset = "0x121DAC0", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012F9")]
			internal set { } //Length: 18
		}

		[Token(Token = "0x1700057B")]
		public internal ReadOnlyArray<NameAndParameters> processors
		{
			[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012FA")]
			 get { } //Length: 11
			[Address(RVA = "0x2A058D0", Offset = "0x2A04CD0", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012FB")]
			internal set { } //Length: 18
		}

		[Token(Token = "0x17000577")]
		public internal string shortDisplayName
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012F2")]
			 get { } //Length: 5
			[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60012F3")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x1700057E")]
		public internal uint sizeInBits
		{
			[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x6001300")]
			 get { } //Length: 7
			[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
			[CompilerGenerated]
			[Token(Token = "0x6001301")]
			internal set { } //Length: 7
		}

		[Token(Token = "0x17000578")]
		public internal ReadOnlyArray<InternedString> usages
		{
			[Address(RVA = "0x215EF10", Offset = "0x215E310", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012F4")]
			 get { } //Length: 11
			[Address(RVA = "0x2A058F0", Offset = "0x2A04CF0", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012F5")]
			internal set { } //Length: 18
		}

		[Token(Token = "0x17000575")]
		public internal string useStateFrom
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012EE")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60012EF")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x17000574")]
		public internal InternedString variants
		{
			[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
			[CompilerGenerated]
			[IsReadOnly]
			[Token(Token = "0x60012EC")]
			 get { } //Length: 11
			[Address(RVA = "0x2A05910", Offset = "0x2A04D10", Length = "0x12")]
			[CompilerGenerated]
			[Token(Token = "0x60012ED")]
			internal set { } //Length: 18
		}

		[Address(RVA = "0x2A05730", Offset = "0x2A04B30", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012F6")]
		public ReadOnlyArray<InternedString> get_aliases() { }

		[Address(RVA = "0x25E2B40", Offset = "0x25E1F40", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001306")]
		public int get_arraySize() { }

		[Address(RVA = "0xD11AE0", Offset = "0xD10EE0", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012FE")]
		public uint get_bit() { }

		[Address(RVA = "0x2A05740", Offset = "0x2A04B40", Length = "0xE")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001308")]
		public PrimitiveValue get_defaultState() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012F0")]
		public string get_displayName() { }

		[Address(RVA = "0x2A05750", Offset = "0x2A04B50", Length = "0xC")]
		[Token(Token = "0x6001314")]
		public bool get_dontReset() { }

		[Address(RVA = "0xE269D0", Offset = "0xE25DD0", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001304")]
		private Flags get_flags() { }

		[Address(RVA = "0xE268E0", Offset = "0xE25CE0", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001302")]
		public FourCC get_format() { }

		[Address(RVA = "0x2A05760", Offset = "0x2A04B60", Length = "0xB")]
		[Token(Token = "0x6001318")]
		public bool get_isArray() { }

		[Address(RVA = "0x2A05770", Offset = "0x2A04B70", Length = "0xB")]
		[Token(Token = "0x6001316")]
		public bool get_isFirstDefinedInThisLayout() { }

		[Address(RVA = "0x2A05780", Offset = "0x2A04B80", Length = "0xA")]
		[Token(Token = "0x600130E")]
		public bool get_isModifyingExistingControl() { }

		[Address(RVA = "0x2A05790", Offset = "0x2A04B90", Length = "0xB")]
		[Token(Token = "0x6001310")]
		public bool get_isNoisy() { }

		[Address(RVA = "0x2A057A0", Offset = "0x2A04BA0", Length = "0xC")]
		[Token(Token = "0x6001312")]
		public bool get_isSynthetic() { }

		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012EA")]
		public InternedString get_layout() { }

		[Address(RVA = "0x2A057B0", Offset = "0x2A04BB0", Length = "0xE")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600130C")]
		public PrimitiveValue get_maxValue() { }

		[Address(RVA = "0x2A057C0", Offset = "0x2A04BC0", Length = "0xE")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x600130A")]
		public PrimitiveValue get_minValue() { }

		[Address(RVA = "0x883620", Offset = "0x882A20", Length = "0xA")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012E8")]
		public InternedString get_name() { }

		[Address(RVA = "0xD11A40", Offset = "0xD10E40", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012FC")]
		public uint get_offset() { }

		[Address(RVA = "0x121E520", Offset = "0x121D920", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012F8")]
		public ReadOnlyArray<NamedValue> get_parameters() { }

		[Address(RVA = "0x16D0810", Offset = "0x16CFC10", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012FA")]
		public ReadOnlyArray<NameAndParameters> get_processors() { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012F2")]
		public string get_shortDisplayName() { }

		[Address(RVA = "0x1CCF5C0", Offset = "0x1CCE9C0", Length = "0x7")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x6001300")]
		public uint get_sizeInBits() { }

		[Address(RVA = "0x215EF10", Offset = "0x215E310", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012F4")]
		public ReadOnlyArray<InternedString> get_usages() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012EE")]
		public string get_useStateFrom() { }

		[Address(RVA = "0xF53F00", Offset = "0xF53300", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60012EC")]
		public InternedString get_variants() { }

		[Address(RVA = "0x2A05370", Offset = "0x2A04770", Length = "0x3BD")]
		[Token(Token = "0x6001319")]
		public ControlItem Merge(ControlItem other) { }

		[Address(RVA = "0x2A057D0", Offset = "0x2A04BD0", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012F7")]
		internal void set_aliases(ReadOnlyArray<InternedString> value) { }

		[Address(RVA = "0x2A057F0", Offset = "0x2A04BF0", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001307")]
		internal void set_arraySize(int value) { }

		[Address(RVA = "0xD11C60", Offset = "0xD11060", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60012FF")]
		internal void set_bit(uint value) { }

		[Address(RVA = "0x2A05800", Offset = "0x2A04C00", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x6001309")]
		internal void set_defaultState(PrimitiveValue value) { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012F1")]
		internal void set_displayName(string value) { }

		[Address(RVA = "0x2A05810", Offset = "0x2A04C10", Length = "0x1F")]
		[Token(Token = "0x6001315")]
		internal void set_dontReset(bool value) { }

		[Address(RVA = "0xE26E30", Offset = "0xE26230", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001305")]
		private void set_flags(Flags value) { }

		[Address(RVA = "0xE26C10", Offset = "0xE26010", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001303")]
		internal void set_format(FourCC value) { }

		[Address(RVA = "0x2A05830", Offset = "0x2A04C30", Length = "0x1F")]
		[Token(Token = "0x6001317")]
		internal void set_isFirstDefinedInThisLayout(bool value) { }

		[Address(RVA = "0x2A05850", Offset = "0x2A04C50", Length = "0x1F")]
		[Token(Token = "0x600130F")]
		internal void set_isModifyingExistingControl(bool value) { }

		[Address(RVA = "0x2A05870", Offset = "0x2A04C70", Length = "0x1F")]
		[Token(Token = "0x6001311")]
		internal void set_isNoisy(bool value) { }

		[Address(RVA = "0x2A05890", Offset = "0x2A04C90", Length = "0x1F")]
		[Token(Token = "0x6001313")]
		internal void set_isSynthetic(bool value) { }

		[Address(RVA = "0xD99E80", Offset = "0xD99280", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012EB")]
		internal void set_layout(InternedString value) { }

		[Address(RVA = "0x2A058B0", Offset = "0x2A04CB0", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x600130D")]
		internal void set_maxValue(PrimitiveValue value) { }

		[Address(RVA = "0x2A058C0", Offset = "0x2A04CC0", Length = "0xB")]
		[CompilerGenerated]
		[Token(Token = "0x600130B")]
		internal void set_minValue(PrimitiveValue value) { }

		[Address(RVA = "0x120FC40", Offset = "0x120F040", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012E9")]
		internal void set_name(InternedString value) { }

		[Address(RVA = "0xD11B00", Offset = "0xD10F00", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x60012FD")]
		internal void set_offset(uint value) { }

		[Address(RVA = "0x121E6C0", Offset = "0x121DAC0", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012F9")]
		internal void set_parameters(ReadOnlyArray<NamedValue> value) { }

		[Address(RVA = "0x2A058D0", Offset = "0x2A04CD0", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012FB")]
		internal void set_processors(ReadOnlyArray<NameAndParameters> value) { }

		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012F3")]
		internal void set_shortDisplayName(string value) { }

		[Address(RVA = "0x1E26130", Offset = "0x1E25530", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6001301")]
		internal void set_sizeInBits(uint value) { }

		[Address(RVA = "0x2A058F0", Offset = "0x2A04CF0", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012F5")]
		internal void set_usages(ReadOnlyArray<InternedString> value) { }

		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60012EF")]
		internal void set_useStateFrom(string value) { }

		[Address(RVA = "0x2A05910", Offset = "0x2A04D10", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60012ED")]
		internal void set_variants(InternedString value) { }

	}

	[Token(Token = "0x2000206")]
	private class ControlItemJson
	{
		[CompilerGenerated]
		[Token(Token = "0x2000207")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B96")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000B97")]
			public static Func<String, InternedString> <>9__24_0; //Field offset: 0x8
			[Token(Token = "0x4000B98")]
			public static Func<String, InternedString> <>9__24_1; //Field offset: 0x10
			[Token(Token = "0x4000B99")]
			public static Func<NamedValue, String> <>9__25_0; //Field offset: 0x18
			[Token(Token = "0x4000B9A")]
			public static Func<NameAndParameters, String> <>9__25_1; //Field offset: 0x20
			[Token(Token = "0x4000B9B")]
			public static Func<InternedString, String> <>9__25_2; //Field offset: 0x28
			[Token(Token = "0x4000B9C")]
			public static Func<InternedString, String> <>9__25_3; //Field offset: 0x30

			[Address(RVA = "0x2A17430", Offset = "0x2A16830", Length = "0x67")]
			[Token(Token = "0x6001353")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001354")]
			public <>c() { }

			[Address(RVA = "0x292B170", Offset = "0x292A570", Length = "0x13")]
			[Token(Token = "0x6001357")]
			internal string <FromControlItems>b__25_0(NamedValue x) { }

			[Address(RVA = "0x292B080", Offset = "0x292A480", Length = "0x13")]
			[Token(Token = "0x6001358")]
			internal string <FromControlItems>b__25_1(NameAndParameters x) { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x6001359")]
			internal string <FromControlItems>b__25_2(InternedString x) { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x600135A")]
			internal string <FromControlItems>b__25_3(InternedString x) { }

			[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
			[Token(Token = "0x6001355")]
			internal InternedString <ToLayout>b__24_0(string x) { }

			[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
			[Token(Token = "0x6001356")]
			internal InternedString <ToLayout>b__24_1(string x) { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B7F")]
		public string name; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B80")]
		public string layout; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B81")]
		public string variants; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B82")]
		public string usage; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B83")]
		public string alias; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B84")]
		public string useStateFrom; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B85")]
		public uint offset; //Field offset: 0x40
		[FieldOffset(Offset = "0x44")]
		[Token(Token = "0x4000B86")]
		public uint bit; //Field offset: 0x44
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B87")]
		public uint sizeInBits; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B88")]
		public string format; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B89")]
		public int arraySize; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000B8A")]
		public String[] usages; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000B8B")]
		public String[] aliases; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000B8C")]
		public string parameters; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000B8D")]
		public string processors; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000B8E")]
		public string displayName; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000B8F")]
		public string shortDisplayName; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000B90")]
		public bool noisy; //Field offset: 0x90
		[FieldOffset(Offset = "0x91")]
		[Token(Token = "0x4000B91")]
		public bool dontReset; //Field offset: 0x91
		[FieldOffset(Offset = "0x92")]
		[Token(Token = "0x4000B92")]
		public bool synthetic; //Field offset: 0x92
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000B93")]
		public string defaultState; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000B94")]
		public string minValue; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000B95")]
		public string maxValue; //Field offset: 0xA8

		[Address(RVA = "0x2A05350", Offset = "0x2A04750", Length = "0x1E")]
		[Token(Token = "0x6001350")]
		public ControlItemJson() { }

		[Address(RVA = "0x2A043A0", Offset = "0x2A037A0", Length = "0x87A")]
		[Token(Token = "0x6001352")]
		public static ControlItemJson[] FromControlItems(ControlItem[] items) { }

		[Address(RVA = "0x2A04C20", Offset = "0x2A04020", Length = "0x72C")]
		[Token(Token = "0x6001351")]
		public ControlItem ToLayout() { }

	}

	[Flags]
	[Token(Token = "0x2000202")]
	private enum Flags : int
	{
		IsGenericTypeOfDevice = 1,
		HideInUI = 2,
		IsOverride = 4,
		CanRunInBackground = 8,
		CanRunInBackgroundIsSet = 16,
		IsNoisy = 32,
	}

	[Token(Token = "0x2000204")]
	private struct LayoutJson
	{
		[CompilerGenerated]
		[Token(Token = "0x2000205")]
		private sealed class <>c
		{
			[Token(Token = "0x4000B7B")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000B7C")]
			public static Func<String, InternedString> <>9__14_0; //Field offset: 0x8
			[Token(Token = "0x4000B7D")]
			public static Func<InternedString, String> <>9__15_0; //Field offset: 0x10
			[Token(Token = "0x4000B7E")]
			public static Func<InternedString, String> <>9__15_1; //Field offset: 0x18

			[Address(RVA = "0x2A174A0", Offset = "0x2A168A0", Length = "0x67")]
			[Token(Token = "0x600134B")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600134C")]
			public <>c() { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x600134E")]
			internal string <FromLayout>b__15_0(InternedString x) { }

			[Address(RVA = "0x292B190", Offset = "0x292A590", Length = "0x13")]
			[Token(Token = "0x600134F")]
			internal string <FromLayout>b__15_1(InternedString x) { }

			[Address(RVA = "0x29203D0", Offset = "0x291F7D0", Length = "0x23")]
			[Token(Token = "0x600134D")]
			internal InternedString <ToLayout>b__14_0(string x) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B6D")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B6E")]
		public string extend; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B6F")]
		public String[] extendMultiple; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B70")]
		public string format; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000B71")]
		public string beforeRender; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000B72")]
		public string runInBackground; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000B73")]
		public String[] commonUsages; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000B74")]
		public string displayName; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000B75")]
		public string description; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000B76")]
		public string type; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000B77")]
		public string variant; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000B78")]
		public bool isGenericTypeOfDevice; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4000B79")]
		public bool hideInUI; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000B7A")]
		public ControlItemJson[] controls; //Field offset: 0x60

		[Address(RVA = "0x2A11BA0", Offset = "0x2A10FA0", Length = "0x412")]
		[Token(Token = "0x600134A")]
		public static LayoutJson FromLayout(InputControlLayout layout) { }

		[Address(RVA = "0x2A11FC0", Offset = "0x2A113C0", Length = "0xAB4")]
		[Token(Token = "0x6001349")]
		public InputControlLayout ToLayout() { }

	}

	[Token(Token = "0x2000203")]
	public struct LayoutJsonNameAndDescriptorOnly
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000B69")]
		public string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000B6A")]
		public string extend; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000B6B")]
		public String[] extendMultiple; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000B6C")]
		public MatcherJson device; //Field offset: 0x18

	}

	[Token(Token = "0x200020C")]
	internal class LayoutNotFoundException : Exception
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000BB3")]
		private readonly string <layout>k__BackingField; //Field offset: 0x90

		[Token(Token = "0x17000595")]
		public string layout
		{
			[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6001373")]
			 get { } //Length: 8
		}

		[Address(RVA = "0x291D4F0", Offset = "0x291C8F0", Length = "0x49")]
		[Token(Token = "0x6001374")]
		public LayoutNotFoundException() { }

		[Address(RVA = "0x291D660", Offset = "0x291CA60", Length = "0x7C")]
		[Token(Token = "0x6001375")]
		public LayoutNotFoundException(string name, string message) { }

		[Address(RVA = "0x291D540", Offset = "0x291C940", Length = "0xAD")]
		[Token(Token = "0x6001376")]
		public LayoutNotFoundException(string name) { }

		[Address(RVA = "0x291D5F0", Offset = "0x291C9F0", Length = "0x69")]
		[Token(Token = "0x6001377")]
		public LayoutNotFoundException(string message, Exception innerException) { }

		[Address(RVA = "0x291D6E0", Offset = "0x291CAE0", Length = "0x74")]
		[Token(Token = "0x6001378")]
		protected LayoutNotFoundException(SerializationInfo info, StreamingContext context) { }

		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6001373")]
		public string get_layout() { }

	}

	[Token(Token = "0x4000B2A")]
	private static InternedString s_DefaultVariant; //Field offset: 0x0
	[Token(Token = "0x4000B2B")]
	public const string VariantSeparator = ";"; //Field offset: 0x0
	[Token(Token = "0x4000B39")]
	internal static Collection s_Layouts; //Field offset: 0x10
	[Token(Token = "0x4000B3A")]
	internal static Cache s_CacheInstance; //Field offset: 0x50
	[Token(Token = "0x4000B3B")]
	internal static int s_CacheInstanceRef; //Field offset: 0x58
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000B2C")]
	private InternedString m_Name; //Field offset: 0x10
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000B2D")]
	private Type m_Type; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000B2E")]
	private InternedString m_Variants; //Field offset: 0x28
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000B2F")]
	private FourCC m_StateFormat; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000B30")]
	internal int m_StateSizeInBytes; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000B31")]
	internal Nullable<Boolean> m_UpdateBeforeRender; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000B32")]
	internal InlinedArray<InternedString> m_BaseLayouts; //Field offset: 0x48
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000B33")]
	private InlinedArray<InternedString> m_AppliedOverrides; //Field offset: 0x68
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000B34")]
	private InternedString[] m_CommonUsages; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000B35")]
	internal ControlItem[] m_Controls; //Field offset: 0x90
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000B36")]
	internal string m_DisplayName; //Field offset: 0x98
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000B37")]
	private string m_Description; //Field offset: 0xA0
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000B38")]
	private Flags m_Flags; //Field offset: 0xA8

	[Token(Token = "0x17000565")]
	public IEnumerable<InternedString> appliedOverrides
	{
		[Address(RVA = "0x2A0A980", Offset = "0x2A09D80", Length = "0x4E")]
		[Token(Token = "0x60012C0")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000564")]
	public IEnumerable<InternedString> baseLayouts
	{
		[Address(RVA = "0x2A0A9D0", Offset = "0x2A09DD0", Length = "0x4E")]
		[Token(Token = "0x60012BF")]
		 get { } //Length: 78
	}

	[Token(Token = "0x17000571")]
	internal static Cache cache
	{
		[Address(RVA = "0x2A0AA20", Offset = "0x2A09E20", Length = "0x4F")]
		[Token(Token = "0x60012E4")]
		internal get { } //Length: 79
	}

	[Token(Token = "0x1700056F")]
	public internal Nullable<Boolean> canRunInBackground
	{
		[Address(RVA = "0x2A0AA70", Offset = "0x2A09E70", Length = "0x5B")]
		[Token(Token = "0x60012CE")]
		 get { } //Length: 91
		[Address(RVA = "0x2A0AD50", Offset = "0x2A0A150", Length = "0x95")]
		[Token(Token = "0x60012CF")]
		internal set { } //Length: 149
	}

	[Token(Token = "0x17000566")]
	public ReadOnlyArray<InternedString> commonUsages
	{
		[Address(RVA = "0x2A0AAD0", Offset = "0x2A09ED0", Length = "0x56")]
		[Token(Token = "0x60012C1")]
		 get { } //Length: 86
	}

	[Token(Token = "0x17000567")]
	public ReadOnlyArray<ControlItem> controls
	{
		[Address(RVA = "0x2A0AB30", Offset = "0x2A09F30", Length = "0x56")]
		[Token(Token = "0x60012C2")]
		 get { } //Length: 86
	}

	[Token(Token = "0x1700055D")]
	public static InternedString DefaultVariant
	{
		[Address(RVA = "0x2A0A760", Offset = "0x2A09B60", Length = "0x5A")]
		[Token(Token = "0x60012B8")]
		 get { } //Length: 90
	}

	[Token(Token = "0x1700055F")]
	public string displayName
	{
		[Address(RVA = "0x2A0AB90", Offset = "0x2A09F90", Length = "0x2A")]
		[Token(Token = "0x60012BA")]
		 get { } //Length: 42
	}

	[Token(Token = "0x1700056D")]
	public internal bool hideInUI
	{
		[Address(RVA = "0x2A0ABC0", Offset = "0x2A09FC0", Length = "0xB")]
		[Token(Token = "0x60012CA")]
		 get { } //Length: 11
		[Address(RVA = "0x2A0ADF0", Offset = "0x2A0A1F0", Length = "0x1F")]
		[Token(Token = "0x60012CB")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700056A")]
	public bool isControlLayout
	{
		[Address(RVA = "0x2A0ABD0", Offset = "0x2A09FD0", Length = "0x84")]
		[Token(Token = "0x60012C5")]
		 get { } //Length: 132
	}

	[Token(Token = "0x17000569")]
	public bool isDeviceLayout
	{
		[Address(RVA = "0x2A0AC60", Offset = "0x2A0A060", Length = "0x7E")]
		[Token(Token = "0x60012C4")]
		 get { } //Length: 126
	}

	[Token(Token = "0x1700056C")]
	public internal bool isGenericTypeOfDevice
	{
		[Address(RVA = "0x2A0ACE0", Offset = "0x2A0A0E0", Length = "0xA")]
		[Token(Token = "0x60012C8")]
		 get { } //Length: 10
		[Address(RVA = "0x2A0AE10", Offset = "0x2A0A210", Length = "0x1F")]
		[Token(Token = "0x60012C9")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700056E")]
	public internal bool isNoisy
	{
		[Address(RVA = "0x2A0ACF0", Offset = "0x2A0A0F0", Length = "0xB")]
		[Token(Token = "0x60012CC")]
		 get { } //Length: 11
		[Address(RVA = "0x2A0AE30", Offset = "0x2A0A230", Length = "0x1F")]
		[Token(Token = "0x60012CD")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x1700056B")]
	public internal bool isOverride
	{
		[Address(RVA = "0x2A0AD00", Offset = "0x2A0A100", Length = "0xB")]
		[Token(Token = "0x60012C6")]
		 get { } //Length: 11
		[Address(RVA = "0x2A0AE50", Offset = "0x2A0A250", Length = "0x1F")]
		[Token(Token = "0x60012C7")]
		internal set { } //Length: 31
	}

	[Token(Token = "0x17000570")]
	public ControlItem Item
	{
		[Address(RVA = "0x2A0A7C0", Offset = "0x2A09BC0", Length = "0x1BB")]
		[Token(Token = "0x60012D0")]
		 get { } //Length: 443
	}

	[Token(Token = "0x1700055E")]
	public InternedString name
	{
		[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
		[Token(Token = "0x60012B9")]
		 get { } //Length: 11
	}

	[Token(Token = "0x17000562")]
	public FourCC stateFormat
	{
		[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
		[Token(Token = "0x60012BD")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000563")]
	public int stateSizeInBytes
	{
		[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
		[Token(Token = "0x60012BE")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000560")]
	public Type type
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60012BB")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000568")]
	public bool updateBeforeRender
	{
		[Address(RVA = "0x2A0AD10", Offset = "0x2A0A110", Length = "0x39")]
		[Token(Token = "0x60012C3")]
		 get { } //Length: 57
	}

	[Token(Token = "0x17000561")]
	public InternedString variants
	{
		[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
		[Token(Token = "0x60012BC")]
		 get { } //Length: 11
	}

	[Address(RVA = "0x2A0A670", Offset = "0x2A09A70", Length = "0x78")]
	[Token(Token = "0x60012E6")]
	private static InputControlLayout() { }

	[Address(RVA = "0x2A0A6F0", Offset = "0x2A09AF0", Length = "0x6B")]
	[Token(Token = "0x60012D7")]
	private InputControlLayout(string name, Type type) { }

	[Address(RVA = "0x2A0A430", Offset = "0x2A09830", Length = "0xA0")]
	[CompilerGenerated]
	[Token(Token = "0x60012E7")]
	private bool <MergeLayout>b__77_0(ControlItem x) { }

	[Address(RVA = "0x2A068A0", Offset = "0x2A05CA0", Length = "0x130")]
	[Token(Token = "0x60012D8")]
	private static void AddControlItems(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[Address(RVA = "0x2A05DB0", Offset = "0x2A051B0", Length = "0x91")]
	[Token(Token = "0x60012D9")]
	private static void AddControlItemsFromFields(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[Address(RVA = "0x2A05E50", Offset = "0x2A05250", Length = "0x3C7")]
	[Token(Token = "0x60012DC")]
	private static void AddControlItemsFromMember(MemberInfo member, InputControlAttribute[] attributes, List<ControlItem> controlItems) { }

	[Address(RVA = "0x2A06220", Offset = "0x2A05620", Length = "0x5DB")]
	[Token(Token = "0x60012DB")]
	private static void AddControlItemsFromMembers(MemberInfo[] members, List<ControlItem> controlItems, string layoutName) { }

	[Address(RVA = "0x2A06800", Offset = "0x2A05C00", Length = "0x91")]
	[Token(Token = "0x60012DA")]
	private static void AddControlItemsFromProperties(Type type, List<ControlItem> controlLayouts, string layoutName) { }

	[Address(RVA = "0x2A069E0", Offset = "0x2A05DE0", Length = "0x55")]
	[Token(Token = "0x60012E5")]
	internal static CacheRefInstance CacheRef() { }

	[Address(RVA = "0x2A06A40", Offset = "0x2A05E40", Length = "0x984")]
	[Token(Token = "0x60012DD")]
	private static ControlItem CreateControlItemFromMember(MemberInfo member, InputControlAttribute attribute) { }

	[Address(RVA = "0x2A073D0", Offset = "0x2A067D0", Length = "0x4A7")]
	[Token(Token = "0x60012E0")]
	private static Dictionary<String, ControlItem> CreateLookupTableForControls(ControlItem[] controlItems, List<String> variants = null) { }

	[Address(RVA = "0x2A07DB0", Offset = "0x2A071B0", Length = "0x3F9")]
	[Token(Token = "0x60012D1")]
	public Nullable<ControlItem> FindControl(InternedString path) { }

	[Address(RVA = "0x2A07880", Offset = "0x2A06C80", Length = "0x52D")]
	[Token(Token = "0x60012D2")]
	public Nullable<ControlItem> FindControlIncludingArrayElements(string path, out int arrayIndex) { }

	[Address(RVA = "0x2A081B0", Offset = "0x2A075B0", Length = "0xB4")]
	[Token(Token = "0x60012D6")]
	public static InputControlLayout FromJson(string json) { }

	[Address(RVA = "0x2A08270", Offset = "0x2A07670", Length = "0x590")]
	[Token(Token = "0x60012D4")]
	public static InputControlLayout FromType(string name, Type type) { }

	[Address(RVA = "0x2A0A980", Offset = "0x2A09D80", Length = "0x4E")]
	[Token(Token = "0x60012C0")]
	public IEnumerable<InternedString> get_appliedOverrides() { }

	[Address(RVA = "0x2A0A9D0", Offset = "0x2A09DD0", Length = "0x4E")]
	[Token(Token = "0x60012BF")]
	public IEnumerable<InternedString> get_baseLayouts() { }

	[Address(RVA = "0x2A0AA20", Offset = "0x2A09E20", Length = "0x4F")]
	[Token(Token = "0x60012E4")]
	internal static Cache get_cache() { }

	[Address(RVA = "0x2A0AA70", Offset = "0x2A09E70", Length = "0x5B")]
	[Token(Token = "0x60012CE")]
	public Nullable<Boolean> get_canRunInBackground() { }

	[Address(RVA = "0x2A0AAD0", Offset = "0x2A09ED0", Length = "0x56")]
	[Token(Token = "0x60012C1")]
	public ReadOnlyArray<InternedString> get_commonUsages() { }

	[Address(RVA = "0x2A0AB30", Offset = "0x2A09F30", Length = "0x56")]
	[Token(Token = "0x60012C2")]
	public ReadOnlyArray<ControlItem> get_controls() { }

	[Address(RVA = "0x2A0A760", Offset = "0x2A09B60", Length = "0x5A")]
	[Token(Token = "0x60012B8")]
	public static InternedString get_DefaultVariant() { }

	[Address(RVA = "0x2A0AB90", Offset = "0x2A09F90", Length = "0x2A")]
	[Token(Token = "0x60012BA")]
	public string get_displayName() { }

	[Address(RVA = "0x2A0ABC0", Offset = "0x2A09FC0", Length = "0xB")]
	[Token(Token = "0x60012CA")]
	public bool get_hideInUI() { }

	[Address(RVA = "0x2A0ABD0", Offset = "0x2A09FD0", Length = "0x84")]
	[Token(Token = "0x60012C5")]
	public bool get_isControlLayout() { }

	[Address(RVA = "0x2A0AC60", Offset = "0x2A0A060", Length = "0x7E")]
	[Token(Token = "0x60012C4")]
	public bool get_isDeviceLayout() { }

	[Address(RVA = "0x2A0ACE0", Offset = "0x2A0A0E0", Length = "0xA")]
	[Token(Token = "0x60012C8")]
	public bool get_isGenericTypeOfDevice() { }

	[Address(RVA = "0x2A0ACF0", Offset = "0x2A0A0F0", Length = "0xB")]
	[Token(Token = "0x60012CC")]
	public bool get_isNoisy() { }

	[Address(RVA = "0x2A0AD00", Offset = "0x2A0A100", Length = "0xB")]
	[Token(Token = "0x60012C6")]
	public bool get_isOverride() { }

	[Address(RVA = "0x2A0A7C0", Offset = "0x2A09BC0", Length = "0x1BB")]
	[Token(Token = "0x60012D0")]
	public ControlItem get_Item(string path) { }

	[Address(RVA = "0x5D1860", Offset = "0x5D0C60", Length = "0xB")]
	[Token(Token = "0x60012B9")]
	public InternedString get_name() { }

	[Address(RVA = "0x115C7B0", Offset = "0x115BBB0", Length = "0x4")]
	[Token(Token = "0x60012BD")]
	public FourCC get_stateFormat() { }

	[Address(RVA = "0x1D509F0", Offset = "0x1D4FDF0", Length = "0x4")]
	[Token(Token = "0x60012BE")]
	public int get_stateSizeInBytes() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60012BB")]
	public Type get_type() { }

	[Address(RVA = "0x2A0AD10", Offset = "0x2A0A110", Length = "0x39")]
	[Token(Token = "0x60012C3")]
	public bool get_updateBeforeRender() { }

	[Address(RVA = "0xB00180", Offset = "0xAFF580", Length = "0xB")]
	[Token(Token = "0x60012BC")]
	public InternedString get_variants() { }

	[Address(RVA = "0x2A08810", Offset = "0x2A07C10", Length = "0x6E")]
	[Token(Token = "0x60012D3")]
	public Type GetValueType() { }

	[Address(RVA = "0x2A08880", Offset = "0x2A07C80", Length = "0x238")]
	[Token(Token = "0x60012DE")]
	private static string InferLayoutFromValueType(Type type) { }

	[Address(RVA = "0x2A08AC0", Offset = "0x2A07EC0", Length = "0x16B3")]
	[Token(Token = "0x60012DF")]
	public void MergeLayout(InputControlLayout other) { }

	[Address(RVA = "0x2A0A180", Offset = "0x2A09580", Length = "0x1FE")]
	[Token(Token = "0x60012E3")]
	internal static void ParseHeaderFieldsFromJson(string json, out InternedString name, out InlinedArray<InternedString>& baseLayouts, out InputDeviceMatcher deviceMatcher) { }

	[Address(RVA = "0x2A0AD50", Offset = "0x2A0A150", Length = "0x95")]
	[Token(Token = "0x60012CF")]
	internal void set_canRunInBackground(Nullable<Boolean> value) { }

	[Address(RVA = "0x2A0ADF0", Offset = "0x2A0A1F0", Length = "0x1F")]
	[Token(Token = "0x60012CB")]
	internal void set_hideInUI(bool value) { }

	[Address(RVA = "0x2A0AE10", Offset = "0x2A0A210", Length = "0x1F")]
	[Token(Token = "0x60012C9")]
	internal void set_isGenericTypeOfDevice(bool value) { }

	[Address(RVA = "0x2A0AE30", Offset = "0x2A0A230", Length = "0x1F")]
	[Token(Token = "0x60012CD")]
	internal void set_isNoisy(bool value) { }

	[Address(RVA = "0x2A0AE50", Offset = "0x2A0A250", Length = "0x1F")]
	[Token(Token = "0x60012C7")]
	internal void set_isOverride(bool value) { }

	[Address(RVA = "0x2A0A380", Offset = "0x2A09780", Length = "0xA5")]
	[Token(Token = "0x60012D5")]
	public string ToJson() { }

	[Address(RVA = "0x2A0A4D0", Offset = "0x2A098D0", Length = "0x5B")]
	[Token(Token = "0x60012E1")]
	internal static bool VariantsMatch(InternedString expected, InternedString actual) { }

	[Address(RVA = "0x2A0A530", Offset = "0x2A09930", Length = "0x135")]
	[Token(Token = "0x60012E2")]
	internal static bool VariantsMatch(string expected, string actual) { }

}

