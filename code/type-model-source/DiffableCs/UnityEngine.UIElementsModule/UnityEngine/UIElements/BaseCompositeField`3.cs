namespace UnityEngine.UIElements;

[MovedFrom(True, "UnityEditor.UIElements", "UnityEditor.UIElementsModule", null)]
[Token(Token = "0x2000075")]
public abstract class BaseCompositeField : BaseField<TValueType>, IDelayedField
{
	[CompilerGenerated]
	[Token(Token = "0x2000078")]
	private sealed class <>c__DisplayClass23_0
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000240")]
		public FieldDescription<TValueType, TField, TFieldValue> desc; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000241")]
		public TField field; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000242")]
		public BaseCompositeField<TValueType, TField, TFieldValue> <>4__this; //Field offset: 0x0

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x600043F")]
		public <>c__DisplayClass23_0() { }

		[Address(RVA = "0xA54D20", Offset = "0xA54120", Length = "0xDA")]
		[Token(Token = "0x6000440")]
		internal TFieldValue <.ctor>b__0(TFieldValue newValue) { }

		[Address(RVA = "0xA55730", Offset = "0xA54B30", Length = "0x216")]
		[Token(Token = "0x6000441")]
		internal void <.ctor>b__1(ChangeEvent<TFieldValue> e) { }

	}

	[Token(Token = "0x2000076")]
	public struct FieldDescription
	{
		[Token(Token = "0x2000077")]
		internal sealed class WriteDelegate : MulticastDelegate
		{

			[Address(RVA = "0x154EE50", Offset = "0x154E250", Length = "0xB5")]
			[Token(Token = "0x600043D")]
			public WriteDelegate(object object, IntPtr method) { }

			[Address(RVA = "0x60A170", Offset = "0x609570", Length = "0xF")]
			[Token(Token = "0x600043E")]
			public override void Invoke(ref TValueType val, TFieldValue fieldValue) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023C")]
		internal readonly string name; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023D")]
		internal readonly string ussName; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023E")]
		internal readonly Func<TValueType, TFieldValue> read; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400023F")]
		internal readonly WriteDelegate<TValueType, TField, TFieldValue> write; //Field offset: 0x0

		[Address(RVA = "0x1BB4B60", Offset = "0x1BB3F60", Length = "0x61")]
		[Token(Token = "0x600043C")]
		public FieldDescription(string name, string ussName, Func<TValueType, TFieldValue> read, WriteDelegate<TValueType, TField, TFieldValue> write) { }

	}

	[Token(Token = "0x400022E")]
	internal static readonly BindingId isDelayedProperty; //Field offset: 0x0
	[Token(Token = "0x4000233")]
	public static readonly string ussClassName; //Field offset: 0x0
	[Token(Token = "0x4000234")]
	public static readonly string labelUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000235")]
	public static readonly string inputUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000236")]
	public static readonly string spacerUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000237")]
	public static readonly string multilineVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000238")]
	public static readonly string fieldGroupUssClassName; //Field offset: 0x0
	[Token(Token = "0x4000239")]
	public static readonly string fieldUssClassName; //Field offset: 0x0
	[Token(Token = "0x400023A")]
	public static readonly string firstFieldVariantUssClassName; //Field offset: 0x0
	[Token(Token = "0x400023B")]
	public static readonly string twoLinesVariantUssClassName; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400022F")]
	private List<TField> m_Fields; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000230")]
	private bool m_ShouldUpdateDisplay; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000231")]
	private bool m_ForceUpdateDisplay; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000232")]
	private bool m_IsDelayed; //Field offset: 0x0

	[Token(Token = "0x17000095")]
	internal List<TField> fields
	{
		[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
		[Token(Token = "0x6000432")]
		internal get { } //Length: 8
	}

	[CreateProperty]
	[Token(Token = "0x17000096")]
	public override bool isDelayed
	{
		[Address(RVA = "0x165E690", Offset = "0x165DA90", Length = "0x8")]
		[Token(Token = "0x6000434")]
		 get { } //Length: 8
		[Address(RVA = "0x165EAA0", Offset = "0x165DEA0", Length = "0x1DF")]
		[Token(Token = "0x6000435")]
		 set { } //Length: 479
	}

	[Address(RVA = "0x1656710", Offset = "0x1655B10", Length = "0x985")]
	[Token(Token = "0x600043B")]
	private static BaseCompositeField`3() { }

	[Address(RVA = "0x165DCB0", Offset = "0x165D0B0", Length = "0x9D9")]
	[Token(Token = "0x6000436")]
	protected BaseCompositeField`3(string label, int fieldsByLine) { }

	[Token(Token = "0x6000433")]
	internal abstract FieldDescription<TValueType, TField, TFieldValue>[] DescribeFields() { }

	[Address(RVA = "0x1038600", Offset = "0x1037A00", Length = "0x8")]
	[Token(Token = "0x6000432")]
	internal List<TField> get_fields() { }

	[Address(RVA = "0x165E690", Offset = "0x165DA90", Length = "0x8")]
	[Token(Token = "0x6000434")]
	public override bool get_isDelayed() { }

	[Address(RVA = "0x16527E0", Offset = "0x1651BE0", Length = "0xE9")]
	[Token(Token = "0x6000431")]
	private VisualElement GetSpacer() { }

	[Address(RVA = "0x1652910", Offset = "0x1651D10", Length = "0x1E")]
	[Token(Token = "0x6000439")]
	internal virtual void OnViewDataReady() { }

	[Address(RVA = "0x165EAA0", Offset = "0x165DEA0", Length = "0x1DF")]
	[Token(Token = "0x6000435")]
	public void set_isDelayed(bool value) { }

	[Address(RVA = "0x16539C0", Offset = "0x1652DC0", Length = "0x21A")]
	[Token(Token = "0x6000438")]
	public virtual void SetValueWithoutNotify(TValueType newValue) { }

	[Address(RVA = "0x1653E70", Offset = "0x1653270", Length = "0x14B")]
	[Token(Token = "0x6000437")]
	private void UpdateDisplay() { }

	[Address(RVA = "0x1654610", Offset = "0x1653A10", Length = "0x14C")]
	[Token(Token = "0x600043A")]
	protected virtual void UpdateMixedValueContent() { }

}

