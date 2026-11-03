namespace System.Reflection;

[Token(Token = "0x20004F1")]
public abstract class Module : ICustomAttributeProvider, ISerializable, _Module
{
	[Token(Token = "0x400137D")]
	public static readonly TypeFilter FilterTypeName; //Field offset: 0x0
	[Token(Token = "0x400137F")]
	private const BindingFlags DefaultLookup = 28; //Field offset: 0x0
	[Token(Token = "0x400137E")]
	public static readonly TypeFilter FilterTypeNameIgnoreCase; //Field offset: 0x8

	[Token(Token = "0x17000444")]
	public override Assembly Assembly
	{
		[Address(RVA = "0x1F61F10", Offset = "0x1F61310", Length = "0x27")]
		[Token(Token = "0x600229A")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000445")]
	public override Guid ModuleVersionId
	{
		[Address(RVA = "0x1F61F40", Offset = "0x1F61340", Length = "0x27")]
		[Token(Token = "0x600229B")]
		 get { } //Length: 39
	}

	[Token(Token = "0x17000446")]
	public override string ScopeName
	{
		[Address(RVA = "0x1F61F70", Offset = "0x1F61370", Length = "0x27")]
		[Token(Token = "0x600229C")]
		 get { } //Length: 39
	}

	[Address(RVA = "0x1F61E20", Offset = "0x1F61220", Length = "0xE4")]
	[Token(Token = "0x60022A9")]
	private static Module() { }

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6002299")]
	protected Module() { }

	[Address(RVA = "0x1F4B850", Offset = "0x1F4AC50", Length = "0x8")]
	[Token(Token = "0x60022A2")]
	public virtual bool Equals(object o) { }

	[Address(RVA = "0x1F61A00", Offset = "0x1F60E00", Length = "0x195")]
	[Token(Token = "0x60022A7")]
	private static bool FilterTypeNameIgnoreCaseImpl(Type cls, object filterCriteria) { }

	[Address(RVA = "0x1F61BA0", Offset = "0x1F60FA0", Length = "0x14D")]
	[Token(Token = "0x60022A6")]
	private static bool FilterTypeNameImpl(Type cls, object filterCriteria) { }

	[Address(RVA = "0x1F61F10", Offset = "0x1F61310", Length = "0x27")]
	[Token(Token = "0x600229A")]
	public override Assembly get_Assembly() { }

	[Address(RVA = "0x1F61F40", Offset = "0x1F61340", Length = "0x27")]
	[Token(Token = "0x600229B")]
	public override Guid get_ModuleVersionId() { }

	[Address(RVA = "0x1F61F70", Offset = "0x1F61370", Length = "0x27")]
	[Token(Token = "0x600229C")]
	public override string get_ScopeName() { }

	[Address(RVA = "0x1F61D20", Offset = "0x1F61120", Length = "0x27")]
	[Token(Token = "0x600229F")]
	public override Object[] GetCustomAttributes(bool inherit) { }

	[Address(RVA = "0x1F61CF0", Offset = "0x1F610F0", Length = "0x27")]
	[Token(Token = "0x60022A0")]
	public override Object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1E9E150", Offset = "0x1E9D550", Length = "0x7")]
	[Token(Token = "0x60022A3")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1F61D50", Offset = "0x1F61150", Length = "0x3E")]
	[Token(Token = "0x60022A8")]
	internal override Guid GetModuleVersionId() { }

	[Address(RVA = "0x1F61D90", Offset = "0x1F61190", Length = "0x27")]
	[Token(Token = "0x60022A1")]
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[Address(RVA = "0x1F61DC0", Offset = "0x1F611C0", Length = "0x27")]
	[Token(Token = "0x600229E")]
	public override bool IsDefined(Type attributeType, bool inherit) { }

	[Address(RVA = "0x1F61DF0", Offset = "0x1F611F0", Length = "0x27")]
	[Token(Token = "0x600229D")]
	public override bool IsResource() { }

	[Address(RVA = "0x1F339B0", Offset = "0x1F32DB0", Length = "0x29")]
	[Token(Token = "0x60022A4")]
	public static bool op_Equality(Module left, Module right) { }

	[Address(RVA = "0x1DDF660", Offset = "0x1DDEA60", Length = "0x14")]
	[Token(Token = "0x60022A5")]
	public virtual string ToString() { }

}

