namespace System.Runtime.Remoting.Lifetime;

[ComVisible(True)]
[Token(Token = "0x2000371")]
public sealed class LifetimeServices
{
	[Token(Token = "0x4000E4E")]
	private static TimeSpan _leaseManagerPollTime; //Field offset: 0x0
	[Token(Token = "0x4000E4F")]
	private static TimeSpan _leaseTime; //Field offset: 0x8
	[Token(Token = "0x4000E50")]
	private static TimeSpan _renewOnCallTime; //Field offset: 0x10
	[Token(Token = "0x4000E51")]
	private static TimeSpan _sponsorshipTimeout; //Field offset: 0x18
	[Token(Token = "0x4000E52")]
	private static LeaseManager _leaseManager; //Field offset: 0x20

	[Token(Token = "0x170002EE")]
	public static TimeSpan LeaseManagerPollTime
	{
		[Address(RVA = "0x1EE41A0", Offset = "0x1EE35A0", Length = "0x4E")]
		[Token(Token = "0x6001B90")]
		 get { } //Length: 78
		[Address(RVA = "0x1EE42E0", Offset = "0x1EE36E0", Length = "0x7A")]
		[Token(Token = "0x6001B91")]
		 set { } //Length: 122
	}

	[Token(Token = "0x170002EF")]
	public static TimeSpan LeaseTime
	{
		[Address(RVA = "0x1EE41F0", Offset = "0x1EE35F0", Length = "0x4F")]
		[Token(Token = "0x6001B92")]
		 get { } //Length: 79
		[Address(RVA = "0x1EE4360", Offset = "0x1EE3760", Length = "0x55")]
		[Token(Token = "0x6001B93")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170002F0")]
	public static TimeSpan RenewOnCallTime
	{
		[Address(RVA = "0x1EE4240", Offset = "0x1EE3640", Length = "0x4F")]
		[Token(Token = "0x6001B94")]
		 get { } //Length: 79
		[Address(RVA = "0x1EE43C0", Offset = "0x1EE37C0", Length = "0x55")]
		[Token(Token = "0x6001B95")]
		 set { } //Length: 85
	}

	[Token(Token = "0x170002F1")]
	public static TimeSpan SponsorshipTimeout
	{
		[Address(RVA = "0x1EE4290", Offset = "0x1EE3690", Length = "0x4F")]
		[Token(Token = "0x6001B96")]
		 get { } //Length: 79
		[Address(RVA = "0x1EE4420", Offset = "0x1EE3820", Length = "0x55")]
		[Token(Token = "0x6001B97")]
		 set { } //Length: 85
	}

	[Address(RVA = "0x1EE4030", Offset = "0x1EE3430", Length = "0x16B")]
	[Token(Token = "0x6001B8F")]
	private static LifetimeServices() { }

	[Address(RVA = "0x1EE41A0", Offset = "0x1EE35A0", Length = "0x4E")]
	[Token(Token = "0x6001B90")]
	public static TimeSpan get_LeaseManagerPollTime() { }

	[Address(RVA = "0x1EE41F0", Offset = "0x1EE35F0", Length = "0x4F")]
	[Token(Token = "0x6001B92")]
	public static TimeSpan get_LeaseTime() { }

	[Address(RVA = "0x1EE4240", Offset = "0x1EE3640", Length = "0x4F")]
	[Token(Token = "0x6001B94")]
	public static TimeSpan get_RenewOnCallTime() { }

	[Address(RVA = "0x1EE4290", Offset = "0x1EE3690", Length = "0x4F")]
	[Token(Token = "0x6001B96")]
	public static TimeSpan get_SponsorshipTimeout() { }

	[Address(RVA = "0x1EE42E0", Offset = "0x1EE36E0", Length = "0x7A")]
	[Token(Token = "0x6001B91")]
	public static void set_LeaseManagerPollTime(TimeSpan value) { }

	[Address(RVA = "0x1EE4360", Offset = "0x1EE3760", Length = "0x55")]
	[Token(Token = "0x6001B93")]
	public static void set_LeaseTime(TimeSpan value) { }

	[Address(RVA = "0x1EE43C0", Offset = "0x1EE37C0", Length = "0x55")]
	[Token(Token = "0x6001B95")]
	public static void set_RenewOnCallTime(TimeSpan value) { }

	[Address(RVA = "0x1EE4420", Offset = "0x1EE3820", Length = "0x55")]
	[Token(Token = "0x6001B97")]
	public static void set_SponsorshipTimeout(TimeSpan value) { }

	[Address(RVA = "0x1EE3FC0", Offset = "0x1EE33C0", Length = "0x69")]
	[Token(Token = "0x6001B98")]
	internal static void TrackLifetime(ServerIdentity identity) { }

}

