namespace System.Diagnostics;

[AttributeUsage(AttributeTargets::All (32767))]
[Token(Token = "0x200010F")]
public class MonitoringDescriptionAttribute : DescriptionAttribute
{

	[Token(Token = "0x17000107")]
	public virtual string Description
	{
		[Address(RVA = "0x262F0E0", Offset = "0x262E4E0", Length = "0x7")]
		[Token(Token = "0x6000680")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x262F080", Offset = "0x262E480", Length = "0x59")]
	[Token(Token = "0x600067F")]
	public MonitoringDescriptionAttribute(string description) { }

	[Address(RVA = "0x262F0E0", Offset = "0x262E4E0", Length = "0x7")]
	[Token(Token = "0x6000680")]
	public virtual string get_Description() { }

}

