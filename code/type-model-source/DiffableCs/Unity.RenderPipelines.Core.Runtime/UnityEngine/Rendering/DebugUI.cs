namespace UnityEngine.Rendering;

[Token(Token = "0x2000098")]
public class DebugUI
{
	[Token(Token = "0x20000B8")]
	internal class BitField : EnumField<Enum>
	{
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000261")]
		private Type m_EnumType; //Field offset: 0x78

		[Token(Token = "0x1700009D")]
		public Type enumType
		{
			[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
			[Token(Token = "0x600072C")]
			 get { } //Length: 5
			[Address(RVA = "0x2BD3940", Offset = "0x2BD2D40", Length = "0x58")]
			[Token(Token = "0x600072D")]
			 set { } //Length: 88
		}

		[Address(RVA = "0x2BD38E0", Offset = "0x2BD2CE0", Length = "0x5A")]
		[Token(Token = "0x600072E")]
		public BitField() { }

		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x600072C")]
		public Type get_enumType() { }

		[Address(RVA = "0x2BD3940", Offset = "0x2BD2D40", Length = "0x58")]
		[Token(Token = "0x600072D")]
		public void set_enumType(Type value) { }

	}

	[Token(Token = "0x20000AA")]
	internal class BoolField : Field<Boolean>
	{

		[Address(RVA = "0x2BD39A0", Offset = "0x2BD2DA0", Length = "0x39")]
		[Token(Token = "0x60006F1")]
		public BoolField() { }

	}

	[Token(Token = "0x20000A5")]
	internal class Button : Widget
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000231")]
		private Action <action>k__BackingField; //Field offset: 0x50

		[Token(Token = "0x17000086")]
		public Action action
		{
			[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006D8")]
			 get { } //Length: 5
			[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006D9")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006DA")]
		public Button() { }

		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006D8")]
		public Action get_action() { }

		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006D9")]
		public void set_action(Action value) { }

	}

	[Token(Token = "0x20000B6")]
	internal class CameraSelector : ObjectPopupField
	{
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400025E")]
		private Camera[] m_CamerasArray; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400025F")]
		private List<Camera> m_Cameras; //Field offset: 0x78

		[Token(Token = "0x1700009A")]
		private IEnumerable<Camera> cameras
		{
			[Address(RVA = "0x2BD4030", Offset = "0x2BD3430", Length = "0x1B2")]
			[Token(Token = "0x6000725")]
			private get { } //Length: 434
		}

		[Address(RVA = "0x2BD3F20", Offset = "0x2BD3320", Length = "0x104")]
		[Token(Token = "0x6000724")]
		public CameraSelector() { }

		[Address(RVA = "0x2BD3F10", Offset = "0x2BD3310", Length = "0x7")]
		[CompilerGenerated]
		[Token(Token = "0x6000726")]
		private IEnumerable<Object> <.ctor>b__0_0() { }

		[Address(RVA = "0x2BD4030", Offset = "0x2BD3430", Length = "0x1B2")]
		[Token(Token = "0x6000725")]
		private IEnumerable<Camera> get_cameras() { }

	}

	[Token(Token = "0x20000B9")]
	internal class ColorField : Field<Color>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000262")]
		public bool hdr; //Field offset: 0x68
		[FieldOffset(Offset = "0x69")]
		[Token(Token = "0x4000263")]
		public bool showAlpha; //Field offset: 0x69
		[FieldOffset(Offset = "0x6A")]
		[Token(Token = "0x4000264")]
		public bool showPicker; //Field offset: 0x6A
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000265")]
		public float incStep; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000266")]
		public float incStepMult; //Field offset: 0x70
		[FieldOffset(Offset = "0x74")]
		[Token(Token = "0x4000267")]
		public int decimals; //Field offset: 0x74

		[Address(RVA = "0x2BD42A0", Offset = "0x2BD36A0", Length = "0x54")]
		[Token(Token = "0x6000730")]
		public ColorField() { }

		[Address(RVA = "0x2BD41F0", Offset = "0x2BD35F0", Length = "0xA5")]
		[Token(Token = "0x600072F")]
		public virtual Color ValidateValue(Color value) { }

	}

	[Token(Token = "0x2000099")]
	internal class Container : Widget, IContainer
	{
		[Token(Token = "0x4000212")]
		private const string k_IDToken = "#"; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000213")]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x50

