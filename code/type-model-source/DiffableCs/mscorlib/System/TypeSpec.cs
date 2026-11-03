namespace System;

[Token(Token = "0x20001D9")]
internal class TypeSpec
{
	[Flags]
	[Token(Token = "0x20001DA")]
	public enum DisplayNameFormat : int
	{
		Default = 0,
		WANT_ASSEMBLY = 1,
		NO_MODIFIERS = 2,
	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000911")]
	private TypeIdentifier name; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000912")]
	private string assembly_name; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000913")]
	private List<TypeIdentifier> nested; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000914")]
	private List<TypeSpec> generic_params; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000915")]
	private List<ModifierSpec> modifier_spec; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000916")]
	private bool is_byref; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000917")]
	private string display_fullname; //Field offset: 0x40

	[Token(Token = "0x17000175")]
	internal string DisplayFullName
	{
		[Address(RVA = "0x20A87F0", Offset = "0x20A7BF0", Length = "0x3E")]
		[Token(Token = "0x600109F")]
		internal get { } //Length: 62
	}

	[Token(Token = "0x17000174")]
	internal bool HasModifiers
	{
		[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
		[Token(Token = "0x600109C")]
		internal get { } //Length: 9
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60010A9")]
	public TypeSpec() { }

	[Address(RVA = "0x20A6420", Offset = "0x20A5820", Length = "0xFC")]
	[Token(Token = "0x60010A4")]
	private void AddModifier(ModifierSpec md) { }

	[Address(RVA = "0x20A6520", Offset = "0x20A5920", Length = "0x14A")]
	[Token(Token = "0x60010A3")]
	private void AddName(string type_name) { }

	[Address(RVA = "0x20A6670", Offset = "0x20A5A70", Length = "0x86")]
	[Token(Token = "0x60010A6")]
	private static void BoundCheck(int idx, string s) { }

	[Address(RVA = "0x20A87F0", Offset = "0x20A7BF0", Length = "0x3E")]
	[Token(Token = "0x600109F")]
	internal string get_DisplayFullName() { }

	[Address(RVA = "0x1550FC0", Offset = "0x15503C0", Length = "0x9")]
	[Token(Token = "0x600109C")]
	internal bool get_HasModifiers() { }

	[Address(RVA = "0x20A6700", Offset = "0x20A5B00", Length = "0x47E")]
	[Token(Token = "0x600109D")]
	private string GetDisplayFullName(DisplayNameFormat flags) { }

	[Address(RVA = "0x20A6B80", Offset = "0x20A5F80", Length = "0x1FE")]
	[Token(Token = "0x600109E")]
	private StringBuilder GetModifierString(StringBuilder sb) { }

	[Address(RVA = "0x20A7C50", Offset = "0x20A7050", Length = "0xE8")]
	[Token(Token = "0x60010A0")]
	internal static TypeSpec Parse(string typeName) { }

	[Address(RVA = "0x20A6D80", Offset = "0x20A6180", Length = "0xEAC")]
	[Token(Token = "0x60010A8")]
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	[Address(RVA = "0x20A7D40", Offset = "0x20A7140", Length = "0x7")]
	[Token(Token = "0x60010A7")]
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	[Address(RVA = "0x20A7D50", Offset = "0x20A7150", Length = "0x939")]
	[Token(Token = "0x60010A2")]
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, String, Boolean, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	[Address(RVA = "0x20A8690", Offset = "0x20A7A90", Length = "0x7C")]
	[Token(Token = "0x60010A5")]
	private static void SkipSpace(string name, ref int pos) { }

	[Address(RVA = "0x20A8710", Offset = "0x20A7B10", Length = "0xD3")]
	[Token(Token = "0x60010A1")]
	internal static string UnescapeInternalName(string displayName) { }

}

