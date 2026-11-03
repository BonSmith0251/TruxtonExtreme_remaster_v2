namespace UnityEngine.AdaptivePerformance;

[Token(Token = "0x2000015")]
public interface IDevicePerformanceControl
{

	[Token(Token = "0x17000036")]
	public int CpuLevel
	{
		[Token(Token = "0x60000A9")]
		 get { } //Length: 0
		[Token(Token = "0x60000AA")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000037")]
	public int GpuLevel
	{
		[Token(Token = "0x60000AB")]
		 get { } //Length: 0
		[Token(Token = "0x60000AC")]
		 set { } //Length: 0
	}

	[Token(Token = "0x17000034")]
	public int MaxCpuPerformanceLevel
	{
		[Token(Token = "0x60000A7")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000035")]
	public int MaxGpuPerformanceLevel
	{
		[Token(Token = "0x60000A8")]
		 get { } //Length: 0
	}

	[Token(Token = "0x60000A9")]
	public int get_CpuLevel() { }

	[Token(Token = "0x60000AB")]
	public int get_GpuLevel() { }

	[Token(Token = "0x60000A7")]
	public int get_MaxCpuPerformanceLevel() { }

	[Token(Token = "0x60000A8")]
	public int get_MaxGpuPerformanceLevel() { }

	[Token(Token = "0x60000AA")]
	public void set_CpuLevel(int value) { }

	[Token(Token = "0x60000AC")]
	public void set_GpuLevel(int value) { }

}