		[Token(Token = "0x1700006E")]
		public private override ObservableList<Widget> children
		{
			[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000695")]
			 get { } //Length: 5
			[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000696")]
			private set { } //Length: 13
		}

		[Token(Token = "0x1700006D")]
		internal bool hideDisplayName
		{
			[Address(RVA = "0x2BD4910", Offset = "0x2BD3D10", Length = "0x5E")]
			[Token(Token = "0x6000694")]
			internal get { } //Length: 94
		}

		[Token(Token = "0x1700006F")]
		public internal virtual Panel panel
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000697")]
			 get { } //Length: 5
			[Address(RVA = "0x2BD4970", Offset = "0x2BD3D70", Length = "0xD6")]
			[Token(Token = "0x6000698")]
			internal set { } //Length: 214
		}

		[Address(RVA = "0x2BD45F0", Offset = "0x2BD39F0", Length = "0x89")]
		[Token(Token = "0x6000699")]
		public Container() { }

		[Address(RVA = "0x2BD4870", Offset = "0x2BD3C70", Length = "0x9C")]
		[Token(Token = "0x600069A")]
		public Container(string id) { }

		[Address(RVA = "0x2BD4680", Offset = "0x2BD3A80", Length = "0x1E9")]
		[Token(Token = "0x600069B")]
		public Container(string displayName, ObservableList<Widget> children) { }

		[Address(RVA = "0x2BD4300", Offset = "0x2BD3700", Length = "0xB0")]
		[Token(Token = "0x600069C")]
		internal virtual void GenerateQueryPath() { }

		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000695")]
		public override ObservableList<Widget> get_children() { }

		[Address(RVA = "0x2BD4910", Offset = "0x2BD3D10", Length = "0x5E")]
		[Token(Token = "0x6000694")]
		internal bool get_hideDisplayName() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000697")]
		public virtual Panel get_panel() { }

		[Address(RVA = "0x2BD43C0", Offset = "0x2BD37C0", Length = "0x12C")]
		[Token(Token = "0x600069F")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2BD44F0", Offset = "0x2BD38F0", Length = "0x78")]
		[Token(Token = "0x600069D")]
		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x2BD4570", Offset = "0x2BD3970", Length = "0x75")]
		[Token(Token = "0x600069E")]
		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000696")]
		private void set_children(ObservableList<Widget> value) { }

		[Address(RVA = "0x2BD4970", Offset = "0x2BD3D70", Length = "0xD6")]
		[Token(Token = "0x6000698")]
		internal virtual void set_panel(Panel value) { }

	}

	[Token(Token = "0x20000B3")]
	internal class EnumField : EnumField<Int32>
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B4")]
		private sealed class <>c
		{
			[Token(Token = "0x400025B")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400025C")]
			public static Func<GUIContent, String> <>9__17_0; //Field offset: 0x8

			[Address(RVA = "0x2BEB8C0", Offset = "0x2BEACC0", Length = "0x67")]
			[Token(Token = "0x600071E")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600071F")]
			public <>c() { }

			[Address(RVA = "0x2BEA7F0", Offset = "0x2BE9BF0", Length = "0x7F")]
			[Token(Token = "0x6000720")]
			internal string <InitQuickSeparators>b__17_0(GUIContent x) { }

		}

		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000257")]
		internal Int32[] quickSeparators; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000258")]
		private Int32[] m_Indexes; //Field offset: 0x80
		[CompilerGenerated]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000259")]
		private Func<Int32> <getIndex>k__BackingField; //Field offset: 0x88
		[CompilerGenerated]
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400025A")]
		private Action<Int32> <setIndex>k__BackingField; //Field offset: 0x90

		[Token(Token = "0x17000098")]
		public Type autoEnum
		{
			[Address(RVA = "0x2BE3510", Offset = "0x2BE2910", Length = "0x52")]
			[Token(Token = "0x600071A")]
			 set { } //Length: 82
		}

		[Token(Token = "0x17000097")]
		public int currentIndex
		{
			[Address(RVA = "0x2BE3450", Offset = "0x2BE2850", Length = "0x28")]
			[Token(Token = "0x6000718")]
			 get { } //Length: 40
			[Address(RVA = "0x2BE3570", Offset = "0x2BE2970", Length = "0x28")]
			[Token(Token = "0x6000719")]
			 set { } //Length: 40
		}

		[Token(Token = "0x17000095")]
		public Func<Int32> getIndex
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000714")]
			 get { } //Length: 8
			[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x6000715")]
			 set { } //Length: 19
		}

		[Token(Token = "0x17000094")]
		internal Int32[] indexes
		{
			[Address(RVA = "0x2BE3480", Offset = "0x2BE2880", Length = "0x86")]
			[Token(Token = "0x6000713")]
			internal get { } //Length: 134
		}

		[Token(Token = "0x17000096")]
		public Action<Int32> setIndex
		{
			[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000716")]
			 get { } //Length: 8
			[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x6000717")]
			 set { } //Length: 19
		}

		[Address(RVA = "0x2BE33F0", Offset = "0x2BE27F0", Length = "0x5A")]
		[Token(Token = "0x600071D")]
		public EnumField() { }

		[Address(RVA = "0x2BE3450", Offset = "0x2BE2850", Length = "0x28")]
		[Token(Token = "0x6000718")]
		public int get_currentIndex() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000714")]
		public Func<Int32> get_getIndex() { }

		[Address(RVA = "0x2BE3480", Offset = "0x2BE2880", Length = "0x86")]
		[Token(Token = "0x6000713")]
		internal Int32[] get_indexes() { }

		[Address(RVA = "0x5BAD10", Offset = "0x5BA110", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000716")]
		public Action<Int32> get_setIndex() { }

		[Address(RVA = "0x2BE3040", Offset = "0x2BE2440", Length = "0x250")]
		[Token(Token = "0x600071B")]
		internal void InitQuickSeparators() { }

		[Address(RVA = "0x2BE3510", Offset = "0x2BE2910", Length = "0x52")]
		[Token(Token = "0x600071A")]
		public void set_autoEnum(Type value) { }

		[Address(RVA = "0x2BE3570", Offset = "0x2BE2970", Length = "0x28")]
		[Token(Token = "0x6000719")]
		public void set_currentIndex(int value) { }

		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000715")]
		public void set_getIndex(Func<Int32> value) { }

		[Address(RVA = "0xD11C80", Offset = "0xD11080", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000717")]
		public void set_setIndex(Action<Int32> value) { }

		[Address(RVA = "0x2BE32A0", Offset = "0x2BE26A0", Length = "0x147")]
		[Token(Token = "0x600071C")]
		public virtual void SetValue(int value) { }

	}

	[Token(Token = "0x20000B1")]
	internal abstract class EnumField : Field<T>
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B2")]
		private sealed class <>c
		{
			[Token(Token = "0x4000255")]
			public static readonly <>c<T> <>9; //Field offset: 0x0
			[Token(Token = "0x4000256")]
			public static Func<FieldInfo, Boolean> <>9__6_0; //Field offset: 0x0

			[Address(RVA = "0xA509C0", Offset = "0xA4FDC0", Length = "0xE9")]
			[Token(Token = "0x6000710")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000711")]
			public <>c() { }

			[Address(RVA = "0xA347C0", Offset = "0xA33BC0", Length = "0xBB")]
			[Token(Token = "0x6000712")]
			internal bool <AutoFillFromType>b__6_0(FieldInfo fieldInfo) { }

		}

		[Token(Token = "0x4000254")]
		private static Regex s_NicifyRegEx; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000253")]
		private Int32[] m_EnumValues; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000252")]
		public GUIContent[] enumNames; //Field offset: 0x0

		[Token(Token = "0x17000093")]
		public Int32[] enumValues
		{
			[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
			[Token(Token = "0x600070B")]
			 get { } //Length: 5
			[Address(RVA = "0x1955840", Offset = "0x1954C40", Length = "0x16B")]
			[Token(Token = "0x600070C")]
			 set { } //Length: 363
		}

		[Address(RVA = "0x19552F0", Offset = "0x19546F0", Length = "0xE1")]
		[Token(Token = "0x600070F")]
		private static EnumField`1() { }

		[Address(RVA = "0x19556B0", Offset = "0x1954AB0", Length = "0x14")]
		[Token(Token = "0x600070E")]
		protected EnumField`1() { }

		[Address(RVA = "0x1952FB0", Offset = "0x19523B0", Length = "0x919")]
		[Token(Token = "0x600070D")]
		protected void AutoFillFromType(Type enumType) { }

		[Address(RVA = "0x5ACEF0", Offset = "0x5AC2F0", Length = "0x5")]
		[Token(Token = "0x600070B")]
		public Int32[] get_enumValues() { }

		[Address(RVA = "0x1955840", Offset = "0x1954C40", Length = "0x16B")]
		[Token(Token = "0x600070C")]
		public void set_enumValues(Int32[] value) { }

	}

	[Token(Token = "0x20000A9")]
	internal abstract class Field : Widget, IValueField
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000239")]
		private Func<T> <getter>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023A")]
		private Action<T> <setter>k__BackingField; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023B")]
		public Action<Field`1<T>, T> onValueChanged; //Field offset: 0x0

		[Token(Token = "0x1700008A")]
		public Func<T> getter
		{
			[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006E6")]
			 get { } //Length: 5
			[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006E7")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700008B")]
		public Action<T> setter
		{
			[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006E8")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006E9")]
			 set { } //Length: 13
		}

		[Address(RVA = "0xAC9280", Offset = "0xAC8680", Length = "0x7")]
		[Token(Token = "0x60006F0")]
		protected Field`1() { }

		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006E6")]
		public Func<T> get_getter() { }

		[Address(RVA = "0x11ED6E0", Offset = "0x11ECAE0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006E8")]
		public Action<T> get_setter() { }

		[Address(RVA = "0x1BBC2F0", Offset = "0x1BBB6F0", Length = "0x25")]
		[Token(Token = "0x60006ED")]
		public T GetValue() { }

		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006E7")]
		public void set_getter(Func<T> value) { }

		[Address(RVA = "0x11EDB10", Offset = "0x11ECF10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006E9")]
		public void set_setter(Action<T> value) { }

		[Address(RVA = "0x1BBCD40", Offset = "0x1BBC140", Length = "0x7C")]
		[Token(Token = "0x60006EE")]
		public override void SetValue(object value) { }

		[Address(RVA = "0x1BBCBA0", Offset = "0x1BBBFA0", Length = "0x103")]
		[Token(Token = "0x60006EF")]
		public override void SetValue(T value) { }

		[Address(RVA = "0x1BBDA20", Offset = "0x1BBCE20", Length = "0x48")]
		[Token(Token = "0x60006EC")]
		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		[Address(RVA = "0x1BBDCB0", Offset = "0x1BBD0B0", Length = "0xA7")]
		[Token(Token = "0x60006EA")]
		private override object UnityEngine.Rendering.DebugUI.IValueField.ValidateValue(object value) { }

		[Address(RVA = "0xF59F30", Offset = "0xF59330", Length = "0x4")]
		[Token(Token = "0x60006EB")]
		public override T ValidateValue(T value) { }

	}

	[Flags]
	[Token(Token = "0x20000A0")]
	internal enum Flags : int
	{
		None = 0,
		EditorOnly = 2,
		RuntimeOnly = 4,
		EditorForceUpdate = 8,
		FrequentlyUsed = 16,
	}

	[Token(Token = "0x20000AE")]
	internal class FloatField : Field<Single>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000245")]
		public Func<Single> min; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000246")]
		public Func<Single> max; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000247")]
		public float incStep; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000248")]
		public float incStepMult; //Field offset: 0x7C
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000249")]
		public int decimals; //Field offset: 0x80

		[Address(RVA = "0x2BE3600", Offset = "0x2BE2A00", Length = "0x51")]
		[Token(Token = "0x60006FC")]
		public FloatField() { }

		[Address(RVA = "0x2BE35A0", Offset = "0x2BE29A0", Length = "0x59")]
		[Token(Token = "0x60006FB")]
		public virtual float ValidateValue(float value) { }

	}

	[Token(Token = "0x200009A")]
	internal class Foldout : Container, IValueField
	{
		[Token(Token = "0x200009B")]
		internal struct ContextMenuItem
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400021C")]
			public string displayName; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x400021D")]
			public Action action; //Field offset: 0x8

		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000214")]
		private bool <opened>k__BackingField; //Field offset: 0x58
		[FieldOffset(Offset = "0x59")]
		[Token(Token = "0x4000215")]
		public bool isHeader; //Field offset: 0x59
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000216")]
		public List<ContextMenuItem> contextMenuItems; //Field offset: 0x60
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000217")]
		private string <documentationUrl>k__BackingField; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000218")]
		private bool m_Dirty; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000219")]
		private String[] m_ColumnLabels; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400021A")]
		private String[] m_ColumnTooltips; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400021B")]
		private List<GUIContent> m_RowContents; //Field offset: 0x88

		[Token(Token = "0x17000073")]
		public String[] columnLabels
		{
			[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
			[Token(Token = "0x60006A5")]
			 get { } //Length: 5
			[Address(RVA = "0x2BE3B00", Offset = "0x2BE2F00", Length = "0x20")]
			[Token(Token = "0x60006A6")]
			 set { } //Length: 32
		}

		[Token(Token = "0x17000074")]
		public String[] columnTooltips
		{
			[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
			[Token(Token = "0x60006A7")]
			 get { } //Length: 8
			[Address(RVA = "0x2BE3B20", Offset = "0x2BE2F20", Length = "0x23")]
			[Token(Token = "0x60006A8")]
			 set { } //Length: 35
		}

		[Token(Token = "0x17000072")]
		public string documentationUrl
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006A3")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006A4")]
			 set { } //Length: 13
		}

		[Token(Token = "0x17000070")]
		public bool isReadOnly
		{
			[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
			[Token(Token = "0x60006A0")]
			 get { } //Length: 3
		}

		[Token(Token = "0x17000071")]
		public bool opened
		{
			[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006A1")]
			 get { } //Length: 5
			[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60006A2")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000075")]
		internal List<GUIContent> rowContents
		{
			[Address(RVA = "0x2BE3840", Offset = "0x2BE2C40", Length = "0x2B4")]
			[Token(Token = "0x60006A9")]
			internal get { } //Length: 692
		}

		[Address(RVA = "0x2BE3760", Offset = "0x2BE2B60", Length = "0xDE")]
		[Token(Token = "0x60006AB")]
		public Foldout(string displayName, ObservableList<Widget> children, String[] columnLabels = null, String[] columnTooltips = null) { }

		[Address(RVA = "0x2BE36E0", Offset = "0x2BE2AE0", Length = "0x7D")]
		[Token(Token = "0x60006AA")]
		public Foldout() { }

		[Address(RVA = "0x5ACD90", Offset = "0x5AC190", Length = "0x5")]
		[Token(Token = "0x60006A5")]
		public String[] get_columnLabels() { }

		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[Token(Token = "0x60006A7")]
		public String[] get_columnTooltips() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006A3")]
		public string get_documentationUrl() { }

		[Address(RVA = "0x7AA370", Offset = "0x7A9770", Length = "0x3")]
		[Token(Token = "0x60006A0")]
		public bool get_isReadOnly() { }

		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006A1")]
		public bool get_opened() { }

		[Address(RVA = "0x2BE3840", Offset = "0x2BE2C40", Length = "0x2B4")]
		[Token(Token = "0x60006A9")]
		internal List<GUIContent> get_rowContents() { }

		[Address(RVA = "0x1CF2C30", Offset = "0x1CF2030", Length = "0x5")]
		[Token(Token = "0x60006AC")]
		public bool GetValue() { }

		[Address(RVA = "0x2BE3B00", Offset = "0x2BE2F00", Length = "0x20")]
		[Token(Token = "0x60006A6")]
		public void set_columnLabels(String[] value) { }

		[Address(RVA = "0x2BE3B20", Offset = "0x2BE2F20", Length = "0x23")]
		[Token(Token = "0x60006A8")]
		public void set_columnTooltips(String[] value) { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006A4")]
		public void set_documentationUrl(string value) { }

		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60006A2")]
		public void set_opened(bool value) { }

		[Address(RVA = "0x2BE3660", Offset = "0x2BE2A60", Length = "0x44")]
		[Token(Token = "0x60006AE")]
		public override void SetValue(object value) { }

		[Address(RVA = "0x1E523B0", Offset = "0x1E517B0", Length = "0x4")]
		[Token(Token = "0x60006B0")]
		public void SetValue(bool value) { }

		[Address(RVA = "0x2BE36B0", Offset = "0x2BE2AB0", Length = "0x22")]
		[Token(Token = "0x60006AD")]
		private override object UnityEngine.Rendering.DebugUI.IValueField.GetValue() { }

		[Address(RVA = "0xA50320", Offset = "0xA4F720", Length = "0x4")]
		[Token(Token = "0x60006AF")]
		public override object ValidateValue(object value) { }

	}

	[Token(Token = "0x200009C")]
	internal class HBox : Container
	{

		[Address(RVA = "0x2BE4C50", Offset = "0x2BE4050", Length = "0x48")]
		[Token(Token = "0x60006B1")]
		public HBox() { }

	}

	[Token(Token = "0x20000AB")]
	internal class HistoryBoolField : BoolField
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400023C")]
		private Func<Boolean>[] <historyGetter>k__BackingField; //Field offset: 0x68

		[Token(Token = "0x1700008D")]
		public int historyDepth
		{
			[Address(RVA = "0x2BE4CE0", Offset = "0x2BE40E0", Length = "0xE")]
			[Token(Token = "0x60006F4")]
			 get { } //Length: 14
		}

		[Token(Token = "0x1700008C")]
		public Func<Boolean>[] historyGetter
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006F2")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006F3")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BD39A0", Offset = "0x2BD2DA0", Length = "0x39")]
		[Token(Token = "0x60006F6")]
		public HistoryBoolField() { }

		[Address(RVA = "0x2BE4CE0", Offset = "0x2BE40E0", Length = "0xE")]
		[Token(Token = "0x60006F4")]
		public int get_historyDepth() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006F2")]
		public Func<Boolean>[] get_historyGetter() { }

		[Address(RVA = "0x2BE4CA0", Offset = "0x2BE40A0", Length = "0x3D")]
		[Token(Token = "0x60006F5")]
		public bool GetHistoryValue(int historyIndex) { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006F3")]
		public void set_historyGetter(Func<Boolean>[] value) { }

	}

	[Token(Token = "0x20000B7")]
	internal class HistoryEnumField : EnumField
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000260")]
		private Func<Int32>[] <historyIndexGetter>k__BackingField; //Field offset: 0x98

		[Token(Token = "0x1700009C")]
		public int historyDepth
		{
			[Address(RVA = "0x2BE4D40", Offset = "0x2BE4140", Length = "0x11")]
			[Token(Token = "0x6000729")]
			 get { } //Length: 17
		}

		[Token(Token = "0x1700009B")]
		public Func<Int32>[] historyIndexGetter
		{
			[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000727")]
			 get { } //Length: 8
			[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x6000728")]
			 set { } //Length: 19
		}

		[Address(RVA = "0x2BE33F0", Offset = "0x2BE27F0", Length = "0x5A")]
		[Token(Token = "0x600072B")]
		public HistoryEnumField() { }

		[Address(RVA = "0x2BE4D40", Offset = "0x2BE4140", Length = "0x11")]
		[Token(Token = "0x6000729")]
		public int get_historyDepth() { }

		[Address(RVA = "0xAEF310", Offset = "0xAEE710", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000727")]
		public Func<Int32>[] get_historyIndexGetter() { }

		[Address(RVA = "0x2BE4CF0", Offset = "0x2BE40F0", Length = "0x40")]
		[Token(Token = "0x600072A")]
		public int GetHistoryValue(int historyIndex) { }

		[Address(RVA = "0x1E03A70", Offset = "0x1E02E70", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000728")]
		public void set_historyIndexGetter(Func<Int32>[] value) { }

	}

	[Token(Token = "0x20000A3")]
	internal interface IContainer
	{

		[Token(Token = "0x17000083")]
		public ObservableList<Widget> children
		{
			[Token(Token = "0x60006D1")]
			 get { } //Length: 0
		}

		[Token(Token = "0x17000084")]
		public string displayName
		{
			[Token(Token = "0x60006D2")]
			 get { } //Length: 0
			[Token(Token = "0x60006D3")]
			 set { } //Length: 0
		}

		[Token(Token = "0x17000085")]
		public string queryPath
		{
			[Token(Token = "0x60006D4")]
			 get { } //Length: 0
		}

		[Token(Token = "0x60006D1")]
		public ObservableList<Widget> get_children() { }

		[Token(Token = "0x60006D2")]
		public string get_displayName() { }

		[Token(Token = "0x60006D4")]
		public string get_queryPath() { }

		[Token(Token = "0x60006D3")]
		public void set_displayName(string value) { }

	}

	[Token(Token = "0x20000AC")]
	internal class IntField : Field<Int32>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400023D")]
		public Func<Int32> min; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400023E")]
		public Func<Int32> max; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400023F")]
		public int incStep; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000240")]
		public int intStepMult; //Field offset: 0x7C

		[Address(RVA = "0x2BE4DD0", Offset = "0x2BE41D0", Length = "0x47")]
		[Token(Token = "0x60006F8")]
		public IntField() { }

		[Address(RVA = "0x2BE4D60", Offset = "0x2BE4160", Length = "0x65")]
		[Token(Token = "0x60006F7")]
		public virtual int ValidateValue(int value) { }

	}

	[Token(Token = "0x20000A4")]
	internal interface IValueField
	{

		[Token(Token = "0x60006D5")]
		public object GetValue() { }

		[Token(Token = "0x60006D6")]
		public void SetValue(object value) { }

		[Token(Token = "0x60006D7")]
		public object ValidateValue(object value) { }

	}

	[Obsolete("Mask field is not longer supported. Please use a BitField or implement your own Widget. #from(6000.2)")]
	[Token(Token = "0x20000C5")]
	internal class MaskField : EnumField<UInt32>
	{

		[Address(RVA = "0x2BE52A0", Offset = "0x2BE46A0", Length = "0x5A")]
		[Token(Token = "0x6000757")]
		public MaskField() { }

		[Address(RVA = "0x2BE4E20", Offset = "0x2BE4220", Length = "0x3A0")]
		[Token(Token = "0x6000755")]
		public void Fill(String[] names) { }

		[Address(RVA = "0x2BE51D0", Offset = "0x2BE45D0", Length = "0xCF")]
		[Token(Token = "0x6000756")]
		public virtual void SetValue(uint value) { }

	}

	[Token(Token = "0x20000BF")]
	internal class MessageBox : Widget
	{
		[Token(Token = "0x20000C0")]
		internal enum Style : int
		{
			Info = 0,
			Warning = 1,
			Error = 2,
		}

		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000273")]
		public Style style; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000274")]
		public Func<String> messageCallback; //Field offset: 0x58

		[Token(Token = "0x1700009E")]
		public string message
		{
			[Address(RVA = "0x2BE5300", Offset = "0x2BE4700", Length = "0x1F")]
			[Token(Token = "0x6000736")]
			 get { } //Length: 31
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x6000737")]
		public MessageBox() { }

		[Address(RVA = "0x2BE5300", Offset = "0x2BE4700", Length = "0x1F")]
		[Token(Token = "0x6000736")]
		public string get_message() { }

	}

	[Token(Token = "0x20000BD")]
	internal class ObjectField : Field<Object>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000271")]
		public Type type; //Field offset: 0x68

		[Address(RVA = "0x2BE5540", Offset = "0x2BE4940", Length = "0x84")]
		[Token(Token = "0x6000734")]
		public ObjectField() { }

	}

	[Token(Token = "0x20000BE")]
	internal class ObjectListField : Field<Object[]>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000272")]
		public Type type; //Field offset: 0x68

		[Address(RVA = "0x2BE55D0", Offset = "0x2BE49D0", Length = "0x84")]
		[Token(Token = "0x6000735")]
		public ObjectListField() { }

	}

	[Token(Token = "0x20000B5")]
	internal class ObjectPopupField : Field<Object>
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400025D")]
		private Func<IEnumerable`1<Object>> <getObjects>k__BackingField; //Field offset: 0x68

		[Token(Token = "0x17000099")]
		public Func<IEnumerable`1<Object>> getObjects
		{
			[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000721")]
			 get { } //Length: 5
			[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000722")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BE5660", Offset = "0x2BE4A60", Length = "0x39")]
		[Token(Token = "0x6000723")]
		public ObjectPopupField() { }

		[Address(RVA = "0x5ABCB0", Offset = "0x5AB0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000721")]
		public Func<IEnumerable`1<Object>> get_getObjects() { }

		[Address(RVA = "0xE13130", Offset = "0xE12530", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000722")]
		public void set_getObjects(Func<IEnumerable`1<Object>> value) { }

	}

	[Token(Token = "0x20000C3")]
	internal class Panel : IContainer, IComparable<Panel>
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C4")]
		private sealed class <>c
		{
			[Token(Token = "0x4000280")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000281")]
			public static Comparison<Widget> <>9__29_0; //Field offset: 0x8
			[Token(Token = "0x4000282")]
			public static Action<Panel> <>9__29_1; //Field offset: 0x10

			[Address(RVA = "0x2BEB9A0", Offset = "0x2BEADA0", Length = "0x67")]
			[Token(Token = "0x6000751")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000752")]
			public <>c() { }

			[Address(RVA = "0x2BEAA30", Offset = "0x2BE9E30", Length = "0x33")]
			[Token(Token = "0x6000753")]
			internal int <.ctor>b__29_0(Widget widget, Widget widget1) { }

			[Address(RVA = "0x5BCDB0", Offset = "0x5BC1B0", Length = "0x3")]
			[Token(Token = "0x6000754")]
			internal void <.ctor>b__29_1(Panel <p0>) { }

		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400027B")]
		private Flags <flags>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x400027C")]
		private string <displayName>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x400027D")]
		private int <groupIndex>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400027E")]
		private ObservableList<Widget> <children>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400027F")]
		private Action<Panel> onSetDirty; //Field offset: 0x30

		[Token(Token = "0x14000009")]
		public event Action<Panel> onSetDirty
		{
			[Address(RVA = "0x2BE5C20", Offset = "0x2BE5020", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x6000749")]
			 add { } //Length: 172
			[Address(RVA = "0x2BE5D40", Offset = "0x2BE5140", Length = "0xAC")]
			[CompilerGenerated]
			[Token(Token = "0x600074A")]
			 remove { } //Length: 172
		}

		[Token(Token = "0x170000A7")]
		public private override ObservableList<Widget> children
		{
			[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x6000747")]
			 get { } //Length: 5
			[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x6000748")]
			private set { } //Length: 13
		}

		[Token(Token = "0x170000A0")]
		public override string displayName
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x600073E")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x600073F")]
			 set { } //Length: 13
		}

		[Token(Token = "0x170000A6")]
		public bool editorForceUpdate
		{
			[Address(RVA = "0x2BE5CD0", Offset = "0x2BE50D0", Length = "0x8")]
			[Token(Token = "0x6000746")]
			 get { } //Length: 8
		}

		[Token(Token = "0x1700009F")]
		public Flags flags
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x600073C")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x600073D")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170000A1")]
		public int groupIndex
		{
			[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000740")]
			 get { } //Length: 4
			[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x6000741")]
			 set { } //Length: 4
		}

		[Token(Token = "0x170000A3")]
		public bool isEditorOnly
		{
			[Address(RVA = "0x1D63400", Offset = "0x1D62800", Length = "0x8")]
			[Token(Token = "0x6000743")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000A5")]
		public bool isInactiveInEditor
		{
			[Address(RVA = "0x2BE5CE0", Offset = "0x2BE50E0", Length = "0x57")]
			[Token(Token = "0x6000745")]
			 get { } //Length: 87
		}

		[Token(Token = "0x170000A4")]
		public bool isRuntimeOnly
		{
			[Address(RVA = "0x1D633D0", Offset = "0x1D627D0", Length = "0x8")]
			[Token(Token = "0x6000744")]
			 get { } //Length: 8
		}

		[Token(Token = "0x170000A2")]
		public override string queryPath
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x6000742")]
			 get { } //Length: 5
		}

		[Address(RVA = "0x2BE5960", Offset = "0x2BE4D60", Length = "0x2BC")]
		[Token(Token = "0x600074B")]
		public Panel() { }

		[Address(RVA = "0x2BE5C20", Offset = "0x2BE5020", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x6000749")]
		public void add_onSetDirty(Action<Panel> value) { }

		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000747")]
		public override ObservableList<Widget> get_children() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600073E")]
		public override string get_displayName() { }

		[Address(RVA = "0x2BE5CD0", Offset = "0x2BE50D0", Length = "0x8")]
		[Token(Token = "0x6000746")]
		public bool get_editorForceUpdate() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x600073C")]
		public Flags get_flags() { }

		[Address(RVA = "0xD0FE10", Offset = "0xD0F210", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000740")]
		public int get_groupIndex() { }

		[Address(RVA = "0x1D63400", Offset = "0x1D62800", Length = "0x8")]
		[Token(Token = "0x6000743")]
		public bool get_isEditorOnly() { }

		[Address(RVA = "0x2BE5CE0", Offset = "0x2BE50E0", Length = "0x57")]
		[Token(Token = "0x6000745")]
		public bool get_isInactiveInEditor() { }

		[Address(RVA = "0x1D633D0", Offset = "0x1D627D0", Length = "0x8")]
		[Token(Token = "0x6000744")]
		public bool get_isRuntimeOnly() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x6000742")]
		public override string get_queryPath() { }

		[Address(RVA = "0x2BE56A0", Offset = "0x2BE4AA0", Length = "0xDC")]
		[Token(Token = "0x600074F")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x2BE5780", Offset = "0x2BE4B80", Length = "0x6E")]
		[Token(Token = "0x600074C")]
		protected override void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x2BE57F0", Offset = "0x2BE4BF0", Length = "0x6C")]
		[Token(Token = "0x600074D")]
		protected override void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x2BE5D40", Offset = "0x2BE5140", Length = "0xAC")]
		[CompilerGenerated]
		[Token(Token = "0x600074A")]
		public void remove_onSetDirty(Action<Panel> value) { }

		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x6000748")]
		private void set_children(ObservableList<Widget> value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x600073F")]
		public override void set_displayName(string value) { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600073D")]
		public void set_flags(Flags value) { }

		[Address(RVA = "0x109C830", Offset = "0x109BC30", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000741")]
		public void set_groupIndex(int value) { }

		[Address(RVA = "0x2BE5860", Offset = "0x2BE4C60", Length = "0xC8")]
		[Token(Token = "0x600074E")]
		public void SetDirty() { }

		[Address(RVA = "0x2BE5930", Offset = "0x2BE4D30", Length = "0x2F")]
		[Token(Token = "0x6000750")]
		private override int System.IComparable<UnityEngine.Rendering.DebugUI.Panel>.CompareTo(Panel other) { }

	}

	[Token(Token = "0x20000A7")]
	internal class ProgressBarValue : Value
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000235")]
		public float min; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000236")]
		public float max; //Field offset: 0x6C

		[Address(RVA = "0x2BE6630", Offset = "0x2BE5A30", Length = "0x56")]
		[Token(Token = "0x60006E1")]
		public ProgressBarValue() { }

		[Address(RVA = "0x28209F0", Offset = "0x281FDF0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006E2")]
		internal static float <FormatString>g__Remap01|2_0(float v, float x0, float y0) { }

		[Address(RVA = "0x2BE6550", Offset = "0x2BE5950", Length = "0xD3")]
		[Token(Token = "0x60006E0")]
		public virtual string FormatString(object value) { }

	}

	[Token(Token = "0x20000AF")]
	internal class RenderingLayerField : Field<RenderingLayerMask>, IContainer
	{
		[CompilerGenerated]
		[Token(Token = "0x20000B0")]
		private sealed class <>c__DisplayClass5_0
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000250")]
			public int index; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000251")]
			public RenderingLayerField <>4__this; //Field offset: 0x18

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6000708")]
			public <>c__DisplayClass5_0() { }

			[Address(RVA = "0x2BEB560", Offset = "0x2BEA960", Length = "0x7D")]
			[Token(Token = "0x6000709")]
			internal Color <Resize>b__0() { }

			[Address(RVA = "0x2BEB5E0", Offset = "0x2BEA9E0", Length = "0x75")]
			[Token(Token = "0x600070A")]
			internal void <Resize>b__1(Color value) { }

		}

		[Token(Token = "0x400024A")]
		private static readonly NameAndTooltip s_RenderingLayerColors; //Field offset: 0x0
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400024B")]
		private String[] m_RenderingLayersNames; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400024C")]
		private int m_DefinedRenderingLayersCount; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400024D")]
		private ObservableList<Widget> m_RenderingLayersColors; //Field offset: 0x78
		[CompilerGenerated]
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400024E")]
		private Func<Int32, Vector4> <getRenderingLayerColor>k__BackingField; //Field offset: 0x80
		[CompilerGenerated]
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400024F")]
		private Action<Vector4, Int32> <setRenderingLayerColor>k__BackingField; //Field offset: 0x88

		[Token(Token = "0x17000090")]
		public override ObservableList<Widget> children
		{
			[Address(RVA = "0x2BE6F20", Offset = "0x2BE6320", Length = "0x65")]
			[Token(Token = "0x6000700")]
			 get { } //Length: 101
		}

		[Token(Token = "0x17000091")]
		public Func<Int32, Vector4> getRenderingLayerColor
		{
			[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000701")]
			 get { } //Length: 8
			[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
			[CompilerGenerated]
			[Token(Token = "0x6000702")]
			 set { } //Length: 16
		}

		[Token(Token = "0x1700008E")]
		private int maxRenderingLayerCount
		{
			[Address(RVA = "0x2BE6F90", Offset = "0x2BE6390", Length = "0x40")]
			[Token(Token = "0x60006FD")]
			private get { } //Length: 64
		}

		[Token(Token = "0x1700008F")]
		public String[] renderingLayersNames
		{
			[Address(RVA = "0x2BE6FD0", Offset = "0x2BE63D0", Length = "0x65")]
			[Token(Token = "0x60006FF")]
			 get { } //Length: 101
		}

		[Token(Token = "0x17000092")]
		public Action<Vector4, Int32> setRenderingLayerColor
		{
			[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
			[CompilerGenerated]
			[Token(Token = "0x6000703")]
			 get { } //Length: 8
			[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
			[CompilerGenerated]
			[Token(Token = "0x6000704")]
			 set { } //Length: 19
		}

		[Address(RVA = "0x2BE6D70", Offset = "0x2BE6170", Length = "0x9D")]
		[Token(Token = "0x6000707")]
		private static RenderingLayerField() { }

		[Address(RVA = "0x2BE6E10", Offset = "0x2BE6210", Length = "0x10B")]
		[Token(Token = "0x6000706")]
		public RenderingLayerField() { }

		[Address(RVA = "0x2BE6710", Offset = "0x2BE5B10", Length = "0x157")]
		[Token(Token = "0x6000705")]
		internal virtual void GenerateQueryPath() { }

		[Address(RVA = "0x2BE6F20", Offset = "0x2BE6320", Length = "0x65")]
		[Token(Token = "0x6000700")]
		public override ObservableList<Widget> get_children() { }

		[Address(RVA = "0x121B2C0", Offset = "0x121A6C0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000701")]
		public Func<Int32, Vector4> get_getRenderingLayerColor() { }

		[Address(RVA = "0x2BE6F90", Offset = "0x2BE6390", Length = "0x40")]
		[Token(Token = "0x60006FD")]
		private int get_maxRenderingLayerCount() { }

		[Address(RVA = "0x2BE6FD0", Offset = "0x2BE63D0", Length = "0x65")]
		[Token(Token = "0x60006FF")]
		public String[] get_renderingLayersNames() { }

		[Address(RVA = "0x5AD5A0", Offset = "0x5AC9A0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x6000703")]
		public Action<Vector4, Int32> get_setRenderingLayerColor() { }

		[Address(RVA = "0x2BE6870", Offset = "0x2BE5C70", Length = "0x4FE")]
		[Token(Token = "0x60006FE")]
		private void Resize() { }

		[Address(RVA = "0x5B8EC0", Offset = "0x5B82C0", Length = "0x10")]
		[CompilerGenerated]
		[Token(Token = "0x6000702")]
		public void set_getRenderingLayerColor(Func<Int32, Vector4> value) { }

		[Address(RVA = "0xE26DF0", Offset = "0xE261F0", Length = "0x13")]
		[CompilerGenerated]
		[Token(Token = "0x6000704")]
		public void set_setRenderingLayerColor(Action<Vector4, Int32> value) { }

	}

	[Token(Token = "0x20000C1")]
	internal class RuntimeDebugShadersMessageBox : MessageBox
	{
		[CompilerGenerated]
		[Token(Token = "0x20000C2")]
		private sealed class <>c
		{
			[Token(Token = "0x4000279")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x400027A")]
			public static Func<Boolean> <>9__0_0; //Field offset: 0x8

			[Address(RVA = "0x2BEB850", Offset = "0x2BEAC50", Length = "0x67")]
			[Token(Token = "0x6000739")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x600073A")]
			public <>c() { }

			[Address(RVA = "0x2BEA9A0", Offset = "0x2BE9DA0", Length = "0x81")]
			[Token(Token = "0x600073B")]
			internal bool <.ctor>b__0_0() { }

		}


		[Address(RVA = "0x2BE7090", Offset = "0x2BE6490", Length = "0x130")]
		[Token(Token = "0x6000738")]
		public RuntimeDebugShadersMessageBox() { }

	}

	[Token(Token = "0x200009E")]
	internal class Table : Container
	{
		[Token(Token = "0x200009F")]
		internal class Row : Foldout
		{

			[Address(RVA = "0x2BE7040", Offset = "0x2BE6440", Length = "0x48")]
			[Token(Token = "0x60006BA")]
			public Row() { }

		}

		[Token(Token = "0x400021E")]
		private static GUIStyle columnHeaderStyle; //Field offset: 0x0
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x400021F")]
		public bool isReadOnly; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000220")]
		private Boolean[] m_Header; //Field offset: 0x60

		[Token(Token = "0x17000076")]
		public Boolean[] VisibleColumns
		{
			[Address(RVA = "0x2BEA2C0", Offset = "0x2BE96C0", Length = "0x28D")]
			[Token(Token = "0x60006B6")]
			 get { } //Length: 653
		}

		[Address(RVA = "0x2BEA1E0", Offset = "0x2BE95E0", Length = "0x8D")]
		[Token(Token = "0x60006B9")]
		private static Table() { }

		[Address(RVA = "0x2BEA270", Offset = "0x2BE9670", Length = "0x48")]
		[Token(Token = "0x60006B3")]
		public Table() { }

		[Address(RVA = "0x2BEA2C0", Offset = "0x2BE96C0", Length = "0x28D")]
		[Token(Token = "0x60006B6")]
		public Boolean[] get_VisibleColumns() { }

		[Address(RVA = "0x2BEA020", Offset = "0x2BE9420", Length = "0x41")]
		[Token(Token = "0x60006B5")]
		public bool GetColumnVisibility(int index) { }

		[Address(RVA = "0x2BEA070", Offset = "0x2BE9470", Length = "0x8A")]
		[Token(Token = "0x60006B7")]
		protected virtual void OnItemAdded(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x2BEA100", Offset = "0x2BE9500", Length = "0x87")]
		[Token(Token = "0x60006B8")]
		protected virtual void OnItemRemoved(ObservableList<Widget> sender, ListChangedEventArgs<Widget> e) { }

		[Address(RVA = "0x2BEA190", Offset = "0x2BE9590", Length = "0x43")]
		[Token(Token = "0x60006B4")]
		public void SetColumnVisibility(int index, bool visible) { }

	}

	[Token(Token = "0x20000AD")]
	internal class UIntField : Field<UInt32>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000241")]
		public Func<UInt32> min; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000242")]
		public Func<UInt32> max; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000243")]
		public uint incStep; //Field offset: 0x78
		[FieldOffset(Offset = "0x7C")]
		[Token(Token = "0x4000244")]
		public uint intStepMult; //Field offset: 0x7C

		[Address(RVA = "0x2BEBB10", Offset = "0x2BEAF10", Length = "0x47")]
		[Token(Token = "0x60006FA")]
		public UIntField() { }

		[Address(RVA = "0x2BE4D60", Offset = "0x2BE4160", Length = "0x65")]
		[Token(Token = "0x60006F9")]
		public virtual uint ValidateValue(uint value) { }

	}

	[Token(Token = "0x20000A6")]
	internal class Value : Widget
	{
		[CompilerGenerated]
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000232")]
		private Func<Object> <getter>k__BackingField; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000233")]
		public float refreshRate; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000234")]
		public string formatString; //Field offset: 0x60

		[Token(Token = "0x17000087")]
		public Func<Object> getter
		{
			[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006DB")]
			 get { } //Length: 5
			[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006DC")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x2BEBC80", Offset = "0x2BEB080", Length = "0x4F")]
		[Token(Token = "0x60006DD")]
		public Value() { }

		[Address(RVA = "0x2BEBC20", Offset = "0x2BEB020", Length = "0x5B")]
		[Token(Token = "0x60006DF")]
		public override string FormatString(object value) { }

		[Address(RVA = "0xFF93A0", Offset = "0xFF87A0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006DB")]
		public Func<Object> get_getter() { }

		[Address(RVA = "0x1BBC2F0", Offset = "0x1BBB6F0", Length = "0x25")]
		[Token(Token = "0x60006DE")]
		public override object GetValue() { }

		[Address(RVA = "0x115C980", Offset = "0x115BD80", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006DC")]
		public void set_getter(Func<Object> value) { }

	}

	[Token(Token = "0x20000A8")]
	internal class ValueTuple : Widget
	{
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000237")]
		public Value[] values; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000238")]
		public int pinnedElementIndex; //Field offset: 0x58

		[Token(Token = "0x17000088")]
		public int numElements
		{
			[Address(RVA = "0x2563110", Offset = "0x2562510", Length = "0x1A")]
			[Token(Token = "0x60006E3")]
			 get { } //Length: 26
		}

		[Token(Token = "0x17000089")]
		public float refreshRate
		{
			[Address(RVA = "0x2BEBBC0", Offset = "0x2BEAFC0", Length = "0x53")]
			[Token(Token = "0x60006E4")]
			 get { } //Length: 83
		}

		[Address(RVA = "0x2BEBBB0", Offset = "0x2BEAFB0", Length = "0xE")]
		[Token(Token = "0x60006E5")]
		public ValueTuple() { }

		[Address(RVA = "0x2563110", Offset = "0x2562510", Length = "0x1A")]
		[Token(Token = "0x60006E3")]
		public int get_numElements() { }

		[Address(RVA = "0x2BEBBC0", Offset = "0x2BEAFC0", Length = "0x53")]
		[Token(Token = "0x60006E4")]
		public float get_refreshRate() { }

	}

	[Token(Token = "0x200009D")]
	internal class VBox : Container
	{

		[Address(RVA = "0x2BEBB60", Offset = "0x2BEAF60", Length = "0x48")]
		[Token(Token = "0x60006B2")]
		public VBox() { }

	}

	[Token(Token = "0x20000BA")]
	internal class Vector2Field : Field<Vector2>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000268")]
		public float incStep; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4000269")]
		public float incStepMult; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400026A")]
		public int decimals; //Field offset: 0x70

		[Address(RVA = "0x2BEBCD0", Offset = "0x2BEB0D0", Length = "0x4E")]
		[Token(Token = "0x6000731")]
		public Vector2Field() { }

	}

	[Token(Token = "0x20000BB")]
	internal class Vector3Field : Field<Vector3>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400026B")]
		public float incStep; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400026C")]
		public float incStepMult; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400026D")]
		public int decimals; //Field offset: 0x70

		[Address(RVA = "0x2BEBD20", Offset = "0x2BEB120", Length = "0x4E")]
		[Token(Token = "0x6000732")]
		public Vector3Field() { }

	}

	[Token(Token = "0x20000BC")]
	internal class Vector4Field : Field<Vector4>
	{
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x400026E")]
		public float incStep; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400026F")]
		public float incStepMult; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000270")]
		public int decimals; //Field offset: 0x70

		[Address(RVA = "0x2BEBD70", Offset = "0x2BEB170", Length = "0x4E")]
		[Token(Token = "0x6000733")]
		public Vector4Field() { }

	}

	[Token(Token = "0x20000A1")]
	internal abstract class Widget
	{
		[Token(Token = "0x20000A2")]
		internal struct NameAndTooltip
		{
			[FieldOffset(Offset = "0x0")]
			[Token(Token = "0x400022F")]
			public string name; //Field offset: 0x0
			[FieldOffset(Offset = "0x8")]
			[Token(Token = "0x4000230")]
			public string tooltip; //Field offset: 0x8

		}

		[CompilerGenerated]
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000227")]
		private int <order>k__BackingField; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000228")]
		protected Panel m_Panel; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000229")]
		protected IContainer m_Parent; //Field offset: 0x20
		[CompilerGenerated]
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x400022A")]
		private Flags <flags>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x400022B")]
		private string <displayName>k__BackingField; //Field offset: 0x30
		[CompilerGenerated]
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x400022C")]
		private string <tooltip>k__BackingField; //Field offset: 0x38
		[CompilerGenerated]
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400022D")]
		private string <queryPath>k__BackingField; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400022E")]
		public Func<Boolean> isHiddenCallback; //Field offset: 0x48

		[Token(Token = "0x1700007B")]
		public override string displayName
		{
			[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006C3")]
			 get { } //Length: 5
			[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006C4")]
			 set { } //Length: 13
		}

		[Token(Token = "0x1700007A")]
		public Flags flags
		{
			[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60006C1")]
			 get { } //Length: 4
			[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60006C2")]
			 set { } //Length: 4
		}

		[Token(Token = "0x1700007E")]
		public bool isEditorOnly
		{
			[Address(RVA = "0x2BEE9A0", Offset = "0x2BEDDA0", Length = "0x8")]
			[Token(Token = "0x60006C9")]
			 get { } //Length: 8
		}

		[Token(Token = "0x17000081")]
		public bool isHidden
		{
			[Address(RVA = "0x2BEE9B0", Offset = "0x2BEDDB0", Length = "0x1B")]
			[Token(Token = "0x60006CC")]
			 get { } //Length: 27
		}

		[Token(Token = "0x17000080")]
		public bool isInactiveInEditor
		{
			[Address(RVA = "0x2BEE9D0", Offset = "0x2BEDDD0", Length = "0x57")]
			[Token(Token = "0x60006CB")]
			 get { } //Length: 87
		}

		[Token(Token = "0x1700007F")]
		public bool isRuntimeOnly
		{
			[Address(RVA = "0x2BEEA30", Offset = "0x2BEDE30", Length = "0x9")]
			[Token(Token = "0x60006CA")]
			 get { } //Length: 9
		}

		[Token(Token = "0x17000082")]
		public NameAndTooltip nameAndTooltip
		{
			[Address(RVA = "0x2BEEA40", Offset = "0x2BEDE40", Length = "0x12F")]
			[Token(Token = "0x60006CF")]
			 set { } //Length: 303
		}

		[Token(Token = "0x17000077")]
		public int order
		{
			[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
			[CompilerGenerated]
			[Token(Token = "0x60006BB")]
			 get { } //Length: 85
			[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
			[CompilerGenerated]
			[Token(Token = "0x60006BC")]
			 set { } //Length: 4
		}

		[Token(Token = "0x17000078")]
		public internal override Panel panel
		{
			[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
			[Token(Token = "0x60006BD")]
			 get { } //Length: 5
			[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
			[Token(Token = "0x60006BE")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x17000079")]
		public internal override IContainer parent
		{
			[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
			[Token(Token = "0x60006BF")]
			 get { } //Length: 5
			[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
			[Token(Token = "0x60006C0")]
			internal set { } //Length: 13
		}

		[Token(Token = "0x1700007D")]
		public private override string queryPath
		{
			[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006C7")]
			 get { } //Length: 5
			[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006C8")]
			private set { } //Length: 13
		}

		[Token(Token = "0x1700007C")]
		public string tooltip
		{
			[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
			[CompilerGenerated]
			[Token(Token = "0x60006C5")]
			 get { } //Length: 5
			[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
			[CompilerGenerated]
			[Token(Token = "0x60006C6")]
			 set { } //Length: 13
		}

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60006D0")]
		protected Widget() { }

		[Address(RVA = "0x2BEE860", Offset = "0x2BEDC60", Length = "0xA3")]
		[Token(Token = "0x60006CD")]
		internal override void GenerateQueryPath() { }

		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006C3")]
		public override string get_displayName() { }

		[Address(RVA = "0xE30F80", Offset = "0xE30380", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60006C1")]
		public Flags get_flags() { }

		[Address(RVA = "0x2BEE9A0", Offset = "0x2BEDDA0", Length = "0x8")]
		[Token(Token = "0x60006C9")]
		public bool get_isEditorOnly() { }

		[Address(RVA = "0x2BEE9B0", Offset = "0x2BEDDB0", Length = "0x1B")]
		[Token(Token = "0x60006CC")]
		public bool get_isHidden() { }

		[Address(RVA = "0x2BEE9D0", Offset = "0x2BEDDD0", Length = "0x57")]
		[Token(Token = "0x60006CB")]
		public bool get_isInactiveInEditor() { }

		[Address(RVA = "0x2BEEA30", Offset = "0x2BEDE30", Length = "0x9")]
		[Token(Token = "0x60006CA")]
		public bool get_isRuntimeOnly() { }

		[Address(RVA = "0x5AA630", Offset = "0x5A9A30", Length = "0x55")]
		[CompilerGenerated]
		[Token(Token = "0x60006BB")]
		public int get_order() { }

		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60006BD")]
		public override Panel get_panel() { }

		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60006BF")]
		public override IContainer get_parent() { }

		[Address(RVA = "0x5ACF30", Offset = "0x5AC330", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006C7")]
		public override string get_queryPath() { }

		[Address(RVA = "0x5ACF20", Offset = "0x5AC320", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x60006C5")]
		public string get_tooltip() { }

		[Address(RVA = "0x2BEE910", Offset = "0x2BEDD10", Length = "0x84")]
		[Token(Token = "0x60006CE")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006C4")]
		public override void set_displayName(string value) { }

		[Address(RVA = "0xFDA900", Offset = "0xFD9D00", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60006C2")]
		public void set_flags(Flags value) { }

		[Address(RVA = "0x2BEEA40", Offset = "0x2BEDE40", Length = "0x12F")]
		[Token(Token = "0x60006CF")]
		public void set_nameAndTooltip(NameAndTooltip value) { }

		[Address(RVA = "0x609F90", Offset = "0x609390", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x60006BC")]
		public void set_order(int value) { }

		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60006BE")]
		internal override void set_panel(Panel value) { }

		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60006C0")]
		internal override void set_parent(IContainer value) { }

		[Address(RVA = "0x1116960", Offset = "0x1115D60", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006C8")]
		private void set_queryPath(string value) { }

		[Address(RVA = "0x5B7900", Offset = "0x5B6D00", Length = "0xD")]
		[CompilerGenerated]
		[Token(Token = "0x60006C6")]
		public void set_tooltip(string value) { }

	}


	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000693")]
	public DebugUI() { }

}

