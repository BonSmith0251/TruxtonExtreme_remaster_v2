namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000251")]
public struct NameAndParameters
{
	[CompilerGenerated]
	[Token(Token = "0x2000252")]
	private sealed class <>c
	{
		[Token(Token = "0x4000CAC")]
		public static readonly <>c <>9; //Field offset: 0x0
		[Token(Token = "0x4000CAD")]
		public static Func<NamedValue, String> <>9__8_0; //Field offset: 0x8
		[Token(Token = "0x4000CAE")]
		public static Func<NameAndParameters, String> <>9__9_0; //Field offset: 0x10

		[Address(RVA = "0x292B1B0", Offset = "0x292A5B0", Length = "0x67")]
		[Token(Token = "0x60015B8")]
		private static <>c() { }

		[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
		[Token(Token = "0x60015B9")]
		public <>c() { }

		[Address(RVA = "0x292B080", Offset = "0x292A480", Length = "0x13")]
		[Token(Token = "0x60015BB")]
		internal string <ToSerializableString>b__9_0(NameAndParameters x) { }

		[Address(RVA = "0x292B170", Offset = "0x292A570", Length = "0x13")]
		[Token(Token = "0x60015BA")]
		internal string <ToString>b__8_0(NamedValue x) { }

	}

	[CompilerGenerated]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CAA")]
	private string <name>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000CAB")]
	private ReadOnlyArray<NamedValue> <parameters>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x170005FE")]
	public string name
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60015AC")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[CompilerGenerated]
		[Token(Token = "0x60015AD")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170005FF")]
	public ReadOnlyArray<NamedValue> parameters
	{
		[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
		[CompilerGenerated]
		[IsReadOnly]
		[Token(Token = "0x60015AE")]
		 get { } //Length: 11
		[Address(RVA = "0x2923B30", Offset = "0x2922F30", Length = "0x12")]
		[CompilerGenerated]
		[Token(Token = "0x60015AF")]
		 set { } //Length: 18
	}

	[Address(RVA = "0x2922DE0", Offset = "0x29221E0", Length = "0xAA")]
	[Token(Token = "0x60015B2")]
	internal static NameAndParameters Create(string name, IList<NamedValue> parameters) { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60015AC")]
	public string get_name() { }

	[Address(RVA = "0xAEF200", Offset = "0xAEE600", Length = "0xB")]
	[CompilerGenerated]
	[IsReadOnly]
	[Token(Token = "0x60015AE")]
	public ReadOnlyArray<NamedValue> get_parameters() { }

	[Address(RVA = "0x2923730", Offset = "0x2922B30", Length = "0x8C")]
	[Token(Token = "0x60015B6")]
	public static NameAndParameters Parse(string text) { }

	[Address(RVA = "0x2922E90", Offset = "0x2922290", Length = "0x271")]
	[Token(Token = "0x60015B3")]
	public static IEnumerable<NameAndParameters> ParseMultiple(string text) { }

	[Address(RVA = "0x2923110", Offset = "0x2922510", Length = "0x1DC")]
	[Token(Token = "0x60015B4")]
	internal static bool ParseMultiple(string text, ref List<NameAndParameters>& list) { }

	[Address(RVA = "0x29236A0", Offset = "0x2922AA0", Length = "0x83")]
	[Token(Token = "0x60015B5")]
	internal static string ParseName(string text) { }

	[Address(RVA = "0x29232F0", Offset = "0x29226F0", Length = "0x3A8")]
	[Token(Token = "0x60015B7")]
	private static NameAndParameters ParseNameAndParameters(string text, ref int index, bool nameOnly = false) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[CompilerGenerated]
	[Token(Token = "0x60015AD")]
	public void set_name(string value) { }

	[Address(RVA = "0x2923B30", Offset = "0x2922F30", Length = "0x12")]
	[CompilerGenerated]
	[Token(Token = "0x60015AF")]
	public void set_parameters(ReadOnlyArray<NamedValue> value) { }

	[Address(RVA = "0x29237C0", Offset = "0x2922BC0", Length = "0x174")]
	[Token(Token = "0x60015B1")]
	internal static string ToSerializableString(IEnumerable<NameAndParameters> list) { }

	[Address(RVA = "0x2923940", Offset = "0x2922D40", Length = "0x1ED")]
	[Token(Token = "0x60015B0")]
	public virtual string ToString() { }

}

