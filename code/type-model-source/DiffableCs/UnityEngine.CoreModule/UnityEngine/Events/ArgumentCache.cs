namespace UnityEngine.Events;

[Token(Token = "0x2000234")]
internal class ArgumentCache : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	[Token(Token = "0x400078D")]
	private object m_ObjectArgument; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	[Token(Token = "0x400078E")]
	private string m_ObjectArgumentAssemblyTypeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	[Token(Token = "0x400078F")]
	private int m_IntArgument; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	[Token(Token = "0x4000790")]
	private float m_FloatArgument; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	[Token(Token = "0x4000791")]
	private string m_StringArgument; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000792")]
	private bool m_BoolArgument; //Field offset: 0x30

	[Token(Token = "0x17000387")]
	public bool boolArgument
	{
		[Address(RVA = "0x3076940", Offset = "0x3075D40", Length = "0x7")]
		[Token(Token = "0x60017B1")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000385")]
	public float floatArgument
	{
		[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
		[Token(Token = "0x60017AF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x17000384")]
	public int intArgument
	{
		[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
		[Token(Token = "0x60017AE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x17000386")]
	public string stringArgument
	{
		[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
		[Token(Token = "0x60017B0")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000382")]
	public object unityObjectArgument
	{
		[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
		[Token(Token = "0x60017AC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x17000383")]
	public string unityObjectArgumentAssemblyTypeName
	{
		[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
		[Token(Token = "0x60017AD")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
	[Token(Token = "0x60017B4")]
	public ArgumentCache() { }

	[Address(RVA = "0x3076940", Offset = "0x3075D40", Length = "0x7")]
	[Token(Token = "0x60017B1")]
	public bool get_boolArgument() { }

	[Address(RVA = "0x3076950", Offset = "0x3075D50", Length = "0x8")]
	[Token(Token = "0x60017AF")]
	public float get_floatArgument() { }

	[Address(RVA = "0x1073710", Offset = "0x1072B10", Length = "0x6")]
	[Token(Token = "0x60017AE")]
	public int get_intArgument() { }

	[Address(RVA = "0x2F94470", Offset = "0x2F93870", Length = "0x7")]
	[Token(Token = "0x60017B0")]
	public string get_stringArgument() { }

	[Address(RVA = "0x1C18DB0", Offset = "0x1C181B0", Length = "0x7")]
	[Token(Token = "0x60017AC")]
	public object get_unityObjectArgument() { }

	[Address(RVA = "0x198AF30", Offset = "0x198A330", Length = "0x7")]
	[Token(Token = "0x60017AD")]
	public string get_unityObjectArgumentAssemblyTypeName() { }

	[Address(RVA = "0x3076910", Offset = "0x3075D10", Length = "0x29")]
	[Token(Token = "0x60017B3")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x3076910", Offset = "0x3075D10", Length = "0x29")]
	[Token(Token = "0x60017B2")]
	public override void OnBeforeSerialize() { }

}

