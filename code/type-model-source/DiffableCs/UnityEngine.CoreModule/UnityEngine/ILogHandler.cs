namespace UnityEngine;

[Token(Token = "0x2000149")]
public interface ILogHandler
{

	[Token(Token = "0x6000FC5")]
	public void LogException(Exception exception, object context) { }

	[Token(Token = "0x6000FC4")]
	public void LogFormat(LogType logType, object context, string format, Object[] args) { }

}

