namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
[Token(Token = "0x2000134")]
public abstract class NamingStrategy
{
	[CompilerGenerated]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40005B9")]
	private bool <ProcessDictionaryKeys>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x40005BA")]
	private bool <ProcessExtensionDataNames>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	[FieldOffset(Offset = "0x12")]
	[Token(Token = "0x40005BB")]
	private bool <OverrideSpecifiedNames>k__BackingField; //Field offset: 0x12

	[Token(Token = "0x17000172")]
	public bool OverrideSpecifiedNames
	{
		[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600097F")]
		 get { } //Length: 5
		[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x6000980")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000170")]
	public bool ProcessDictionaryKeys
	{
		[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600097B")]
		 get { } //Length: 5
		[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600097C")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000171")]
	public bool ProcessExtensionDataNames
	{
		[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x600097D")]
		 get { } //Length: 5
		[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
		[CompilerGenerated]
		[Token(Token = "0x600097E")]
		 set { } //Length: 4
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x6000988")]
	protected NamingStrategy() { }

	[Address(RVA = "0x216CDA0", Offset = "0x216C1A0", Length = "0xED")]
	[NullableContext(2)]
	[Token(Token = "0x6000986")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x216CD00", Offset = "0x216C100", Length = "0x9B")]
	[NullableContext(2)]
	[Token(Token = "0x6000987")]
	protected bool Equals(NamingStrategy other) { }

	[Address(RVA = "0x10AACD0", Offset = "0x10AA0D0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600097F")]
	public bool get_OverrideSpecifiedNames() { }

	[Address(RVA = "0x10AACB0", Offset = "0x10AA0B0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600097B")]
	public bool get_ProcessDictionaryKeys() { }

	[Address(RVA = "0x10AACC0", Offset = "0x10AA0C0", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x600097D")]
	public bool get_ProcessExtensionDataNames() { }

	[Address(RVA = "0x216CE90", Offset = "0x216C290", Length = "0x1E")]
	[Token(Token = "0x6000983")]
	public override string GetDictionaryKey(string key) { }

	[Address(RVA = "0x216CEB0", Offset = "0x216C2B0", Length = "0x1E")]
	[Token(Token = "0x6000982")]
	public override string GetExtensionDataName(string name) { }

	[Address(RVA = "0x216CED0", Offset = "0x216C2D0", Length = "0xCD")]
	[Token(Token = "0x6000985")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x216CFA0", Offset = "0x216C3A0", Length = "0x23")]
	[Token(Token = "0x6000981")]
	public override string GetPropertyName(string name, bool hasSpecifiedName) { }

	[Token(Token = "0x6000984")]
	protected abstract string ResolvePropertyName(string name) { }

	[Address(RVA = "0x216CFD0", Offset = "0x216C3D0", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x6000980")]
	public void set_OverrideSpecifiedNames(bool value) { }

	[Address(RVA = "0x1160480", Offset = "0x115F880", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600097C")]
	public void set_ProcessDictionaryKeys(bool value) { }

	[Address(RVA = "0x1FD5130", Offset = "0x1FD4530", Length = "0x4")]
	[CompilerGenerated]
	[Token(Token = "0x600097E")]
	public void set_ProcessExtensionDataNames(bool value) { }

}

