namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000253")]
public struct NamedValue : IEquatable<NamedValue>
{
	[Token(Token = "0x4000CAF")]
	public const string Separator = ","; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CB0")]
	private string <name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CB1")]
	private PrimitiveValue <value>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000600")]
	public string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60015BC")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60015BD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000602")]
	public TypeCode type
	{
		[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
		[Token(Token = "0x60015C0")]
		 get { } //Length: 4
	}

	[Token(Token = "0x17000601")]
	public PrimitiveValue value
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60015BE")]
		 get { } //Length: 11
		[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60015BF")]
		 set { } //Length: 8
	}

	[Address(RVA = "0x88BA70", Offset = "0x88AE70", Length = "0x1E0")]
	[Token(Token = "0x60015CD")]
	public static void ApplyAllToObject(object instance, TParameterList parameters) { }

	[Address(RVA = "0x2923B50", Offset = "0x2922F50", Length = "0x28E")]
	[Token(Token = "0x60015CC")]
	public void ApplyToObject(object instance) { }

	[Address(RVA = "0x2923DE0", Offset = "0x29231E0", Length = "0x67")]
	[Token(Token = "0x60015C1")]
	public NamedValue ConvertTo(TypeCode type) { }

	[Address(RVA = "0x2923ED0", Offset = "0x29232D0", Length = "0xED")]
	[Token(Token = "0x60015C5")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2923E50", Offset = "0x2923250", Length = "0x78")]
	[Token(Token = "0x60015C4")]
	public override bool Equals(NamedValue other) { }

	[Address(RVA = "0x88BD40", Offset = "0x88B140", Length = "0x7C")]
	[Token(Token = "0x60015C2")]
	public static NamedValue From(string name, TValue value) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60015BC")]
	public string get_name() { }

	[Address(RVA = "0x672E80", Offset = "0x672280", Length = "0x4")]
	[Token(Token = "0x60015C0")]
	public TypeCode get_type() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60015BE")]
	public PrimitiveValue get_value() { }

	[Address(RVA = "0x2923FC0", Offset = "0x29233C0", Length = "0x9C")]
	[Token(Token = "0x60015C6")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x2924600", Offset = "0x2923A00", Length = "0x80")]
	[Token(Token = "0x60015C7")]
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	[Address(RVA = "0x2924680", Offset = "0x2923A80", Length = "0x94")]
	[Token(Token = "0x60015C8")]
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	[Address(RVA = "0x2924540", Offset = "0x2923940", Length = "0x3C")]
	[Token(Token = "0x60015CA")]
	public static NamedValue Parse(string str) { }

	[Address(RVA = "0x2924060", Offset = "0x2923460", Length = "0x1F0")]
	[Token(Token = "0x60015C9")]
	public static NamedValue[] ParseMultiple(string parameterString) { }

	[Address(RVA = "0x2924260", Offset = "0x2923660", Length = "0x2D4")]
	[Token(Token = "0x60015CB")]
	private static NamedValue ParseParameter(string parameterString, ref int index) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60015BD")]
	public void set_name(string value) { }

	[Address(RVA = "0x1FF58F0", Offset = "0x1FF4CF0", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60015BF")]
	public void set_value(PrimitiveValue value) { }

	[Address(RVA = "0x2924580", Offset = "0x2923980", Length = "0x72")]
	[Token(Token = "0x60015C3")]
	public virtual string ToString() { }

}

