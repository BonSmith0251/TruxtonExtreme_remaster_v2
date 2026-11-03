namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x200036A")]
public interface ILease
{

	[Token(Token = "0x170002E8")]
	public TimeSpan CurrentLeaseTime
	{
		[Token(Token = "0x6001B72")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002E9")]
	public LeaseState CurrentState
	{
		[Token(Token = "0x6001B73")]
		 get { } //Length: 0
	}

	[Token(Token = "0x170002EA")]
	public TimeSpan RenewOnCallTime
	{
		[Token(Token = "0x6001B74")]
		 get { } //Length: 0
	}

	[Token(Token = "0x6001B72")]
	public TimeSpan get_CurrentLeaseTime() { }

	[Token(Token = "0x6001B73")]
	public LeaseState get_CurrentState() { }

	[Token(Token = "0x6001B74")]
	public TimeSpan get_RenewOnCallTime() { }

	[Token(Token = "0x6001B75")]
	public TimeSpan Renew(TimeSpan renewalTime) { }

}

