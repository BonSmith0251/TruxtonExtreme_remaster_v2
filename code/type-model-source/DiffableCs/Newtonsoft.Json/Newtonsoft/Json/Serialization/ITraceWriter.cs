namespace Newtonsoft.Json.Serialization;

[NullableContext(1)]
[Token(Token = "0x2000110")]
public interface ITraceWriter
{

	[Token(Token = "0x170000F8")]
	public TraceLevel LevelFilter
	{
		[Token(Token = "0x60007C8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60007C8")]
	public TraceLevel get_LevelFilter() { }

	[Token(Token = "0x60007C9")]
	public void Trace(TraceLevel level, string message, Exception ex) { }

}

