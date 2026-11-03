namespace UnityEngine.UIElements;

[DefaultMember("Item")]
[Token(Token = "0x200016C")]
public struct ToggleButtonGroupState : IEquatable<ToggleButtonGroupState>, IComparable<ToggleButtonGroupState>
{
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x400072A")]
	private ulong m_Data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x400072B")]
	private int m_Length; //Field offset: 0x8

	[Token(Token = "0x170001E3")]
	internal ulong data
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x6000B00")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x170001E4")]
	public bool Item
	{
		[Address(RVA = "0x33B9910", Offset = "0x33B8D10", Length = "0xE5")]
		[Token(Token = "0x6000B01")]
		 get { } //Length: 229
		[Address(RVA = "0x33B9A40", Offset = "0x33B8E40", Length = "0xF7")]
		[Token(Token = "0x6000B02")]
		 set { } //Length: 247
	}

	[Token(Token = "0x170001E2")]
	public internal int length
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x6000AFE")]
		 get { } //Length: 4
		[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
		[Token(Token = "0x6000AFF")]
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 4
	}

	[Address(RVA = "0x33B9800", Offset = "0x33B8C00", Length = "0x10F")]
	[Token(Token = "0x6000AFD")]
	public ToggleButtonGroupState(ulong optionsBitMask, int length) { }

	[Address(RVA = "0x33B9430", Offset = "0x33B8830", Length = "0x40")]
	[Token(Token = "0x6000B05")]
	public override int CompareTo(ToggleButtonGroupState other) { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[Token(Token = "0x6000B09")]
	public override bool Equals(ToggleButtonGroupState other) { }

	[Address(RVA = "0x33B9470", Offset = "0x33B8870", Length = "0x8E")]
	[Token(Token = "0x6000B0A")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x6000B00")]
	internal ulong get_data() { }

	[Address(RVA = "0x33B9910", Offset = "0x33B8D10", Length = "0xE5")]
	[Token(Token = "0x6000B01")]
	public bool get_Item(int index) { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x6000AFE")]
	public int get_length() { }

	[Address(RVA = "0x33B9500", Offset = "0x33B8900", Length = "0x1B0")]
	[Token(Token = "0x6000B03")]
	public Span<Int32> GetActiveOptions(Span<Int32> activeOptionsIndices) { }

	[Address(RVA = "0x33B96C0", Offset = "0x33B8AC0", Length = "0x6B")]
	[Token(Token = "0x6000B0B")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0xD15EB0", Offset = "0xD152B0", Length = "0x1C")]
	[Token(Token = "0x6000B07")]
	public static bool op_Equality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	[Address(RVA = "0x33B9A00", Offset = "0x33B8E00", Length = "0x33")]
	[Token(Token = "0x6000B08")]
	public static bool op_Inequality(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs) { }

	[Address(RVA = "0x604930", Offset = "0x603D30", Length = "0x8")]
	[Token(Token = "0x6000B04")]
	public void ResetAllOptions() { }

	[Address(RVA = "0x33B9730", Offset = "0x33B8B30", Length = "0x46")]
	[Token(Token = "0x6000B06")]
	private void ResetOptions(int startingIndex) { }

	[Address(RVA = "0x33B9A40", Offset = "0x33B8E40", Length = "0xF7")]
	[Token(Token = "0x6000B02")]
	public void set_Item(int index, bool value) { }

	[Address(RVA = "0x672EA0", Offset = "0x6722A0", Length = "0x4")]
	[Token(Token = "0x6000AFF")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_length(int value) { }

	[Address(RVA = "0x33B9780", Offset = "0x33B8B80", Length = "0x79")]
	[Token(Token = "0x6000B0C")]
	public virtual string ToString() { }

}

