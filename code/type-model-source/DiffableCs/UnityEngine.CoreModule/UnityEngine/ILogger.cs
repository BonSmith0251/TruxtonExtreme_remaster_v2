namespace UnityEngine;

[Token(Token = "0x2000148")]
public interface ILogger : ILogHandler
{

	[Token(Token = "0x17000270")]
	public bool logEnabled
	{
		[Token(Token = "0x6000FBE")]
		 get { } //Length: 0
	}

	[Token(Token = "0x1700026F")]
	public ILogHandler logHandler
	{
		[Token(Token = "0x6000FBD")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6000FBE")]
	public bool get_logEnabled() { }

	[Token(Token = "0x6000FBD")]
	public ILogHandler get_logHandler() { }

	[Token(Token = "0x6000FBF")]
	public bool IsLogTypeAllowed(LogType logType) { }

	[Token(Token = "0x6000FC0")]
	public void Log(LogType logType, object message) { }

	[Token(Token = "0x6000FC1")]
	public void Log(LogType logType, object message, object context) { }

	[Token(Token = "0x6000FC2")]
	public void LogError(string tag, object message) { }

	[Token(Token = "0x6000FC3")]
	public void LogFormat(LogType logType, string format, Object[] args) { }

}

