namespace UnityEngine.InputSystem.Utilities;

[Token(Token = "0x2000248")]
internal struct JsonParser
{
	[Token(Token = "0x200024A")]
	internal struct JsonString : IEquatable<JsonString>
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C90")]
		public Substring text; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C91")]
		public bool hasEscapes; //Field offset: 0x10

		[Address(RVA = "0x291B700", Offset = "0x291AB00", Length = "0x182")]
		[Token(Token = "0x600156D")]
		public override bool Equals(JsonString other) { }

		[Address(RVA = "0x291B890", Offset = "0x291AC90", Length = "0x9B")]
		[Token(Token = "0x600156E")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x291B930", Offset = "0x291AD30", Length = "0x49")]
		[Token(Token = "0x600156F")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x291BA70", Offset = "0x291AE70", Length = "0x29")]
		[Token(Token = "0x6001570")]
		public static bool op_Equality(JsonString left, JsonString right) { }

		[Address(RVA = "0x291BAA0", Offset = "0x291AEA0", Length = "0x3B")]
		[Token(Token = "0x6001572")]
		public static JsonString op_Implicit(string str) { }

		[Address(RVA = "0x291BAE0", Offset = "0x291AEE0", Length = "0x2B")]
		[Token(Token = "0x6001571")]
		public static bool op_Inequality(JsonString left, JsonString right) { }

		[Address(RVA = "0x291B980", Offset = "0x291AD80", Length = "0xE5")]
		[Token(Token = "0x600156C")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x200024B")]
	internal struct JsonValue : IEquatable<JsonValue>
	{
		[CompilerGenerated]
		[Token(Token = "0x200024C")]
		private sealed class <>c
		{
			[Token(Token = "0x4000C9A")]
			public static readonly <>c <>9; //Field offset: 0x0
			[Token(Token = "0x4000C9B")]
			public static Func<JsonValue, String> <>9__11_0; //Field offset: 0x8
			[Token(Token = "0x4000C9C")]
			public static Func<KeyValuePair`2<String, JsonValue>, String> <>9__11_1; //Field offset: 0x10

			[Address(RVA = "0x292B290", Offset = "0x292A690", Length = "0x67")]
			[Token(Token = "0x6001585")]
			private static <>c() { }

			[Address(RVA = "0x5B09E0", Offset = "0x5AFDE0", Length = "0x7")]
			[Token(Token = "0x6001586")]
			public <>c() { }

			[Address(RVA = "0x292B0A0", Offset = "0x292A4A0", Length = "0x13")]
			[Token(Token = "0x6001587")]
			internal string <ToString>b__11_0(JsonValue x) { }

			[Address(RVA = "0x292B0C0", Offset = "0x292A4C0", Length = "0xA4")]
			[Token(Token = "0x6001588")]
			internal string <ToString>b__11_1(KeyValuePair<String, JsonValue> pair) { }

		}

		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000C92")]
		public JsonValueType type; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000C93")]
		public bool boolValue; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000C94")]
		public double realValue; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000C95")]
		public long integerValue; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000C96")]
		public JsonString stringValue; //Field offset: 0x18
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000C97")]
		public List<JsonValue> arrayValue; //Field offset: 0x30
		[FieldOffset(Offset = "0x38")]
		[Token(Token = "0x4000C98")]
		public Dictionary<String, JsonValue> objectValue; //Field offset: 0x38
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000C99")]
		public object anyValue; //Field offset: 0x40

		[Address(RVA = "0x291BDF0", Offset = "0x291B1F0", Length = "0xBC")]
		[Token(Token = "0x6001581")]
		public virtual bool Equals(object obj) { }

		[Address(RVA = "0x291BEB0", Offset = "0x291B2B0", Length = "0x91A")]
		[Token(Token = "0x6001580")]
		private static bool Equals(object obj, JsonValue value) { }

		[Address(RVA = "0x291BB10", Offset = "0x291AF10", Length = "0x120")]
		[Token(Token = "0x600157F")]
		public override bool Equals(JsonValue other) { }

		[Address(RVA = "0x291C7D0", Offset = "0x291BBD0", Length = "0x182")]
		[Token(Token = "0x6001582")]
		public virtual int GetHashCode() { }

		[Address(RVA = "0x291CFD0", Offset = "0x291C3D0", Length = "0x44")]
		[Token(Token = "0x6001583")]
		public static bool op_Equality(JsonValue left, JsonValue right) { }

		[Address(RVA = "0x291D170", Offset = "0x291C570", Length = "0x4D")]
		[Token(Token = "0x600157B")]
		public static JsonValue op_Implicit(JsonString str) { }

		[Address(RVA = "0x291D020", Offset = "0x291C420", Length = "0x25")]
		[Token(Token = "0x6001577")]
		public static JsonValue op_Implicit(bool val) { }

		[Address(RVA = "0x291D1C0", Offset = "0x291C5C0", Length = "0x2F")]
		[Token(Token = "0x6001578")]
		public static JsonValue op_Implicit(long val) { }

		[Address(RVA = "0x291D240", Offset = "0x291C640", Length = "0x2E")]
		[Token(Token = "0x6001579")]
		public static JsonValue op_Implicit(double val) { }

		[Address(RVA = "0x291D0A0", Offset = "0x291C4A0", Length = "0x7A")]
		[Token(Token = "0x600157A")]
		public static JsonValue op_Implicit(string str) { }

		[Address(RVA = "0x291D050", Offset = "0x291C450", Length = "0x46")]
		[Token(Token = "0x600157C")]
		public static JsonValue op_Implicit(List<JsonValue> array) { }

		[Address(RVA = "0x291D1F0", Offset = "0x291C5F0", Length = "0x46")]
		[Token(Token = "0x600157D")]
		public static JsonValue op_Implicit(Dictionary<String, JsonValue> obj) { }

		[Address(RVA = "0x291D120", Offset = "0x291C520", Length = "0x46")]
		[Token(Token = "0x600157E")]
		public static JsonValue op_Implicit(Enum val) { }

		[Address(RVA = "0x291D270", Offset = "0x291C670", Length = "0x46")]
		[Token(Token = "0x6001584")]
		public static bool op_Inequality(JsonValue left, JsonValue right) { }

		[Address(RVA = "0x291C960", Offset = "0x291BD60", Length = "0xA1")]
		[Token(Token = "0x6001573")]
		public bool ToBoolean() { }

		[Address(RVA = "0x291CA10", Offset = "0x291BE10", Length = "0xAA")]
		[Token(Token = "0x6001575")]
		public double ToDouble() { }

		[Address(RVA = "0x291CAC0", Offset = "0x291BEC0", Length = "0x98")]
		[Token(Token = "0x6001574")]
		public long ToInteger() { }

		[Address(RVA = "0x291CB60", Offset = "0x291BF60", Length = "0x44C")]
		[Token(Token = "0x6001576")]
		public virtual string ToString() { }

	}

	[Token(Token = "0x2000249")]
	internal enum JsonValueType : int
	{
		None = 0,
		Bool = 1,
		Real = 2,
		Integer = 3,
		String = 4,
		Array = 5,
		Object = 6,
		Any = 7,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000C82")]
	private readonly string m_Text; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000C83")]
	private readonly int m_Length; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000C84")]
	private int m_Position; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000C85")]
	private bool m_MatchAnyElementInArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x11")]
	[Token(Token = "0x4000C86")]
	private bool m_DryRun; //Field offset: 0x11

	[Token(Token = "0x170005FA")]
	public bool isAtEnd
	{
		[Address(RVA = "0x291B6F0", Offset = "0x291AAF0", Length = "0xA")]
		[Token(Token = "0x600156B")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x291B660", Offset = "0x291AA60", Length = "0x82")]
	[Token(Token = "0x600155A")]
	public JsonParser(string json) { }

	[Address(RVA = "0x2919C10", Offset = "0x2919010", Length = "0x1D6")]
	[Token(Token = "0x600155E")]
	public bool CurrentPropertyHasValueEqualTo(JsonValue expectedValue) { }

	[Address(RVA = "0x291B6F0", Offset = "0x291AAF0", Length = "0xA")]
	[Token(Token = "0x600156B")]
	public bool get_isAtEnd() { }

	[Address(RVA = "0x2919DF0", Offset = "0x29191F0", Length = "0x462")]
	[Token(Token = "0x600155D")]
	public bool NavigateToProperty(string path) { }

	[Address(RVA = "0x291A260", Offset = "0x2919660", Length = "0x300")]
	[Token(Token = "0x6001563")]
	public bool ParseArrayValue(out JsonValue result) { }

	[Address(RVA = "0x291A570", Offset = "0x2919970", Length = "0x151")]
	[Token(Token = "0x6001566")]
	public bool ParseBooleanValue(out JsonValue result) { }

	[Address(RVA = "0x291A6D0", Offset = "0x2919AD0", Length = "0x60")]
	[Token(Token = "0x6001567")]
	public bool ParseNullValue(out JsonValue result) { }

	[Address(RVA = "0x291A730", Offset = "0x2919B30", Length = "0x4C4")]
	[Token(Token = "0x6001565")]
	public bool ParseNumber(out JsonValue result) { }

	[Address(RVA = "0x291AC00", Offset = "0x291A000", Length = "0x218")]
	[Token(Token = "0x6001564")]
	public bool ParseObjectValue(out JsonValue result) { }

	[Address(RVA = "0x291AE20", Offset = "0x291A220", Length = "0x22B")]
	[Token(Token = "0x6001562")]
	public bool ParseStringValue(out JsonValue result) { }

	[Address(RVA = "0x291B050", Offset = "0x291A450", Length = "0x113")]
	[Token(Token = "0x600155F")]
	public bool ParseToken(char token) { }

	[Address(RVA = "0x291B2E0", Offset = "0x291A6E0", Length = "0x34")]
	[Token(Token = "0x6001560")]
	public bool ParseValue() { }

	[Address(RVA = "0x291B170", Offset = "0x291A570", Length = "0x166")]
	[Token(Token = "0x6001561")]
	public bool ParseValue(out JsonValue result) { }

	[Address(RVA = "0x291B320", Offset = "0x291A720", Length = "0xE")]
	[Token(Token = "0x600155B")]
	public void Reset() { }

	[Address(RVA = "0x291B330", Offset = "0x291A730", Length = "0xEE")]
	[Token(Token = "0x6001569")]
	private bool SkipString(string text) { }

	[Address(RVA = "0x291B420", Offset = "0x291A820", Length = "0xF8")]
	[Token(Token = "0x6001568")]
	public bool SkipToValue() { }

	[Address(RVA = "0x291B520", Offset = "0x291A920", Length = "0x6A")]
	[Token(Token = "0x600156A")]
	private void SkipWhitespace() { }

	[Address(RVA = "0x291B590", Offset = "0x291A990", Length = "0xC3")]
	[Token(Token = "0x600155C")]
	public virtual string ToString() { }

}

