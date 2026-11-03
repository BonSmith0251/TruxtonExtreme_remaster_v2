//Type is in global namespace

[Token(Token = "0x2000002")]
public class PackedPlayModeBuildLogs
{
	[Token(Token = "0x2000003")]
	internal struct RuntimeBuildLog
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000002")]
		public LogType Type; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000003")]
		public string Message; //Field offset: 0x8

		[Address(RVA = "0xAEE390", Offset = "0xAED790", Length = "0x12")]
		[Token(Token = "0x6000004")]
		public RuntimeBuildLog(LogType type, string message) { }

	}

	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	[Token(Token = "0x4000001")]
	private List<RuntimeBuildLog> m_RuntimeBuildLogs; //Field offset: 0x10

	[Token(Token = "0x17000001")]
	public List<RuntimeBuildLog> RuntimeBuildLogs
	{
		[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
		[Token(Token = "0x6000001")]
		 get { } //Length: 5
		[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
		[Token(Token = "0x6000002")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x27AF840", Offset = "0x27AEC40", Length = "0x77")]
	[Token(Token = "0x6000003")]
	public PackedPlayModeBuildLogs() { }

	[Address(RVA = "0xAEF210", Offset = "0xAEE610", Length = "0x5")]
	[Token(Token = "0x6000001")]
	public List<RuntimeBuildLog> get_RuntimeBuildLogs() { }

	[Address(RVA = "0xE44720", Offset = "0xE43B20", Length = "0xD")]
	[Token(Token = "0x6000002")]
	public void set_RuntimeBuildLogs(List<RuntimeBuildLog> value) { }

}

