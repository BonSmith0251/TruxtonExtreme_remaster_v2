namespace Unity.Properties;

[IsReadOnly]
[Token(Token = "0x200001E")]
internal struct FieldMember : IMemberInfo
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000037")]
	internal readonly FieldInfo m_FieldInfo; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000038")]
	private readonly string <Name>k__BackingField; //Field offset: 0x8

	[Token(Token = "0x17000019")]
	public override bool IsReadOnly
	{
		[Address(RVA = "0x31420F0", Offset = "0x31414F0", Length = "0x1C")]
		[Token(Token = "0x6000072")]
		 get { } //Length: 28
	}

	[Token(Token = "0x17000018")]
	public override string Name
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[CompilerGenerated]
		[Token(Token = "0x6000071")]
		 get { } //Length: 5
	}

	[Token(Token = "0x1700001A")]
	public override Type ValueType
	{
		[Address(RVA = "0x3142110", Offset = "0x3141510", Length = "0x29")]
		[Token(Token = "0x6000073")]
		 get { } //Length: 41
	}

	[Address(RVA = "0x31420C0", Offset = "0x31414C0", Length = "0x30")]
	[Token(Token = "0x6000070")]
	public FieldMember(FieldInfo fieldInfo) { }

	[Address(RVA = "0x31420F0", Offset = "0x31414F0", Length = "0x1C")]
	[Token(Token = "0x6000072")]
	public override bool get_IsReadOnly() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[CompilerGenerated]
	[Token(Token = "0x6000071")]
	public override string get_Name() { }

	[Address(RVA = "0x3142110", Offset = "0x3141510", Length = "0x29")]
	[Token(Token = "0x6000073")]
	public override Type get_ValueType() { }

	[Address(RVA = "0x3142060", Offset = "0x3141460", Length = "0xA")]
	[Token(Token = "0x6000076")]
	public override IEnumerable<Attribute> GetCustomAttributes() { }

	[Address(RVA = "0x3142070", Offset = "0x3141470", Length = "0x29")]
	[Token(Token = "0x6000074")]
	public override object GetValue(object obj) { }

	[Address(RVA = "0x31420A0", Offset = "0x31414A0", Length = "0x1D")]
	[Token(Token = "0x6000075")]
	public override void SetValue(object obj, object value) { }

}

