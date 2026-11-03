namespace UnityEngine.InputSystem.Layouts;

[Token(Token = "0x2000213")]
public struct InputDeviceDescription : IEquatable<InputDeviceDescription>
{
	[Token(Token = "0x2000214")]
	private struct DeviceDescriptionJson
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000BD4")]
		public string interface; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000BD5")]
		public string type; //Field offset: 0x8
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000BD6")]
		public string product; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000BD7")]
		public string serial; //Field offset: 0x18
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000BD8")]
		public string version; //Field offset: 0x20
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4000BD9")]
		public string manufacturer; //Field offset: 0x28
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000BDA")]
		public string capabilities; //Field offset: 0x30

	}

	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	[Token(Token = "0x4000BCD")]
	private string m_InterfaceName; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[SerializeField]
	[Token(Token = "0x4000BCE")]
	private string m_DeviceClass; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000BCF")]
	private string m_Manufacturer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Token(Token = "0x4000BD0")]
	private string m_Product; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[Token(Token = "0x4000BD1")]
	private string m_Serial; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Token(Token = "0x4000BD2")]
	private string m_Version; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x4000BD3")]
	private string m_Capabilities; //Field offset: 0x30

	[Token(Token = "0x170005A8")]
	public string capabilities
	{
		[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
		[Token(Token = "0x60013C2")]
		 get { } //Length: 5
		[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
		[Token(Token = "0x60013C3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A3")]
	public string deviceClass
	{
		[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
		[Token(Token = "0x60013B8")]
		 get { } //Length: 5
		[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
		[Token(Token = "0x60013B9")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A9")]
	public bool empty
	{
		[Address(RVA = "0x2917550", Offset = "0x2916950", Length = "0x7A")]
		[Token(Token = "0x60013C4")]
		 get { } //Length: 122
	}

	[Token(Token = "0x170005A2")]
	public string interfaceName
	{
		[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
		[Token(Token = "0x60013B6")]
		 get { } //Length: 4
		[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
		[Token(Token = "0x60013B7")]
		 set { } //Length: 8
	}

	[Token(Token = "0x170005A4")]
	public string manufacturer
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x60013BA")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x60013BB")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A5")]
	public string product
	{
		[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
		[Token(Token = "0x60013BC")]
		 get { } //Length: 5
		[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
		[Token(Token = "0x60013BD")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A6")]
	public string serial
	{
		[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
		[Token(Token = "0x60013BE")]
		 get { } //Length: 5
		[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
		[Token(Token = "0x60013BF")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170005A7")]
	public string version
	{
		[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
		[Token(Token = "0x60013C0")]
		 get { } //Length: 5
		[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
		[Token(Token = "0x60013C1")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x2916BF0", Offset = "0x2915FF0", Length = "0x149")]
	[Token(Token = "0x60013CD")]
	internal static bool ComparePropertyToDeviceDescriptor(string propertyName, JsonString propertyValue, string deviceDescriptor) { }

	[Address(RVA = "0x2916D40", Offset = "0x2916140", Length = "0xAD")]
	[Token(Token = "0x60013C7")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x2916DF0", Offset = "0x29161F0", Length = "0xFC")]
	[Token(Token = "0x60013C6")]
	public override bool Equals(InputDeviceDescription other) { }

	[Address(RVA = "0x2916EF0", Offset = "0x29162F0", Length = "0x149")]
	[Token(Token = "0x60013CC")]
	public static InputDeviceDescription FromJson(string json) { }

	[Address(RVA = "0x5ACF10", Offset = "0x5AC310", Length = "0x5")]
	[Token(Token = "0x60013C2")]
	public string get_capabilities() { }

	[Address(RVA = "0xAEF220", Offset = "0xAEE620", Length = "0x5")]
	[Token(Token = "0x60013B8")]
	public string get_deviceClass() { }

	[Address(RVA = "0x2917550", Offset = "0x2916950", Length = "0x7A")]
	[Token(Token = "0x60013C4")]
	public bool get_empty() { }

	[Address(RVA = "0x81E9D0", Offset = "0x81DDD0", Length = "0x4")]
	[Token(Token = "0x60013B6")]
	public string get_interfaceName() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x60013BA")]
	public string get_manufacturer() { }

	[Address(RVA = "0x5BCD60", Offset = "0x5BC160", Length = "0x5")]
	[Token(Token = "0x60013BC")]
	public string get_product() { }

	[Address(RVA = "0x5AD590", Offset = "0x5AC990", Length = "0x5")]
	[Token(Token = "0x60013BE")]
	public string get_serial() { }

	[Address(RVA = "0x5ACF00", Offset = "0x5AC300", Length = "0x5")]
	[Token(Token = "0x60013C0")]
	public string get_version() { }

	[Address(RVA = "0x2917040", Offset = "0x2916440", Length = "0x16A")]
	[Token(Token = "0x60013C8")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x29175D0", Offset = "0x29169D0", Length = "0x3B")]
	[Token(Token = "0x60013C9")]
	public static bool op_Equality(InputDeviceDescription left, InputDeviceDescription right) { }

	[Address(RVA = "0x2917610", Offset = "0x2916A10", Length = "0x3D")]
	[Token(Token = "0x60013CA")]
	public static bool op_Inequality(InputDeviceDescription left, InputDeviceDescription right) { }

	[Address(RVA = "0x11EDBA0", Offset = "0x11ECFA0", Length = "0xD")]
	[Token(Token = "0x60013C3")]
	public void set_capabilities(string value) { }

	[Address(RVA = "0x17CB540", Offset = "0x17CA940", Length = "0xD")]
	[Token(Token = "0x60013B9")]
	public void set_deviceClass(string value) { }

	[Address(RVA = "0xFE3730", Offset = "0xFE2B30", Length = "0x8")]
	[Token(Token = "0x60013B7")]
	public void set_interfaceName(string value) { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x60013BB")]
	public void set_manufacturer(string value) { }

	[Address(RVA = "0xB0D610", Offset = "0xB0CA10", Length = "0xD")]
	[Token(Token = "0x60013BD")]
	public void set_product(string value) { }

	[Address(RVA = "0xD99F10", Offset = "0xD99310", Length = "0xD")]
	[Token(Token = "0x60013BF")]
	public void set_serial(string value) { }

	[Address(RVA = "0xB00190", Offset = "0xAFF590", Length = "0xD")]
	[Token(Token = "0x60013C1")]
	public void set_version(string value) { }

	[Address(RVA = "0x29171B0", Offset = "0x29165B0", Length = "0x10C")]
	[Token(Token = "0x60013CB")]
	public string ToJson() { }

	[Address(RVA = "0x29172C0", Offset = "0x29166C0", Length = "0x281")]
	[Token(Token = "0x60013C5")]
	public virtual string ToString() { }

}

